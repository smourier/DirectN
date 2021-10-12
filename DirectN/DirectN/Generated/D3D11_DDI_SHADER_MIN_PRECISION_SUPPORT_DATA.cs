// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(7339,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_DDI_SHADER_MIN_PRECISION_SUPPORT_DATA
    {
        public uint PixelShaderMinPrecision;
        public uint AllOtherStagesMinPrecision;
    }
}
