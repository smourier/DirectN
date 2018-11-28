using System;

namespace DirectN
{
    public static class IDXGISwapChainExtensions
    {
        public static void Present(this ComObject<IDXGISwapChain> chain, int syncInterval, DXGI_PRESENT flags) => Present(chain?.Object, syncInterval, flags);
        public static void Present(this ComObject<IDXGISwapChain1> chain, int syncInterval, DXGI_PRESENT flags) => Present(chain?.Object, syncInterval, flags);
        public static void Present(this ComObject<IDXGISwapChain2> chain, int syncInterval, DXGI_PRESENT flags) => Present(chain?.Object, syncInterval, flags);
        public static void Present(this ComObject<IDXGISwapChain3> chain, int syncInterval, DXGI_PRESENT flags) => Present(chain?.Object, syncInterval, flags);
        public static void Present(this ComObject<IDXGISwapChain4> chain, int syncInterval, DXGI_PRESENT flags) => Present(chain?.Object, syncInterval, flags);
        public static void Present(this IDXGISwapChain chain, int syncInterval, DXGI_PRESENT flags)
        {
            if (chain == null)
                throw new ArgumentNullException(nameof(chain));

            chain.Present(syncInterval, flags).ThrowOnError();
        }

        public static DXGI_SWAP_CHAIN_DESC GetDesc(this ComObject<IDXGISwapChain> chain) => GetDesc(chain?.Object);
        public static DXGI_SWAP_CHAIN_DESC GetDesc(this ComObject<IDXGISwapChain1> chain) => GetDesc(chain?.Object);
        public static DXGI_SWAP_CHAIN_DESC GetDesc(this ComObject<IDXGISwapChain2> chain) => GetDesc(chain?.Object);
        public static DXGI_SWAP_CHAIN_DESC GetDesc(this ComObject<IDXGISwapChain3> chain) => GetDesc(chain?.Object);
        public static DXGI_SWAP_CHAIN_DESC GetDesc(this ComObject<IDXGISwapChain4> chain) => GetDesc(chain?.Object);
        public static DXGI_SWAP_CHAIN_DESC GetDesc(this IDXGISwapChain chain)
        {
            if (chain == null)
                throw new ArgumentNullException(nameof(chain));

            var desc = new DXGI_SWAP_CHAIN_DESC();
            chain.GetDesc(out desc).ThrowOnError();
            return desc;
        }

        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGISwapChain> chain) => GetFrameStatistics(chain?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGISwapChain1> chain) => GetFrameStatistics(chain?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGISwapChain2> chain) => GetFrameStatistics(chain?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGISwapChain3> chain) => GetFrameStatistics(chain?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGISwapChain4> chain) => GetFrameStatistics(chain?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this IDXGISwapChain chain)
        {
            if (chain == null)
                throw new ArgumentNullException(nameof(chain));

            var stats = new DXGI_FRAME_STATISTICS();
            if (chain.GetFrameStatistics(out stats).IsError)
                return null;

            return stats;
        }

        public static DXGI_SWAP_CHAIN_FULLSCREEN_DESC GetFullscreenDesc(this ComObject<IDXGISwapChain1> chain) => GetFullscreenDesc(chain?.Object);
        public static DXGI_SWAP_CHAIN_FULLSCREEN_DESC GetFullscreenDesc(this ComObject<IDXGISwapChain2> chain) => GetFullscreenDesc(chain?.Object);
        public static DXGI_SWAP_CHAIN_FULLSCREEN_DESC GetFullscreenDesc(this ComObject<IDXGISwapChain3> chain) => GetFullscreenDesc(chain?.Object);
        public static DXGI_SWAP_CHAIN_FULLSCREEN_DESC GetFullscreenDesc(this ComObject<IDXGISwapChain4> chain) => GetFullscreenDesc(chain?.Object);
        public static DXGI_SWAP_CHAIN_FULLSCREEN_DESC GetFullscreenDesc(this IDXGISwapChain1 chain)
        {
            if (chain == null)
                throw new ArgumentNullException(nameof(chain));

            var desc = new DXGI_SWAP_CHAIN_FULLSCREEN_DESC();
            chain.GetFullscreenDesc(out desc).ThrowOnError();
            return desc;
        }

        public static IntPtr GetHwnd(this ComObject<IDXGISwapChain1> chain) => GetHwnd(chain?.Object);
        public static IntPtr GetHwnd(this ComObject<IDXGISwapChain2> chain) => GetHwnd(chain?.Object);
        public static IntPtr GetHwnd(this ComObject<IDXGISwapChain3> chain) => GetHwnd(chain?.Object);
        public static IntPtr GetHwnd(this ComObject<IDXGISwapChain4> chain) => GetHwnd(chain?.Object);
        public static IntPtr GetHwnd(this IDXGISwapChain1 chain)
        {
            if (chain == null)
                throw new ArgumentNullException(nameof(chain));

            chain.GetHwnd(out IntPtr handle).ThrowOnError();
            return handle;
        }

        public static DXGI_MODE_ROTATION GetRotation(this ComObject<IDXGISwapChain1> chain) => GetRotation(chain?.Object);
        public static DXGI_MODE_ROTATION GetRotation(this ComObject<IDXGISwapChain2> chain) => GetRotation(chain?.Object);
        public static DXGI_MODE_ROTATION GetRotation(this ComObject<IDXGISwapChain3> chain) => GetRotation(chain?.Object);
        public static DXGI_MODE_ROTATION GetRotation(this ComObject<IDXGISwapChain4> chain) => GetRotation(chain?.Object);
        public static DXGI_MODE_ROTATION GetRotation(this IDXGISwapChain1 chain)
        {
            if (chain == null)
                throw new ArgumentNullException(nameof(chain));

            chain.GetRotation(out DXGI_MODE_ROTATION rotation).ThrowOnError();
            return rotation;
        }

        public static void SetRotation(this ComObject<IDXGISwapChain1> chain, DXGI_MODE_ROTATION rotation) => SetRotation(chain?.Object, rotation);
        public static void SetRotation(this ComObject<IDXGISwapChain2> chain, DXGI_MODE_ROTATION rotation) => SetRotation(chain?.Object, rotation);
        public static void SetRotation(this ComObject<IDXGISwapChain3> chain, DXGI_MODE_ROTATION rotation) => SetRotation(chain?.Object, rotation);
        public static void SetRotation(this ComObject<IDXGISwapChain4> chain, DXGI_MODE_ROTATION rotation) => SetRotation(chain?.Object, rotation);
        public static void SetRotation(this IDXGISwapChain1 chain, DXGI_MODE_ROTATION rotation)
        {
            if (chain == null)
                throw new ArgumentNullException(nameof(chain));

            chain.SetRotation(rotation).ThrowOnError();
        }

        public static DXGI_RGBA GetBackgroundColor(this ComObject<IDXGISwapChain1> chain) => GetBackgroundColor(chain?.Object);
        public static DXGI_RGBA GetBackgroundColor(this ComObject<IDXGISwapChain2> chain) => GetBackgroundColor(chain?.Object);
        public static DXGI_RGBA GetBackgroundColor(this ComObject<IDXGISwapChain3> chain) => GetBackgroundColor(chain?.Object);
        public static DXGI_RGBA GetBackgroundColor(this ComObject<IDXGISwapChain4> chain) => GetBackgroundColor(chain?.Object);
        public static DXGI_RGBA GetBackgroundColor(this IDXGISwapChain1 chain)
        {
            if (chain == null)
                throw new ArgumentNullException(nameof(chain));

            chain.GetBackgroundColor(out DXGI_RGBA color).ThrowOnError();
            return color;
        }

        public static void SetBackgroundColor(this ComObject<IDXGISwapChain1> chain, DXGI_RGBA color) => SetBackgroundColor(chain?.Object, color);
        public static void SetBackgroundColor(this ComObject<IDXGISwapChain2> chain, DXGI_RGBA color) => SetBackgroundColor(chain?.Object, color);
        public static void SetBackgroundColor(this ComObject<IDXGISwapChain3> chain, DXGI_RGBA color) => SetBackgroundColor(chain?.Object, color);
        public static void SetBackgroundColor(this ComObject<IDXGISwapChain4> chain, DXGI_RGBA color) => SetBackgroundColor(chain?.Object, color);
        public static void SetBackgroundColor(this IDXGISwapChain1 chain, DXGI_RGBA color)
        {
            if (chain == null)
                throw new ArgumentNullException(nameof(chain));

            chain.SetBackgroundColor(ref color).ThrowOnError();
        }

        public static DXGI_SWAP_CHAIN_DESC1 GetDesc1(this ComObject<IDXGISwapChain1> chain) => GetDesc1(chain?.Object);
        public static DXGI_SWAP_CHAIN_DESC1 GetDesc1(this ComObject<IDXGISwapChain2> chain) => GetDesc1(chain?.Object);
        public static DXGI_SWAP_CHAIN_DESC1 GetDesc1(this ComObject<IDXGISwapChain3> chain) => GetDesc1(chain?.Object);
        public static DXGI_SWAP_CHAIN_DESC1 GetDesc1(this ComObject<IDXGISwapChain4> chain) => GetDesc1(chain?.Object);
        public static DXGI_SWAP_CHAIN_DESC1 GetDesc1(this IDXGISwapChain1 chain)
        {
            if (chain == null)
                throw new ArgumentNullException(nameof(chain));

            var desc = new DXGI_SWAP_CHAIN_DESC1();
            chain.GetDesc1(out desc).ThrowOnError();
            return desc;
        }

        public static ComObject<T> GetContainingOutput<T>(this ComObject<IDXGISwapChain> chain) where T : IDXGIOutput => GetContainingOutput<T>(chain?.Object);
        public static ComObject<T> GetContainingOutput<T>(this ComObject<IDXGISwapChain1> chain) where T : IDXGIOutput => GetContainingOutput<T>(chain?.Object);
        public static ComObject<T> GetContainingOutput<T>(this ComObject<IDXGISwapChain2> chain) where T : IDXGIOutput => GetContainingOutput<T>(chain?.Object);
        public static ComObject<T> GetContainingOutput<T>(this ComObject<IDXGISwapChain3> chain) where T : IDXGIOutput => GetContainingOutput<T>(chain?.Object);
        public static ComObject<T> GetContainingOutput<T>(this ComObject<IDXGISwapChain4> chain) where T : IDXGIOutput => GetContainingOutput<T>(chain?.Object);
        public static ComObject<T> GetContainingOutput<T>(this IDXGISwapChain chain) where T : IDXGIOutput
        {
            if (chain == null)
                throw new ArgumentNullException(nameof(chain));

            chain.GetContainingOutput(out IDXGIOutput output).ThrowOnError();
            return new ComObject<T>((T)output);
        }
    }
}
