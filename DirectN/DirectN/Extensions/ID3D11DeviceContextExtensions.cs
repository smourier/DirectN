using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace DirectN
{
    public static class ID3D11DeviceContextExtensions
    {
        public delegate void MapAction<T>(ref D3D11_MAPPED_SUBRESOURCE mapped, ref T structure);

        public static void WithMap<T>(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, MapAction<T> action, D3D11_MAP_FLAG mapFlag = 0)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            var map = Map(context, resource, subResource, mapType, mapFlag);
            try
            {
                var structure = Marshal.PtrToStructure<T>(map.pData);
                action(ref map, ref structure);
                Marshal.StructureToPtr(structure, map.pData, false);
            }
            finally
            {
                Unmap(context, resource, subResource);
            }
        }

        public static D3D11_MAPPED_SUBRESOURCE Map(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource, D3D11_MAP mapType, D3D11_MAP_FLAG mapFlag = 0) => Map(context?.Object, resource?.Object, subResource, mapType, mapFlag);
        public static D3D11_MAPPED_SUBRESOURCE Map(this ID3D11DeviceContext context, ID3D11Resource resource, int subResource, D3D11_MAP mapType, D3D11_MAP_FLAG mapFlag = 0)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            using (var ptr = new ComMemory(Marshal.SizeOf<D3D11_MAPPED_SUBRESOURCE>()))
            {
                context.Map(resource, (uint)subResource, mapType, (uint)mapFlag, ptr.Pointer).ThrowOnError();
                return ptr.ToStructure<D3D11_MAPPED_SUBRESOURCE>();
            }
        }

        public static void Unmap(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Resource> resource, int subResource) => Unmap(context?.Object, resource?.Object, subResource);
        public static void Unmap(this ID3D11DeviceContext context, ID3D11Resource resource, int subResource)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            context.Unmap(resource, (uint)subResource);
        }

        public static void RSSetState(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11RasterizerState> state) => RSSetState(context?.Object, state?.Object);
        public static void RSSetState(this ID3D11DeviceContext context, ID3D11RasterizerState state)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (state == null)
                throw new ArgumentNullException(nameof(state));

            context.RSSetState(state);
        }

        public static void RSSetViewport(this IComObject<ID3D11DeviceContext> context, D3D11_VIEWPORT viewPort)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (context.Object == null)
                throw new ArgumentException(null, nameof(context));

            context.Object.RSSetViewports(1, new[] { viewPort });
        }

        public static void RSSetViewports(this IComObject<ID3D11DeviceContext> context, D3D11_VIEWPORT[] viewPorts) => RSSetViewports(context?.Object, viewPorts);
        public static void RSSetViewports(this ID3D11DeviceContext context, D3D11_VIEWPORT[] viewPorts)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (viewPorts == null)
                throw new ArgumentNullException(nameof(viewPorts));

            if (viewPorts.Length == 0)
                throw new ArgumentException(null, nameof(viewPorts));

            context.RSSetViewports(viewPorts.Length, viewPorts);
        }

        public static void RSSetScissorRect(this IComObject<ID3D11DeviceContext> context, tagRECT rect)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (context.Object == null)
                throw new ArgumentException(null, nameof(context));

            context.Object.RSSetScissorRects(1, new[] { rect });
        }

        public static void RSSetScissorRects(this IComObject<ID3D11DeviceContext> context, tagRECT[] rects) => RSSetScissorRects(context?.Object, rects);
        public static void RSSetScissorRects(this ID3D11DeviceContext context, tagRECT[] rects)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (rects == null)
                throw new ArgumentNullException(nameof(rects));

            if (rects.Length == 0)
                throw new ArgumentException(null, nameof(rects));

            context.RSSetScissorRects(rects.Length, rects);
        }

        public static void ClearRenderTargetView(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11RenderTargetView> renderTargetView, _D3DCOLORVALUE color) => ClearRenderTargetView(context?.Object, renderTargetView?.Object, color.ToArray());
        public static void ClearRenderTargetView(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11RenderTargetView> renderTargetView, float[] colorRGBA) => ClearRenderTargetView(context?.Object, renderTargetView?.Object, colorRGBA);
        public static void ClearRenderTargetView(this ID3D11DeviceContext context, ID3D11RenderTargetView renderTargetView, float[] colorRGBA)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (renderTargetView == null)
                throw new ArgumentNullException(nameof(renderTargetView));

            if (colorRGBA == null)
                throw new ArgumentNullException(nameof(colorRGBA));

            if (colorRGBA.Length != 4)
                throw new ArgumentException(null, nameof(colorRGBA));

            context.ClearRenderTargetView(renderTargetView, colorRGBA);
        }

        public static void ClearDepthStencilView(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11DepthStencilView> depthStencilView, D3D11_CLEAR_FLAG flags, float depth, byte stencil) => ClearDepthStencilView(context?.Object, depthStencilView?.Object, flags, depth, stencil);
        public static void ClearDepthStencilView(this ID3D11DeviceContext context, ID3D11DepthStencilView depthStencilView, D3D11_CLEAR_FLAG flags, float depth, byte stencil)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (depthStencilView == null)
                throw new ArgumentNullException(nameof(depthStencilView));

            context.ClearDepthStencilView(depthStencilView, (uint)flags, depth, stencil);
        }

        public static void IASetPrimitiveTopology(this IComObject<ID3D11DeviceContext> context, D3D_PRIMITIVE_TOPOLOGY topology) => IASetPrimitiveTopology(context?.Object, topology);
        public static void IASetPrimitiveTopology(this ID3D11DeviceContext context, D3D_PRIMITIVE_TOPOLOGY topology)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.IASetPrimitiveTopology(topology);
        }

        public static void IASetInputLayout(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11InputLayout> inputLayout) => IASetInputLayout(context?.Object, inputLayout?.Object);
        public static void IASetInputLayout(this ID3D11DeviceContext context, ID3D11InputLayout inputLayout)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (inputLayout == null)
                throw new ArgumentNullException(nameof(inputLayout));

            context.IASetInputLayout(inputLayout);
        }

        public static void IASetVertexBuffer(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11Buffer> vertexBuffer, int stride, int offset = 0)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (context.Object == null)
                throw new ArgumentException(null, nameof(context));

            if (vertexBuffer == null)
                throw new ArgumentNullException(nameof(vertexBuffer));

            if (vertexBuffer.Object == null)
                throw new ArgumentException(null, nameof(vertexBuffer));

            context.Object.IASetVertexBuffers((uint)startSlot, 1, new[] { vertexBuffer.Object }, new[] { (uint)stride }, new[] { (uint)offset });
        }

        public static void IASetVertexBuffers(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11Buffer>[] vertexBuffers, int[] strides, int[] offsets = null)
        {
            if (vertexBuffers == null)
                throw new ArgumentNullException(nameof(vertexBuffers));

            if (offsets == null)
            {
                offsets = new int[vertexBuffers.Length];
            }

            IASetVertexBuffers(context?.Object, startSlot, vertexBuffers.ToArrayNullify(), strides, offsets);
        }

        public static void IASetVertexBuffers(this ID3D11DeviceContext context, int startSlot, ID3D11Buffer[] vertexBuffers, int[] strides, int[] offsets)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (vertexBuffers == null)
                throw new ArgumentNullException(nameof(vertexBuffers));

            if (strides == null)
                throw new ArgumentNullException(nameof(strides));

            if (offsets == null)
                throw new ArgumentNullException(nameof(offsets));

            if (vertexBuffers.Length == 0)
                throw new ArgumentException(null, nameof(vertexBuffers));

            if (vertexBuffers.Length != strides.Length)
                throw new ArgumentException(null, nameof(strides));

            if (vertexBuffers.Length != offsets.Length)
                throw new ArgumentException(null, nameof(offsets));

            context.IASetVertexBuffers((uint)startSlot, vertexBuffers.Length, vertexBuffers, strides.Select(s => (uint)s).ToArray(), offsets.Select(s => (uint)s).ToArray());
        }

        public static void IASetIndexBuffer(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11Buffer> indexBuffer, DXGI_FORMAT format = DXGI_FORMAT.DXGI_FORMAT_R32_UINT, int offset = 0) => IASetIndexBuffer(context?.Object, indexBuffer?.Object, format, offset);
        public static void IASetIndexBuffer(this ID3D11DeviceContext context, ID3D11Buffer indexBuffer, DXGI_FORMAT format = DXGI_FORMAT.DXGI_FORMAT_R32_UINT, int offset = 0)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (indexBuffer == null)
                throw new ArgumentNullException(nameof(indexBuffer));

            context.IASetIndexBuffer(indexBuffer, format, (uint)offset);
        }

        public static void VSSetShader(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11VertexShader> vertexShader, IComObject<ID3D11ClassInstance>[] classInstances = null) => VSSetShader(context?.Object, vertexShader?.Object, classInstances.ToArrayNullify());
        public static void VSSetShader(this ID3D11DeviceContext context, ID3D11VertexShader vertexShader, ID3D11ClassInstance[] classInstances = null)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (vertexShader == null)
                throw new ArgumentNullException(nameof(vertexShader));

            context.VSSetShader(vertexShader, classInstances, (classInstances?.Length).GetValueOrDefault());
        }

        public static void PSSetShader(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11PixelShader> pixelShader, IComObject<ID3D11ClassInstance>[] classInstances = null) => PSSetShader(context?.Object, pixelShader?.Object, classInstances.ToArrayNullify());
        public static void PSSetShader(this ID3D11DeviceContext context, ID3D11PixelShader pixelShader, ID3D11ClassInstance[] classInstances = null)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (pixelShader == null)
                throw new ArgumentNullException(nameof(pixelShader));

            context.PSSetShader(pixelShader, classInstances, (classInstances?.Length).GetValueOrDefault());
        }

        public static void VSSetConstantBuffer(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11Buffer> constantBuffer)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (context.Object == null)
                throw new ArgumentException(null, nameof(context));

            if (constantBuffer == null)
                throw new ArgumentNullException(nameof(constantBuffer));

            if (constantBuffer.Object == null)
                throw new ArgumentException(null, nameof(constantBuffer));

            context.Object.VSSetConstantBuffers((uint)startSlot, 1, new[] { constantBuffer.Object });
        }

        public static void VSSetConstantBuffers(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11Buffer>[] constantBuffers) => VSSetConstantBuffers(context?.Object, startSlot, constantBuffers.ToArrayNullify());
        public static void VSSetConstantBuffers(this ID3D11DeviceContext context, int startSlot, ID3D11Buffer[] constantBuffers)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (constantBuffers == null)
                throw new ArgumentNullException(nameof(constantBuffers));

            if (constantBuffers.Length == 0)
                throw new ArgumentException(null, nameof(constantBuffers));

            context.VSSetConstantBuffers((uint)startSlot, constantBuffers.Length, constantBuffers);
        }

        public static void PSSetSampler(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11SamplerState> samplerState)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (context.Object == null)
                throw new ArgumentException(null, nameof(context));

            if (samplerState == null)
                throw new ArgumentNullException(nameof(samplerState));

            if (samplerState.Object == null)
                throw new ArgumentException(null, nameof(samplerState));

            context.Object.PSSetSamplers((uint)startSlot, 1, new[] { samplerState.Object });
        }

        public static void PSSetSamplers(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11SamplerState>[] samplerStates) => PSSetSamplers(context?.Object, startSlot, samplerStates.ToArrayNullify());
        public static void PSSetSamplers(this ID3D11DeviceContext context, int startSlot, ID3D11SamplerState[] samplerStates)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (samplerStates == null)
                throw new ArgumentNullException(nameof(samplerStates));

            if (samplerStates.Length == 0)
                throw new ArgumentException(null, nameof(samplerStates));

            context.PSSetSamplers((uint)startSlot, samplerStates.Length, samplerStates);
        }

        public static void PSSetShaderResource(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11ShaderResourceView> shaderResourceView)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (context.Object == null)
                throw new ArgumentException(null, nameof(context));

            if (shaderResourceView == null)
                throw new ArgumentNullException(nameof(shaderResourceView));

            if (shaderResourceView.Object == null)
                throw new ArgumentException(null, nameof(shaderResourceView));

            context.Object.PSSetShaderResources((uint)startSlot, 1, new[] { shaderResourceView.Object });
        }

        public static void PSSetShaderResources(this IComObject<ID3D11DeviceContext> context, int startSlot, IComObject<ID3D11ShaderResourceView>[] shaderResourceViews) => PSSetShaderResources(context?.Object, startSlot, shaderResourceViews.ToArrayNullify());
        public static void PSSetShaderResources(this ID3D11DeviceContext context, int startSlot, ID3D11ShaderResourceView[] shaderResourceViews)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (shaderResourceViews == null)
                throw new ArgumentNullException(nameof(shaderResourceViews));

            if (shaderResourceViews.Length == 0)
                throw new ArgumentException(null, nameof(shaderResourceViews));

            context.PSSetShaderResources((uint)startSlot, shaderResourceViews.Length, shaderResourceViews);
        }

        public static void OMSetRenderTarget(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11RenderTargetView> renderTargetView, IComObject<ID3D11DepthStencilView> depthStencilView = null)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (context.Object == null)
                throw new ArgumentException(null, nameof(context));

            if (renderTargetView == null)
                throw new ArgumentNullException(nameof(renderTargetView));

            if (renderTargetView.Object == null)
                throw new ArgumentException(null, nameof(renderTargetView));

            context.Object.OMSetRenderTargets(1, new[] { renderTargetView.Object }, depthStencilView?.Object);
        }

        public static void OMSetRenderTargets(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11RenderTargetView>[] renderTargetViews, IComObject<ID3D11DepthStencilView> depthStencilView = null) => OMSetRenderTargets(context?.Object, renderTargetViews.ToArrayNullify(), depthStencilView?.Object);
        public static void OMSetRenderTargets(this ID3D11DeviceContext context, ID3D11RenderTargetView[] renderTargetViews, ID3D11DepthStencilView depthStencilView = null)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (renderTargetViews == null)
                throw new ArgumentNullException(nameof(renderTargetViews));

            context.OMSetRenderTargets((renderTargetViews?.Length).GetValueOrDefault(), renderTargetViews, depthStencilView);
        }

        public static void OMSetDepthStencilState(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11DepthStencilState> depthStencilState, int stencilfRef = 0) => OMSetDepthStencilState(context?.Object, depthStencilState?.Object, stencilfRef);
        public static void OMSetDepthStencilState(this ID3D11DeviceContext context, ID3D11DepthStencilState depthStencilState, int stencilfRef = 0)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (depthStencilState == null)
                throw new ArgumentNullException(nameof(depthStencilState));

            context.OMSetDepthStencilState(depthStencilState, (uint)stencilfRef);
        }

        public static void OMSetBlendState(this IComObject<ID3D11DeviceContext> context, IComObject<ID3D11BlendState> blendState, float[] blendFactor = null, uint sampleMask = 0xffffffff) => OMSetBlendState(context?.Object, blendState?.Object, blendFactor, sampleMask);
        public static void OMSetBlendState(this ID3D11DeviceContext context, ID3D11BlendState blendState, float[] blendFactor = null, uint sampleMask = 0xffffffff)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (blendState == null)
                throw new ArgumentNullException(nameof(blendState));

            context.OMSetBlendState(blendState, blendFactor, sampleMask);
        }

        public static void DrawIndexed(this IComObject<ID3D11DeviceContext> context, int indexCount, int startIndexLocation, int baseVertexLocation) => DrawIndexed(context?.Object, indexCount, startIndexLocation, baseVertexLocation);
        public static void DrawIndexed(this ID3D11DeviceContext context, int indexCount, int startIndexLocation, int baseVertexLocation)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.DrawIndexed((uint)indexCount, (uint)startIndexLocation, baseVertexLocation);
        }
    }
}
