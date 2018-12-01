// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxvahd.h(339,9)
using System;
using System.Runtime.InteropServices;
using DXVAHD_COLOR = DirectN._DXVAHD_COLOR;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_BLT_STATE_BACKGROUND_COLOR_DATA
    {
        public bool YCbCr;
        public DXVAHD_COLOR BackgroundColor;
    }
}
