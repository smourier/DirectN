using System;

namespace DirectN
{
    public static class IDXGIOutputExtensions
    {
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput1> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput2> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput3> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput4> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput5> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput6> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this IDXGIOutput output)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var desc = new DXGI_OUTPUT_DESC();
            output.GetDesc(out desc).ThrowOnError();
            return desc;
        }

        public static DXGI_OUTPUT_DESC1 GetDesc1(this ComObject<IDXGIOutput6> output) => GetDesc1(output?.Object);
        public static DXGI_OUTPUT_DESC1 GetDesc1(this IDXGIOutput6 output)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var desc = new DXGI_OUTPUT_DESC1();
            output.GetDesc1(out desc).ThrowOnError();
            return desc;
        }
    }
}
