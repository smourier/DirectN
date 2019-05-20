// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10umddi.h(3138,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_1DDIARG_VIDEODECODERBEGINFRAME
    {
        public D3D11_1DDI_HVIDEODECODEROUTPUTVIEW hOutputView;
        public IntPtr pContentKey;
        public uint ContentKeySize;
    }
}
