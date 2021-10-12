// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmdt.h(461,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIDEO_PRESENT_TARGET
    {
        public uint Id;
        public _D3DKMDT_VIDEO_OUTPUT_TECHNOLOGY VideoOutputTechnology;
        public _DXGK_CHILD_DEVICE_HPD_AWARENESS VideoOutputHpdAwareness;
        public _D3DKMDT_MONITOR_ORIENTATION_AWARENESS MonitorOrientationAwareness;
        public byte SupportsSdtvModes;
    }
}
