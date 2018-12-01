// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxvahd.h(444,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_STREAM_STATE_ASPECT_RATIO_DATA
    {
        public bool Enable;
        public _DXVAHD_RATIONAL SourceAspectRatio;
        public _DXVAHD_RATIONAL DestinationAspectRatio;
    }
}
