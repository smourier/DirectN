// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_GETSTANDARDALLOCATIONDRIVERDATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr pCreateSharedPrimarySurfaceData { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[28]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public IntPtr pCreateShadowSurfaceData { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[28]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public IntPtr pCreateStagingSurfaceData { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[28]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public IntPtr pCreateGdiSurfaceData { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[28]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public IntPtr pCreateVirtualGpuSurfaceData { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[28]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
