// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(2890,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_TARGET_GAMMA_CAPS
    {
        public _DXGK_TARGET_GAMMA_CAPS_VERSION Version;
        public _DXGK_GAMMA_1DLUT_CAP LookupTable1DDegammaCap;
        public _DXGK_GAMMA_MATRIX_CAP ColorMatrix3x3Cap;
        public _DXGK_GAMMA_1DLUT_CAP LookupTable1DRegammaCap;
    }
}
