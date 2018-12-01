// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxvahd.h(419,9)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_STREAM_STATE_DESTINATION_RECT_DATA
    {
        public bool Enable;
        public RECT DestinationRect;
    }
}
