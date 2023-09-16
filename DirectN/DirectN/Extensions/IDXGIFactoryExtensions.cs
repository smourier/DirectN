using System;
using System.Collections.Generic;

namespace DirectN
{
    public static class IDXGIFactoryExtensions
    {
        public static IEnumerable<IComObject<IDXGIAdapter>> EnumAdapters(this IComObject<IDXGIFactory1> factory) => EnumAdapters<IDXGIAdapter>(factory?.Object);
        public static IEnumerable<IComObject<T>> EnumAdapters<T>(this IComObject<IDXGIFactory> factory) where T : IDXGIAdapter => EnumAdapters<T>(factory?.Object);
        public static IEnumerable<IComObject<T>> EnumAdapters<T>(this IDXGIFactory factory) where T : IDXGIAdapter
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

        public static IEnumerable<IComObject<IDXGIAdapter1>> EnumAdapters1(this IComObject<IDXGIFactory1> factory) => EnumAdapters1<IDXGIAdapter1>(factory?.Object);
        public static IEnumerable<IComObject<T>> EnumAdapters1<T>(this IComObject<IDXGIFactory1> factory) where T : IDXGIAdapter1 => EnumAdapters1<T>(factory?.Object);
        public static IEnumerable<IComObject<T>> EnumAdapters1<T>(this IDXGIFactory1 factory) where T : IDXGIAdapter1
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

        public static IComObject<IDXGIAdapter1> GetAdapter1(this IComObject<IDXGIFactory1> factory, int index) => GetAdapter1<IDXGIAdapter1>(factory?.Object, index);
        public static IComObject<T> GetAdapter1<T>(this IComObject<IDXGIFactory1> factory, int index) where T : IDXGIAdapter1 => GetAdapter1<T>(factory?.Object, index);
        public static IComObject<T> GetAdapter1<T>(this IDXGIFactory1 factory, int index) where T : IDXGIAdapter1
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            int i = 0;
            do
            {
                if (factory.EnumAdapters((uint)i, out var adapter).IsError)
                    return null;

                if (i == index)
                    return new ComObject<T>((T)adapter);

                i++;
            }
            while (true);
        }

        public static IComObject<T> CreateSwapChainForHwnd<T>(this IComObject<IDXGIFactory2> factory,
            IDXGIDevice1 device,
            IntPtr hwnd,
            DXGI_SWAP_CHAIN_DESC1 desc,
            DXGI_SWAP_CHAIN_FULLSCREEN_DESC? fullScreenDesc = null,
            IComObject<IDXGIOutput1> restrictToOutput = null) where T : IDXGISwapChain1 => CreateSwapChainForHwnd<T>(factory?.Object, device, hwnd, desc, fullScreenDesc, restrictToOutput?.Object);

        public static IComObject<T> CreateSwapChainForHwnd<T>(this IComObject<IDXGIFactory2> factory,
            ID3D11Device device,
            IntPtr hwnd,
            DXGI_SWAP_CHAIN_DESC1 desc,
            DXGI_SWAP_CHAIN_FULLSCREEN_DESC? fullScreenDesc = null,
            IComObject<IDXGIOutput1> restrictToOutput = null) where T : IDXGISwapChain1 => CreateSwapChainForHwnd<T>(factory?.Object, device, hwnd, desc, fullScreenDesc, restrictToOutput?.Object);

        public static IComObject<T> CreateSwapChainForHwnd<T>(this IComObject<IDXGIFactory2> factory,
            IComObject<IDXGIDevice1> device,
            IntPtr hwnd,
            DXGI_SWAP_CHAIN_DESC1 desc,
            DXGI_SWAP_CHAIN_FULLSCREEN_DESC? fullScreenDesc = null,
            IComObject<IDXGIOutput1> restrictToOutput = null) where T : IDXGISwapChain1 => CreateSwapChainForHwnd<T>(factory?.Object, device?.Object, hwnd, desc, fullScreenDesc, restrictToOutput?.Object);

        public static IComObject<T> CreateSwapChainForHwnd<T>(this IComObject<IDXGIFactory2> factory,
            IComObject<ID3D11Device> device,
            IntPtr hwnd,
            DXGI_SWAP_CHAIN_DESC1 desc,
            DXGI_SWAP_CHAIN_FULLSCREEN_DESC? fullScreenDesc = null,
            IComObject<IDXGIOutput1> restrictToOutput = null) where T : IDXGISwapChain1 => CreateSwapChainForHwnd<T>(factory?.Object, device?.Object, hwnd, desc, fullScreenDesc, restrictToOutput?.Object);

        public static IComObject<T> CreateSwapChainForHwnd<T>(this IComObject<IDXGIFactory2> factory,
            IComObject<ID3D12CommandQueue> device,
            IntPtr hwnd,
            DXGI_SWAP_CHAIN_DESC1 desc,
            DXGI_SWAP_CHAIN_FULLSCREEN_DESC? fullScreenDesc = null,
            IComObject<IDXGIOutput1> restrictToOutput = null) where T : IDXGISwapChain1 => CreateSwapChainForHwnd<T>(factory?.Object, device?.Object, hwnd, desc, fullScreenDesc, restrictToOutput?.Object);

        public static IComObject<T> CreateSwapChainForHwnd<T>(this IDXGIFactory2 factory,
            object device,
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

        public static IComObject<T> CreateSwapChainForComposition<T>(this IComObject<IDXGIFactory2> factory,
            IComObject<IDXGIDevice1> device,
            DXGI_SWAP_CHAIN_DESC1 desc,
            IComObject<IDXGIOutput1> restrictToOutput = null) where T : IDXGISwapChain1 => CreateSwapChainForComposition<T>(factory?.Object, device?.Object, desc, restrictToOutput?.Object);

        public static IComObject<IDXGISwapChain1> CreateSwapChainForComposition(this IComObject<IDXGIFactory2> factory,
            IComObject<IDXGIDevice1> device,
            DXGI_SWAP_CHAIN_DESC1 desc,
            IComObject<IDXGIOutput1> restrictToOutput = null) => CreateSwapChainForComposition<IDXGISwapChain1>(factory?.Object, device?.Object, desc, restrictToOutput?.Object);

        public static IComObject<T> CreateSwapChainForComposition<T>(this IDXGIFactory2 factory,
            IDXGIDevice1 device,
            DXGI_SWAP_CHAIN_DESC1 desc,
            IDXGIOutput1 restrictToOutput = null) where T : IDXGISwapChain1
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (device == null)
                throw new ArgumentNullException(nameof(device));

            factory.CreateSwapChainForComposition(device, ref desc, restrictToOutput, out var swapChain).ThrowOnError();
            return new ComObject<T>((T)swapChain);
        }

        public static IComObject<IDXGIAdapter1> EnumAdapterByGpuPreference(this IComObject<IDXGIFactory6> factory, int index, DXGI_GPU_PREFERENCE preference) => EnumAdapterByGpuPreference<IDXGIAdapter1>(factory?.Object, index, preference);
        public static IComObject<IDXGIAdapter1> EnumAdapterByGpuPreference(this IDXGIFactory6 factory, int index, DXGI_GPU_PREFERENCE preference) => EnumAdapterByGpuPreference<IDXGIAdapter1>(factory, index, preference);
        public static IComObject<T> EnumAdapterByGpuPreference<T>(this IComObject<IDXGIFactory6> factory, int index, DXGI_GPU_PREFERENCE preference) where T : IDXGIAdapter => EnumAdapterByGpuPreference<T>(factory?.Object, index, preference);
        public static IComObject<T> EnumAdapterByGpuPreference<T>(this IDXGIFactory6 factory, int index, DXGI_GPU_PREFERENCE preference) where T : IDXGIAdapter
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.EnumAdapterByGpuPreference((uint)index, preference, typeof(T).GUID, out var adapter);
            return adapter == null ? null : new ComObject<T>((T)adapter);
        }
    }
}
