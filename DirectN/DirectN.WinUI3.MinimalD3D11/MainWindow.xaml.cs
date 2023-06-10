using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using Windows.Graphics;
using WinRT;

namespace DirectN.WinUI3.MinimalD3D11
{
    public sealed partial class MainWindow : Window
    {
        private IComObject<ID3D11DeviceContext> _deviceContext;
        private IComObject<IDXGISwapChain1> _swapChain;
        private IComObject<ID3D11RenderTargetView> _framebufferRTV;
        private IComObject<ID3D11DepthStencilView> _framebufferDSV;
        private IComObject<ID3D11DepthStencilView> _shadowmapDSV;
        private IComObject<ID3D11ShaderResourceView> _shadowmapSRV;
        private IComObject<ID3D11Buffer> _constantBuffer;
        private IComObject<ID3D11Buffer> _vertexBuffer;
        private IComObject<ID3D11ShaderResourceView> _vertexBufferSRV;
        private IComObject<ID3D11DepthStencilState> _depthStencilState;
        private IComObject<ID3D11RasterizerState> _cullBackRS;
        private IComObject<ID3D11RasterizerState> _cullFrontRS;
        private IComObject<ID3D11VertexShader> _framebufferVS;
        private IComObject<ID3D11PixelShader> _framebufferPS;
        private IComObject<ID3D11VertexShader> _shadowmapVS;
        private Constants _constants;
        private D3D11_VIEWPORT _shadowmapVP;
        private D3D11_VIEWPORT _framebufferVP;
        private float[] _framebufferClear;
        private bool _disposed;
        private bool _rendering;

        public MainWindow()
        {
            InitializeComponent();
            Title = "minimal d3d11 pt3 by d7samurai - On WinUI3 and .NET 6.0";

            var size = 1000;
            AppWindow.Resize(new SizeInt32(size, size));

            // we dispose on another thread or a lock will happen when closing under Visual Studio debugger for some reason... (doesn't happen under WinDbg)
            Closed += (s, e) => Task.Run(Dispose);
            panel.SizeChanged += OnSizeChanged;

            if (Content is FrameworkElement fe)
            {
                // this whole convoluted thing is just to detect dpi has changed...
                fe.Loaded += (s, e) =>
                {
                    var scale = fe.XamlRoot.RasterizationScale;
                    fe.XamlRoot.Changed += (s2, e2) =>
                    {
                        if (fe.XamlRoot.RasterizationScale != scale)
                        {
                            Dispose();
                            Init();
                        }
                    };
                };
            }
        }

        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            Dispose();
            Init();
        }

        private void Init()
        {
            // this code is ported from https://gist.github.com/d7samurai/abab8a580d0298cb2f34a44eec41d39d
            // with slight changes to use CreateSwapChainForComposition to accomodate with WinUI3's SwapChainPanel
            var flags = D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_BGRA_SUPPORT;

#if DEBUG
            flags |= D3D11_CREATE_DEVICE_FLAG.D3D11_CREATE_DEVICE_DEBUG;
#endif

            using var d3D11Device = D3D11Functions.D3D11CreateDevice(null, D3D_DRIVER_TYPE.D3D_DRIVER_TYPE_HARDWARE, flags, out _deviceContext);
            using var dxgiDevice = ComObject.From(d3D11Device.As<IDXGIDevice1>(true));
            using var dxgiAdapter = dxgiDevice.GetAdapter();
            using var dxgiFactory = dxgiAdapter.GetFactory2();

            var swapChainDesc = new DXGI_SWAP_CHAIN_DESC1();
            swapChainDesc.Width = (uint)panel.ActualWidth;
            swapChainDesc.Height = (uint)panel.ActualHeight;
            swapChainDesc.Format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM;
            swapChainDesc.SampleDesc.Count = 1;
            swapChainDesc.BufferUsage = DirectN.Constants.DXGI_USAGE_RENDER_TARGET_OUTPUT;
            swapChainDesc.BufferCount = 2;
            swapChainDesc.Scaling = DXGI_SCALING.DXGI_SCALING_STRETCH;
            swapChainDesc.SwapEffect = DXGI_SWAP_EFFECT.DXGI_SWAP_EFFECT_FLIP_SEQUENTIAL;
            swapChainDesc.AlphaMode = DXGI_ALPHA_MODE.DXGI_ALPHA_MODE_UNSPECIFIED;

            _swapChain = dxgiFactory.CreateSwapChainForComposition(dxgiDevice, swapChainDesc);
            using var framebufferTexture = _swapChain.GetBuffer<ID3D11Texture2D>(0);

            var panelScaleTransform = new DXGI_MATRIX_3X2_F();
            panelScaleTransform._11 = (float)(1 / Content.XamlRoot.RasterizationScale);
            panelScaleTransform._22 = (float)(1 / Content.XamlRoot.RasterizationScale);
            _swapChain.As<IDXGISwapChain2>()?.SetMatrixTransform(panelScaleTransform);

            var framebufferDesc = new D3D11_RENDER_TARGET_VIEW_DESC();
            framebufferDesc.Format = DXGI_FORMAT.DXGI_FORMAT_B8G8R8A8_UNORM_SRGB;
            framebufferDesc.ViewDimension = D3D11_RTV_DIMENSION.D3D11_RTV_DIMENSION_TEXTURE2D;

            _framebufferRTV = d3D11Device.CreateRenderTargetView(framebufferTexture, framebufferDesc);

            var framebufferDepthDesc = framebufferTexture.GetDesc();
            framebufferDepthDesc.Format = DXGI_FORMAT.DXGI_FORMAT_D24_UNORM_S8_UINT;
            framebufferDepthDesc.BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_DEPTH_STENCIL;

            using var framebufferDepthTexture = d3D11Device.CreateTexture2D(framebufferDepthDesc);
            _framebufferDSV = d3D11Device.CreateDepthStencilView(framebufferDepthTexture);

            var shadowmapDepthDesc = new D3D11_TEXTURE2D_DESC();
            shadowmapDepthDesc.Width = 2048;
            shadowmapDepthDesc.Height = 2048;
            shadowmapDepthDesc.MipLevels = 1;
            shadowmapDepthDesc.ArraySize = 1;
            shadowmapDepthDesc.Format = DXGI_FORMAT.DXGI_FORMAT_R32_TYPELESS;
            shadowmapDepthDesc.SampleDesc.Count = 1;
            shadowmapDepthDesc.Usage = D3D11_USAGE.D3D11_USAGE_DEFAULT;
            shadowmapDepthDesc.BindFlags = (uint)(D3D11_BIND_FLAG.D3D11_BIND_DEPTH_STENCIL | D3D11_BIND_FLAG.D3D11_BIND_SHADER_RESOURCE);

            using var shadowmapDepthTexture = d3D11Device.CreateTexture2D(shadowmapDepthDesc);
            var shadowmapDSVdesc = new D3D11_DEPTH_STENCIL_VIEW_DESC();
            shadowmapDSVdesc.Format = DXGI_FORMAT.DXGI_FORMAT_D32_FLOAT;
            shadowmapDSVdesc.ViewDimension = D3D11_DSV_DIMENSION.D3D11_DSV_DIMENSION_TEXTURE2D;

            _shadowmapDSV = d3D11Device.CreateDepthStencilView(shadowmapDepthTexture, shadowmapDSVdesc);

            var shadowmapSRVdesc = new D3D11_SHADER_RESOURCE_VIEW_DESC();
            shadowmapSRVdesc.Format = DXGI_FORMAT.DXGI_FORMAT_R32_FLOAT;
            shadowmapSRVdesc.ViewDimension = D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_TEXTURE2D;
            var t2D = new D3D11_TEX2D_SRV();
            t2D.MipLevels = 1;
            shadowmapSRVdesc.__union_2.Texture2D = t2D;

            _shadowmapSRV = d3D11Device.CreateShaderResourceView(shadowmapDepthTexture, shadowmapSRVdesc);

            var constantBufferDesc = new D3D11_BUFFER_DESC();
            constantBufferDesc.ByteWidth = (uint)Marshal.SizeOf<Constants>();
            constantBufferDesc.Usage = D3D11_USAGE.D3D11_USAGE_DYNAMIC;
            constantBufferDesc.BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_CONSTANT_BUFFER;
            constantBufferDesc.CPUAccessFlags = (uint)D3D11_CPU_ACCESS_FLAG.D3D11_CPU_ACCESS_WRITE;

            _constantBuffer = d3D11Device.CreateBuffer(constantBufferDesc);

            var vertexData = new float[] { -1, 1, -1, 0, 0, 1, 1, -1, 9.5f, 0, -0.58f, 0.58f, -1, 2, 2, 0.58f, 0.58f, -1, 7.5f, 2, -0.58f, 0.58f, -1, 0, 0, 0.58f, 0.58f, -1, 0, 0, -0.58f, 0.58f, -0.58f, 0, 0, 0.58f, 0.58f, -0.58f, 0, 0 };

            var vertexBufferDesc = new D3D11_BUFFER_DESC();
            vertexBufferDesc.ByteWidth = (uint)vertexData.SizeOf();
            vertexBufferDesc.Usage = D3D11_USAGE.D3D11_USAGE_IMMUTABLE;
            vertexBufferDesc.BindFlags = (uint)D3D11_BIND_FLAG.D3D11_BIND_SHADER_RESOURCE;
            vertexBufferDesc.MiscFlags = (uint)D3D11_RESOURCE_MISC_FLAG.D3D11_RESOURCE_MISC_BUFFER_STRUCTURED;
            vertexBufferDesc.StructureByteStride = 5 * sizeof(float);

            var gc = GCHandle.Alloc(vertexData, GCHandleType.Pinned);
            var vData = new D3D11_SUBRESOURCE_DATA();
            vData.pSysMem = gc.AddrOfPinnedObject();
            _vertexBuffer = d3D11Device.CreateBuffer(vertexBufferDesc, vData);
            gc.Free();

            var vertexBufferSRVdesc = new D3D11_SHADER_RESOURCE_VIEW_DESC();
            vertexBufferSRVdesc.Format = DXGI_FORMAT.DXGI_FORMAT_UNKNOWN;
            vertexBufferSRVdesc.ViewDimension = D3D_SRV_DIMENSION.D3D11_SRV_DIMENSION_BUFFER;
            var bf = new D3D11_BUFFER_SRV();
            bf.__union_1.NumElements = vertexBufferDesc.ByteWidth / vertexBufferDesc.StructureByteStride;
            vertexBufferSRVdesc.__union_2.Buffer = bf;

            _vertexBufferSRV = d3D11Device.CreateShaderResourceView(_vertexBuffer, vertexBufferSRVdesc);

            var depthStencilDesc = new D3D11_DEPTH_STENCIL_DESC();
            depthStencilDesc.DepthEnable = true;
            depthStencilDesc.DepthWriteMask = D3D11_DEPTH_WRITE_MASK.D3D11_DEPTH_WRITE_MASK_ALL;
            depthStencilDesc.DepthFunc = D3D11_COMPARISON_FUNC.D3D11_COMPARISON_LESS;

            _depthStencilState = d3D11Device.CreateDepthStencilState(depthStencilDesc);

            var rasterizerDesc = new D3D11_RASTERIZER_DESC();
            rasterizerDesc.FillMode = D3D11_FILL_MODE.D3D11_FILL_SOLID;
            rasterizerDesc.CullMode = D3D11_CULL_MODE.D3D11_CULL_BACK;

            _cullBackRS = d3D11Device.CreateRasterizerState(rasterizerDesc);

            rasterizerDesc.CullMode = D3D11_CULL_MODE.D3D11_CULL_FRONT;
            _cullFrontRS = d3D11Device.CreateRasterizerState(rasterizerDesc);

            var hlslFilePath = Path.Combine(Path.GetDirectoryName(Environment.ProcessPath), "shaders.hlsl");
            using var framebufferVSBlob = D3D11Functions.D3DCompileFromFile(hlslFilePath, "framebuffer_vs", "vs_5_0");
            _framebufferVS = d3D11Device.CreateVertexShader(framebufferVSBlob);

            using var framebufferPSBlob = D3D11Functions.D3DCompileFromFile(hlslFilePath, "framebuffer_ps", "ps_5_0");
            _framebufferPS = d3D11Device.CreatePixelShader(framebufferPSBlob);

            using var shadowmapVSBlob = D3D11Functions.D3DCompileFromFile(hlslFilePath, "shadowmap_vs", "vs_5_0");
            _shadowmapVS = d3D11Device.CreateVertexShader(shadowmapVSBlob);

            _framebufferClear = new float[] { 0.025f, 0.025f, 0.025f, 1 };

            _framebufferVP = new D3D11_VIEWPORT();
            _framebufferVP.Width = framebufferDepthDesc.Width;
            _framebufferVP.Height = framebufferDepthDesc.Height;
            _framebufferVP.MaxDepth = 1;

            _shadowmapVP = new D3D11_VIEWPORT();
            _shadowmapVP.Width = shadowmapDepthDesc.Width;
            _shadowmapVP.Height = shadowmapDepthDesc.Height;
            _shadowmapVP.MaxDepth = 1;

            _constants = new Constants();
            _constants.CameraProjection = new float[] { 2.0f / (_framebufferVP.Width / _framebufferVP.Height), 0, 0, 0, 0, 2, 0, 0, 0, 0, 1.125f, 1, 0, 0, -1.125f, 0 };
            _constants.LightProjection = new float[] { 0.5f, 0, 0, 0, 0, 0.5f, 0, 0, 0, 0, 0.125f, 0, 0, 0, -0.125f, 1 };

            _constants.LightRotation = new XMFLOAT4(0.8f, 0.6f, 0.0f, 0);
            _constants.ModelRotation = new XMFLOAT4(0.0f, 0.0f, 0.0f, 0);
            _constants.ModelTranslation = new XMFLOAT4(0.0f, 0.0f, 4.0f, 0);
            _constants.ShadowmapSize = new XMFLOAT4(_shadowmapVP.Width, _shadowmapVP.Height, 0, 0);

            var nativePanel = panel.As<ISwapChainPanelNative>();
            nativePanel.SetSwapChain(_swapChain.Object).ThrowOnError();

            _disposed = false;
            CompositionTarget.Rendering += Render;
        }

        private void Render(object sender, object e)
        {
            if (_disposed)
                return;

            _rendering = true;
            try
            {
                _constants.ModelRotation.x += 0.001f;
                _constants.ModelRotation.y += 0.005f;
                _constants.ModelRotation.z += 0.003f;

                _deviceContext.WithMapCopyTo(_constantBuffer, 0, D3D11_MAP.D3D11_MAP_WRITE_DISCARD, _constants);

                _deviceContext.ClearDepthStencilView(_shadowmapDSV, D3D11_CLEAR_FLAG.D3D11_CLEAR_DEPTH, 1.0f, 0);

                _deviceContext.OMSetRenderTargets(null, _shadowmapDSV);
                _deviceContext.OMSetDepthStencilState(_depthStencilState);

                _deviceContext.IASetPrimitiveTopology(D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP);

                _deviceContext.VSSetConstantBuffers(0, new[] { _constantBuffer });
                _deviceContext.VSSetShaderResources(0, new[] { _vertexBufferSRV });
                _deviceContext.VSSetShader(_shadowmapVS);

                _deviceContext.RSSetViewports(new[] { _shadowmapVP });
                _deviceContext.RSSetState(_cullFrontRS);

                _deviceContext.PSSetShader(null);

                _deviceContext.DrawInstanced(8, 24, 0, 0);

                _deviceContext.ClearRenderTargetView(_framebufferRTV, _framebufferClear);
                _deviceContext.ClearDepthStencilView(_framebufferDSV, D3D11_CLEAR_FLAG.D3D11_CLEAR_DEPTH, 1.0f, 0);

                _deviceContext.OMSetRenderTargets(new[] { _framebufferRTV }, _framebufferDSV);

                _deviceContext.VSSetShader(_framebufferVS);

                _deviceContext.RSSetViewports(new[] { _framebufferVP });
                _deviceContext.RSSetState(_cullBackRS);

                _deviceContext.PSSetShaderResources(1, new[] { _shadowmapSRV });
                _deviceContext.PSSetShader(_framebufferPS);

                _deviceContext.DrawInstanced(8, 24, 0, 0);

                _deviceContext.PSSetShaderResources(1, new IComObject<ID3D11ShaderResourceView>[] { null });

                _swapChain.Present(1, 0);
            }
            finally
            {
                _rendering = false;
            }
        }

        private void Dispose()
        {
            _disposed = true;

            // we want to dispose all objects as a whole
            while (_rendering) { }
            _deviceContext?.Dispose();
            _swapChain?.Dispose();
            _framebufferRTV?.Dispose();
            _framebufferDSV?.Dispose();
            _shadowmapDSV?.Dispose();
            _shadowmapSRV?.Dispose();
            _constantBuffer?.Dispose();
            _vertexBuffer?.Dispose();
            _vertexBufferSRV?.Dispose();
            _depthStencilState?.Dispose();
            _cullBackRS?.Dispose();
            _cullFrontRS?.Dispose();
            _framebufferVS?.Dispose();
            _framebufferPS?.Dispose();
            _shadowmapVS?.Dispose();
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct Constants
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public float[] CameraProjection;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public float[] LightProjection;
            public XMFLOAT4 LightRotation;
            public XMFLOAT4 ModelRotation;
            public XMFLOAT4 ModelTranslation;
            public XMFLOAT4 ShadowmapSize;
        };

        // note: this is *not* the same IID as DirectN.ISwapChainPanelNative which corresponds to the Windows.UI.Xaml.Media namespace
        // this one corresponds to the Microsoft.UI.Xaml.Media namespace
        [ComImport, Guid("63aad0b8-7c24-40ff-85a8-640d944cc325"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        public partial interface ISwapChainPanelNative
        {
            [PreserveSig]
            HRESULT SetSwapChain(IDXGISwapChain swapChain);
        }
    }
}
