// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfobjects.h(3037,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFPaletteEntry
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _MFARGB ARGB { get => InteropRuntime.Get<_MFARGB>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<_MFARGB>(value, __bits, 0, 32); } }
        public __MFAYUVSample AYCbCr { get => InteropRuntime.Get<__MFAYUVSample>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.Set<__MFAYUVSample>(value, __bits, 0, 32); } }
    }
}
