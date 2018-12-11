using System;
using System.Collections.Generic;

namespace DirectN
{
    public static class IDXGIFactoryExtensions
    {
        public static IEnumerable<ComObject<IDXGIAdapter>> EnumAdapters(this ComObject<IDXGIFactory1> factory) => EnumAdapters<IDXGIAdapter>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumAdapters<T>(this ComObject<IDXGIFactory> factory) where T : IDXGIAdapter => EnumAdapters<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumAdapters<T>(this IDXGIFactory factory) where T : IDXGIAdapter
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            uint i = 0;
            do
            {
                if (factory.EnumAdapters(i++, out var adapter).IsError)
                    yield break;

                yield return new ComObject<T>((T)adapter);
            }
            while (true);
        }

        public static IEnumerable<ComObject<IDXGIAdapter1>> EnumAdapters1(this ComObject<IDXGIFactory1> factory) => EnumAdapters1<IDXGIAdapter1>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumAdapters1<T>(this ComObject<IDXGIFactory1> factory) where T : IDXGIAdapter1 => EnumAdapters1<T>(factory?.Object);
        public static IEnumerable<ComObject<T>> EnumAdapters1<T>(this IDXGIFactory1 factory) where T : IDXGIAdapter1
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            uint i = 0;
            do
            {
                if (factory.EnumAdapters1(i++, out var adapter).IsError)
                    yield break;

                yield return new ComObject<T>((T)adapter);
            }
            while (true);
        }

        public static ComObject<T> CreateSwapChainForHwnd<T>(this ComObject<IDXGIFactory2> factory,
            ComObject<IDXGIDevice1> device,
            IntPtr hwnd,
            DXGI_SWAP_CHAIN_DESC1 desc,
            DXGI_SWAP_CHAIN_FULLSCREEN_DESC? fullScreenDesc = null,
            ComObject<IDXGIOutput1> restrictToOutput = null) where T : IDXGISwapChain1 => CreateSwapChainForHwnd<T>(factory?.Object, device?.Object, hwnd, desc, fullScreenDesc, restrictToOutput?.Object);

        public static ComObject<T> CreateSwapChainForHwnd<T>(this IDXGIFactory2 factory,
            IDXGIDevice1 device,
            IntPtr hwnd,
            DXGI_SWAP_CHAIN_DESC1 desc,
            DXGI_SWAP_CHAIN_FULLSCREEN_DESC? fullScreenDesc = null,
            IDXGIOutput1 restrictToOutput = null) where T : IDXGISwapChain1
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (device == null)
                throw new ArgumentNullException(nameof(device));

            using (var mem = fullScreenDesc.StructureToMemory())
            {
                factory.CreateSwapChainForHwnd(device, hwnd, ref desc, mem.Pointer, restrictToOutput, out var swapChain).ThrowOnError();
                return new ComObject<T>((T)swapChain);
            }
        }
    }
}
