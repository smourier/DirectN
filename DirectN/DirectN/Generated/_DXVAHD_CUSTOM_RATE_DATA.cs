// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxvahd.h(317,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_CUSTOM_RATE_DATA
    {
        public _DXVAHD_RATIONAL CustomRate;
        public uint OutputFrames;
        public bool InputInterlaced;
        public uint InputFramesOrFields;
    }
}
