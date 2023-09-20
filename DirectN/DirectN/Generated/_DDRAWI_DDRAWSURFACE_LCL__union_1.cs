// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWCLIPPER_INT = DirectN._DDRAWI_DDRAWCLIPPER_INT;
using LPDDRAWI_DDRAWCLIPPER_LCL = DirectN._DDRAWI_DDRAWCLIPPER_LCL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDRAWI_DDRAWSURFACE_LCL__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 144)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr lpDDClipper { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[144]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public IntPtr lp16DDClipper { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[144]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
