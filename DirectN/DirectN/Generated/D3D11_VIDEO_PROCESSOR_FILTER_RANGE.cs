// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(10103,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_VIDEO_PROCESSOR_FILTER_RANGE
    {
        public int Minimum;
        public int Maximum;
        public int Default;
        public float Multiplier;
    }
}
