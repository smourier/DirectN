// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(4417,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_DATARANGE_IMAGE
    {
        public int DataRange;
        public _KS_VIDEO_STREAM_CONFIG_CAPS ConfigCaps;
        public tagKS_BITMAPINFOHEADER ImageInfoHeader;
    }
}
