// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfobjects.h(2828,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFPaletteEntry
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public _MFARGB ARGB => InteropRuntime.Get<_MFARGB>(__bits, 0, 32);
        public __MFAYUVSample AYCbCr => InteropRuntime.Get<__MFAYUVSample>(__bits, 0, 32);
    }
}
