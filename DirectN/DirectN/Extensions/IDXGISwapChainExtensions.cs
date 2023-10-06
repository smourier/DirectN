using System;

namespace DirectN
{
    public static class IDXGISwapChainExtensions
    {
        public static DXGI_SWAP_CHAIN_DESC1 GetDesc1(this IComObject<IDXGISwapChain1> swapChain) => GetDesc1(swapChain?.Object);
        public static DXGI_SWAP_CHAIN_DESC1 GetDesc1(this IDXGISwapChain1 swapChain)
        {
            if (swapChain == null)
                throw new ArgumentNullException(nameof(swapChain));

            swapChain.GetDesc1(out var value);
            return value;
        }

        public static DXGI_SWAP_CHAIN_DESC GetDesc(this IComObject<IDXGISwapChain> swapChain) => GetDesc(swapChain?.Object);
        public static DXGI_SWAP_CHAIN_DESC GetDesc(this IDXGISwapChain swapChain)
        {
            if (swapChain == null)
                throw new ArgumentNullException(nameof(swapChain));

            swapChain.GetDesc(out var value);
            return value;
        }

        public static IComObject<T> GetBuffer<T>(this IComObject<IDXGISwapChain> swapChain, uint index) => GetBuffer<T>(swapChain?.Object, index);
        public static IComObject<T> GetBuffer<T>(this IDXGISwapChain swapChain, uint index)
        {
            if (swapChain == null)
                throw new ArgumentNullException(nameof(swapChain));

            swapChain.GetBuffer(index, typeof(T).GUID, out var dc).ThrowOnError();
            return new ComObject<T>((T)dc);
        }

        public static void ResizeBuffers(this IComObject<IDXGISwapChain> swapChain, uint bufferCount, uint width, uint height, DXGI_FORMAT newFormat, uint swapChainFlags) => ResizeBuffers(swapChain?.Object, bufferCount, width, height, newFormat, swapChainFlags);
        public static void ResizeBuffers(this IDXGISwapChain swapChain, uint bufferCount, uint width, uint height, DXGI_FORMAT newFormat, uint swapChainFlags)
        {
            if (swapChain == null)
                throw new ArgumentNullException(nameof(swapChain));

            swapChain.ResizeBuffers(bufferCount, width, height, newFormat, swapChainFlags).ThrowOnError();
        }

        public static void ResizeTarget(this IComObject<IDXGISwapChain> swapChain, DXGI_MODE_DESC newTargetParameters) => ResizeTarget(swapChain?.Object, newTargetParameters);
        public static void ResizeTarget(this IDXGISwapChain swapChain, DXGI_MODE_DESC newTargetParameters)
        {
            if (swapChain == null)
                throw new ArgumentNullException(nameof(swapChain));

            swapChain.ResizeTarget(ref newTargetParameters).ThrowOnError();
        }

        public static void SetBackgroundColor(this IComObject<IDXGISwapChain1> swapChain, _D3DCOLORVALUE value) => SetBackgroundColor(swapChain?.Object, value);
        public static void SetBackgroundColor(this IDXGISwapChain1 swapChain, _D3DCOLORVALUE value)
        {
            if (swapChain == null)
                throw new ArgumentNullException(nameof(swapChain));

            swapChain.SetBackgroundColor(ref value).ThrowOnError();
        }

        public static void Present(this IComObject<IDXGISwapChain> swapChain, uint syncInterval, uint flags) => Present(swapChain?.Object, syncInterval, flags);
        public static void Present(this IDXGISwapChain swapChain, uint syncInterval, uint flags)
        {
            if (swapChain == null)
                throw new ArgumentNullException(nameof(swapChain));

            swapChain.Present(syncInterval, flags).ThrowOnError();
        }
    }
}
