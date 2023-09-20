// generated from <Windows SDK Path>\um\d3dnthal.h
using System;
using System.Runtime.InteropServices;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DNTHAL_CONTEXTCREATEDATA__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 176)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr lpDDSZ { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[176]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public IntPtr lpDDSZLcl { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[176]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
