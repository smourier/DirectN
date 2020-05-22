// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(11371,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC
    {
        public uint FourCC;
        public D3D11_VPIV_DIMENSION ViewDimension;
        public D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC__union_0 __union_2;
    }
}
