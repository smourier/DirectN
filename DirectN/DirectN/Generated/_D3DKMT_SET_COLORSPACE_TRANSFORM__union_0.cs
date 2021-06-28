// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(3122,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SET_COLORSPACE_TRANSFORM__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 216)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr pColorSpaceTransform { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[216]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
