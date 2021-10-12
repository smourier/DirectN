// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(10461,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_PROCESSOR_CUSTOM_RATE
    {
        public DXGI_RATIONAL CustomRate;
        public uint OutputFrames;
        public bool InputInterlaced;
        public uint InputFramesOrFields;
    }
}
