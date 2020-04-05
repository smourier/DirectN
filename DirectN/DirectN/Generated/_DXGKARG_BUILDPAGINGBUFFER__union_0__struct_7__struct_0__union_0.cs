// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(3992,17)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_BUILDPAGINGBUFFER__union_0__struct_7__struct_0__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public long SegmentAddress { get => InteropRuntime.GetInt64(__bits, 0, 64); set { if (__bits == null) __bits = new byte[40]; InteropRuntime.SetInt64(value, __bits, 0, 64); } }
        public IntPtr pMdl { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
