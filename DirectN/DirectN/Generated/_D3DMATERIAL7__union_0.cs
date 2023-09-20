// generated from <Windows SDK Path>\um\d3dtypes.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DMATERIAL7__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DCOLORVALUE diffuse { get => InteropRuntime.Get<_D3DCOLORVALUE>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_D3DCOLORVALUE>(value, __bits, 0, 128); } }
        public _D3DCOLORVALUE dcvDiffuse { get => InteropRuntime.Get<_D3DCOLORVALUE>(__bits, 0, 128); set { if (__bits == null) __bits = new byte[16]; InteropRuntime.Set<_D3DCOLORVALUE>(value, __bits, 0, 128); } }
    }
}
