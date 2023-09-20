// generated from <Windows SDK Path>\shared\d3dkmdt.h
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
