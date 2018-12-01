// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxgiddi.h(999,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_DDI_BASE_ARGS__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr pDXGIDDIBaseFunctions6_1 => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
        public IntPtr pDXGIDDIBaseFunctions6 => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
        public IntPtr pDXGIDDIBaseFunctions5 => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
        public IntPtr pDXGIDDIBaseFunctions4 => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
        public IntPtr pDXGIDDIBaseFunctions3 => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
        public IntPtr pDXGIDDIBaseFunctions2 => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
        public IntPtr pDXGIDDIBaseFunctions => InteropRuntime.GetBits<IntPtr>(__bits, 0, 64);
    }
}
