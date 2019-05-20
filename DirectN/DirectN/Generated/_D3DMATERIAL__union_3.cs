// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dtypes.h(737,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DMATERIAL__union_3
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public _D3DCOLORVALUE emissive { get => InteropRuntime.Get<_D3DCOLORVALUE>(__bits, 0, 128); set => InteropRuntime.Set<_D3DCOLORVALUE>(value, __bits, 0, 128); }
        public _D3DCOLORVALUE dcvEmissive { get => InteropRuntime.Get<_D3DCOLORVALUE>(__bits, 0, 128); set => InteropRuntime.Set<_D3DCOLORVALUE>(value, __bits, 0, 128); }
    }
}
