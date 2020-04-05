// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(1219,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATEDEVICE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _DXGK_CREATEDEVICEFLAGS Flags { get => InteropRuntime.Get<_DXGK_CREATEDEVICEFLAGS>(__bits, 0, 32); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<_DXGK_CREATEDEVICEFLAGS>(value, __bits, 0, 32); } }
        public IntPtr pInfo { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
