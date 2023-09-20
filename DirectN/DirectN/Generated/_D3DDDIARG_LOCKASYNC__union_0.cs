// generated from <Windows SDK Path>\um\d3dumddi.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDIARG_LOCKASYNC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DDDIRANGE Range { get => InteropRuntime.Get<_D3DDDIRANGE>(__bits, 0, 64); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<_D3DDDIRANGE>(value, __bits, 0, 64); } }
        public tagRECT Area { get => InteropRuntime.Get<tagRECT>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<tagRECT>(value, __bits, 0, 128); } }
        public _D3DDDIBOX Box { get => InteropRuntime.Get<_D3DDDIBOX>(__bits, 0, 192); set { if (__bits == null) __bits = new byte[24]; InteropRuntime.Set<_D3DDDIBOX>(value, __bits, 0, 192); } }
    }
}
