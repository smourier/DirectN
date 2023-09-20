// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10DDIARG_OPENADAPTER__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr pAdapterFuncs { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public IntPtr pAdapterFuncs_2 { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[40]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
