// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dukmdt.h(1055,9)
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
