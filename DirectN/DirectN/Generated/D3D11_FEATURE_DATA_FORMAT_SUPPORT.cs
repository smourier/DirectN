// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(7556,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_FEATURE_DATA_FORMAT_SUPPORT
    {
        public DXGI_FORMAT InFormat;
        public uint OutFormatSupport;
    }
}
