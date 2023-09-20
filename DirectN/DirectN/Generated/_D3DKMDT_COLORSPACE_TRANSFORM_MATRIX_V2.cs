// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_COLORSPACE_TRANSFORM_MATRIX_V2
    {
        public _D3DKMDT_COLORSPACE_TRANSFORM_STAGE_CONTROL StageControlLookupTable1DDegamma;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4096)] 
        public D3DDDI_DXGI_RGB[] LookupTable1DDegamma;
        public _D3DKMDT_COLORSPACE_TRANSFORM_STAGE_CONTROL StageControlColorMatrix3x3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)] 
        public float[] ColorMatrix3x3;
        public _D3DKMDT_COLORSPACE_TRANSFORM_STAGE_CONTROL StageControlLookupTable1DRegamma;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4096)] 
        public D3DDDI_DXGI_RGB[] LookupTable1DRegamma;
    }
}
