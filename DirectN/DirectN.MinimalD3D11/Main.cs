using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DirectN.MinimalD3D11
{
    public class Main : Form
    {
        private IComObject<ID3D11DeviceContext> _deviceContext;
        private IComObject<IDXGISwapChain1> _swapChain;
        private IComObject<ID3D11Buffer> _constantBuffer;
        private IComObject<ID3D11Buffer> _vertexBuffer;
        private IComObject<ID3D11Buffer> _indexBuffer;
        private IComObject<ID3D11RenderTargetView> _renderTargetView;
        private IComObject<ID3D11DepthStencilView> _depthBufferView;
        private IComObject<ID3D11InputLayout> _inputLayout;
        private IComObject<ID3D11VertexShader> _vertexShader;
        private IComObject<ID3D11PixelShader> _pixelShader;
        private IComObject<ID3D11DepthStencilState> _depthStencilState;
        private IComObject<ID3D11BlendState> _blendState;
        private IComObject<ID3D11SamplerState> _samplerState;
        private IComObject<ID3D11RasterizerState> _rasterizerState;
        private IComObject<ID3D11ShaderResourceView> _shaderResourceView;

        private XMFLOAT3 _modelRotation = new XMFLOAT3(0, 0, 0);
        private XMFLOAT3 _modelScale = new XMFLOAT3(400, 400, 400);
        private XMFLOAT3 _modelTranslation = new XMFLOAT3(0, 0, 1500);
        private float _width;
        private float _height;
        private readonly float _zNear = 1000.0f;
        private readonly float _zFar = 1000000.0f;

        private VerticalBlankTicker _ticker;

        public Main()
        {
            Text = "minimal d3d11 by d7samurai - On .NET Core 5.0";
            int size = 1000;
            Size = new Size(size, size);
        }

        protected override void Dispose(bool disposing)
        {
            _ticker?.Stop(1000);
            _deviceContext?.Dispose();
            _swapChain?.Dispose();
            _constantBuffer?.Dispose();
            _vertexBuffer?.Dispose();
            _indexBuffer?.Dispose();
            _renderTargetView?.Dispose();
            _depthBufferView?.Dispose();
            _inputLayout?.Dispose();
            _vertexShader?.Dispose();
            _pixelShader?.Dispose();
            _depthStencilState?.Dispose();
            _blendState?.Dispose();
            _samplerState?.Dispose();
            _rasterizerState?.Dispose();
            _shaderResourceView?.Dispose();
            GC.Collect();
            base.Dispose(disposing);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            Init();
            _ticker = new VerticalBlankTicker();
            _ticker.Tick += (s, e) =>
            {
                Render();
            };
            _ticker.Start();
            base.OnHandleCreated(e);
        }

        private void Init()
        {
            // this code is ported from https://gist.github.com/d7samurai/261c69490cce0620d0bfc93003cd1052
            var fac = DXGIFunctions.CreateDXGIFactory2();
            var flags = D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_BGRA_SUPPORT;

#if DEBUG
            flags |= D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_DEBUG;
#endif

            var d3D11Device = D3D11Functions.D3D11CreateDevice(null, D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE, flags, out _deviceContext);

            var mt = d3D11Device.As<ID3D11Multithread>();
            mt?.SetMultithreadProtected(true);

            var desc = new DXGI_SWAP_CHAIN_DESC1();
            desc.Format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM_SRGB;
            desc.SampleDesc.Count = 1;
            desc.BufferUsage = Constants.DXGI_USAGE_RENDER_TARGET_OUTPUT;
            desc.BufferCount = 2;

            // note: this causes a warning in debug
            // DXGI WARNING: IDXGIFactory::CreateSwapChain: Blt-model swap effects (DXGI_SWAP_EFFECT_DISCARD and DXGI_SWAP_EFFECT_SEQUENTIAL) are legacy swap effects that are predominantly superceded by their flip-model counterparts (DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL and DXGI_SWAP_EFFECT_FLIP_DISCARD). Please consider updating your application to leverage flip-model swap effects to benefit from modern presentation enhancements. More information is available at http://aka.ms/dxgiflipmodel. [ MISCELLANEOUS WARNING #294: ]
            _swapChain = fac.CreateSwapChainForHwnd<IDXGISwapChain1>(d3D11Device, Handle, desc);
            var frameBuffer = _swapChain.GetBuffer<ID3D11Texture2D>(0);
            _renderTargetView = d3D11Device.CreateRenderTargetView(frameBuffer);

            frameBuffer.Object.GetDesc(out var depthBufferDesc);
            _width = depthBufferDesc.Width;
            _height = depthBufferDesc.Height;

            depthBufferDesc.Format = DXGI_FORMAT.DXGI_FORMAT_D24_UNORM_S8_UINT;
            depthBufferDesc.BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_DEPTH_STENCIL;
            var depthBuffer = d3D11Device.CreateTexture2D<ID3D11Texture2D>(depthBufferDesc);

            _depthBufferView = d3D11Device.CreateDepthStencilView(depthBuffer);

            var vsBlob = D3D11Functions.D3DCompileFromFile("shaders.hlsl", "vs_main", "vs_5_0");
            _vertexShader = d3D11Device.CreateVertexShader(vsBlob);

            var inputElements = new D3D11_INPUT_ELEMENT_DESC[]{
                    new D3D11_INPUT_ELEMENT_DESC{ SemanticName= "POS", Format =  DXGI_FORMAT.DXGI_FORMAT_R32G32B32_FLOAT },
                    new D3D11_INPUT_ELEMENT_DESC{ SemanticName= "NOR", Format = DXGI_FORMAT.DXGI_FORMAT_R32G32B32_FLOAT , AlignedByteOffset = unchecked((uint)Constants.D3D11_APPEND_ALIGNED_ELEMENT)},
                    new D3D11_INPUT_ELEMENT_DESC{ SemanticName= "TEX", Format = DXGI_FORMAT.DXGI_FORMAT_R32G32_FLOAT , AlignedByteOffset = unchecked((uint)Constants.D3D11_APPEND_ALIGNED_ELEMENT)},
                    new D3D11_INPUT_ELEMENT_DESC{ SemanticName= "COL", Format = DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT, AlignedByteOffset = unchecked((uint)Constants.D3D11_APPEND_ALIGNED_ELEMENT) },
                };
            _inputLayout = d3D11Device.CreateInputLayout(inputElements, vsBlob);

            var psBlob = D3D11Functions.D3DCompileFromFile("shaders.hlsl", "ps_main", "ps_5_0");
            _pixelShader = d3D11Device.CreatePixelShader(psBlob);

            var rasterizerDesc = new D3D11_RASTERIZER_DESC();
            rasterizerDesc.FillMode = D3D11_FILL_MODE.D3D11_FILL_SOLID;
            rasterizerDesc.CullMode = D3D11_CULL_MODE.D3D11_CULL_BACK;
            _rasterizerState = d3D11Device.CreateRasterizerState(rasterizerDesc);

            var samplerDesc = new D3D11_SAMPLER_DESC();
            samplerDesc.Filter = D3D11_FILTER.D3D11_FILTER_MIN_MAG_MIP_POINT;
            samplerDesc.AddressU = D3D11_TEXTURE_ADDRESS_MODE.D3D11_TEXTURE_ADDRESS_BORDER;
            samplerDesc.AddressV = D3D11_TEXTURE_ADDRESS_MODE.D3D11_TEXTURE_ADDRESS_BORDER;
            samplerDesc.AddressW = D3D11_TEXTURE_ADDRESS_MODE.D3D11_TEXTURE_ADDRESS_BORDER;
            samplerDesc.BorderColor = new float[4];
            samplerDesc.BorderColor[0] = 1;
            samplerDesc.BorderColor[1] = 1;
            samplerDesc.BorderColor[2] = 1;
            samplerDesc.BorderColor[3] = 1;
            samplerDesc.ComparisonFunc = D3D11_COMPARISON_FUNC.D3D11_COMPARISON_NEVER;
            _samplerState = d3D11Device.CreateSamplerState(samplerDesc);

            var depthStencilDesc = new D3D11_DEPTH_STENCIL_DESC();
            depthStencilDesc.DepthEnable = true;
            depthStencilDesc.DepthWriteMask = D3D11_DEPTH_WRITE_MASK.D3D11_DEPTH_WRITE_MASK_ALL;
            depthStencilDesc.DepthFunc = D3D11_COMPARISON_FUNC.D3D11_COMPARISON_LESS;
            _depthStencilState = d3D11Device.CreateDepthStencilState(depthStencilDesc);

            var blendDesc = new D3D11_BLEND_DESC();
            blendDesc.RenderTarget = new D3D11_RENDER_TARGET_BLEND_DESC[8];
            blendDesc.RenderTarget[0].BlendEnable = true;
            blendDesc.RenderTarget[0].SrcBlend = D3D11_BLEND.D3D11_BLEND_SRC_ALPHA;
            blendDesc.RenderTarget[0].DestBlend = D3D11_BLEND.D3D11_BLEND_INV_SRC_ALPHA;
            blendDesc.RenderTarget[0].BlendOp = D3D11_BLEND_OP.D3D11_BLEND_OP_ADD;
            blendDesc.RenderTarget[0].SrcBlendAlpha = D3D11_BLEND.D3D11_BLEND_ZERO;
            blendDesc.RenderTarget[0].DestBlendAlpha = D3D11_BLEND.D3D11_BLEND_ZERO;
            blendDesc.RenderTarget[0].BlendOpAlpha = D3D11_BLEND_OP.D3D11_BLEND_OP_ADD;
            blendDesc.RenderTarget[0].RenderTargetWriteMask = (byte)D3D11_COLOR_WRITE_ENABLE.D3D11_COLOR_WRITE_ENABLE_ALL;
            _blendState = d3D11Device.CreateBlendState(blendDesc);

            var constantBufferDesc = new D3D11_BUFFER_DESC();
            constantBufferDesc.ByteWidth = (uint)Marshal.SizeOf<VS_CONSTANT_BUFFER>();
            constantBufferDesc.Usage = D3D11_USAGE.D3D11_USAGE_DYNAMIC;
            constantBufferDesc.BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_CONSTANT_BUFFER;
            constantBufferDesc.CPUAccessFlags = (uint)D3D11_CPU_ACCESS_FLAG.D3D11_CPU_ACCESS_WRITE;
            if ((constantBufferDesc.ByteWidth % 16) != 0)
                throw new InvalidOperationException("Constant buffer size must be a multiple of 16.");

            _constantBuffer = d3D11Device.CreateBuffer(constantBufferDesc);

            var vertexBufferDesc = new D3D11_BUFFER_DESC();
            var gc = GCHandle.Alloc(Data.VertexData, GCHandleType.Pinned);
            vertexBufferDesc.ByteWidth = (uint)Data.VertexData.SizeOf();
            vertexBufferDesc.Usage = D3D11_USAGE.D3D11_USAGE_IMMUTABLE;
            vertexBufferDesc.BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_VERTEX_BUFFER;

            var vertexData = new D3D11_SUBRESOURCE_DATA();
            vertexData.pSysMem = gc.AddrOfPinnedObject();
            _vertexBuffer = d3D11Device.CreateBuffer(vertexBufferDesc, vertexData);
            gc.Free();

            var indexBufferDesc = new D3D11_BUFFER_DESC();
            gc = GCHandle.Alloc(Data.IndexData, GCHandleType.Pinned);
            indexBufferDesc.ByteWidth = (uint)Data.IndexData.SizeOf();
            indexBufferDesc.Usage = D3D11_USAGE.D3D11_USAGE_IMMUTABLE;
            indexBufferDesc.BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_INDEX_BUFFER;

            var indexData = new D3D11_SUBRESOURCE_DATA();
            indexData.pSysMem = gc.AddrOfPinnedObject();
            _indexBuffer = d3D11Device.CreateBuffer(indexBufferDesc, indexData);
            gc.Free();

            var textureDesc = new D3D11_TEXTURE2D_DESC();
            textureDesc.Width = 20;
            textureDesc.Height = 20;
            textureDesc.MipLevels = 1;
            textureDesc.ArraySize = 1;
            textureDesc.Format = DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM_SRGB;
            textureDesc.SampleDesc.Count = 1;
            textureDesc.Usage = D3D11_USAGE.D3D11_USAGE_IMMUTABLE;
            textureDesc.BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_SHADER_RESOURCE;

            gc = GCHandle.Alloc(Data.TextureData, GCHandleType.Pinned);
            var textureData = new D3D11_SUBRESOURCE_DATA();
            textureData.pSysMem = gc.AddrOfPinnedObject();
            textureData.SysMemPitch = 20 * 4; // 4 bytes per pixel
            gc.Free();

            var texture = d3D11Device.CreateTexture2D<ID3D11Texture2D>(textureDesc, textureData);
            _shaderResourceView = d3D11Device.CreateShaderResourceView(texture);
        }

        private void Render()
        {
            var rotateX = D2D_MATRIX_4X4_F.RotationX(_modelRotation.x);
            var rotateY = D2D_MATRIX_4X4_F.RotationY(_modelRotation.y);
            var rotateZ = D2D_MATRIX_4X4_F.RotationZ(_modelRotation.z);
            var scale = D2D_MATRIX_4X4_F.Scale(_modelScale.x, _modelScale.y, _modelScale.z);
            var translate = D2D_MATRIX_4X4_F.Translation(_modelTranslation.x, _modelTranslation.y, _modelTranslation.z);

            _modelRotation.x += 0.5f;
            _modelRotation.y += 0.9f;
            _modelRotation.z += 0.1f;

            void mapAction(ref D3D11_MAPPED_SUBRESOURCE mapped, ref VS_CONSTANT_BUFFER buffer)
            {
                buffer.Transform = rotateX * rotateY * rotateZ * scale * translate;
                buffer.Projection = D2D_MATRIX_4X4_F.PerspectiveProjection(_width, _height, _zNear, _zFar);
                buffer.LightVector = new XMFLOAT3(1, -1, 1);
            }

            _deviceContext.WithMap<VS_CONSTANT_BUFFER>(_constantBuffer, 0, D3D11_MAP.D3D11_MAP_WRITE_DISCARD, mapAction);

            var backgroundColor = new float[] { 0.025f, 0.025f, 0.025f, 1 };

            uint stride = 12 * 4; // vertex size (12 floats: float3 position, float3 normal, float2 texcoord, float4 color)
            uint offset = 0;

            _deviceContext.Object.ClearRenderTargetView(_renderTargetView.Object, backgroundColor);
            _deviceContext.Object.ClearDepthStencilView(_depthBufferView.Object, (uint)D3D11_CLEAR_FLAG.D3D11_CLEAR_DEPTH, 1, 0);

            _deviceContext.Object.IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST);
            _deviceContext.Object.IASetInputLayout(_inputLayout.Object);
            _deviceContext.Object.IASetVertexBuffers(0, 1, new ID3D11Buffer[] { _vertexBuffer.Object }, new uint[] { stride }, new uint[] { offset });
            _deviceContext.Object.IASetIndexBuffer(_indexBuffer.Object, DXGI_FORMAT.DXGI_FORMAT_R32_UINT, 0);

            _deviceContext.Object.VSSetShader(_vertexShader.Object, null, 0);
            _deviceContext.Object.VSSetConstantBuffers(0, 1, new ID3D11Buffer[] { _constantBuffer.Object });

            var viewport = new D3D11_VIEWPORT();
            viewport.Width = _width;
            viewport.Height = _height;
            viewport.MaxDepth = 1;
            _deviceContext.Object.RSSetViewports(1, new D3D11_VIEWPORT[] { viewport });
            _deviceContext.Object.RSSetState(_rasterizerState.Object);

            _deviceContext.Object.PSSetShader(_pixelShader.Object, null, 0);
            _deviceContext.Object.PSSetShaderResources(0, 1, new ID3D11ShaderResourceView[] { _shaderResourceView.Object });
            _deviceContext.Object.PSSetSamplers(0, 1, new ID3D11SamplerState[] { _samplerState.Object });

            _deviceContext.Object.OMSetRenderTargets(1, new ID3D11RenderTargetView[] { _renderTargetView.Object }, _depthBufferView.Object);
            _deviceContext.Object.OMSetDepthStencilState(_depthStencilState.Object, 0);
            _deviceContext.Object.OMSetBlendState(_blendState.Object, null, 0xffffffff);

            _deviceContext.Object.DrawIndexed((uint)Data.IndexData.Length, 0, 0);

            _swapChain.Object.Present(1, 0).ThrowOnError();
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct VS_CONSTANT_BUFFER
        {
            public D2D_MATRIX_4X4_F Transform;
            public D2D_MATRIX_4X4_F Projection;
            public XMFLOAT3 LightVector;
            public float Padding; // to make sure it's 16-bytes aligned
        };
    }
}
