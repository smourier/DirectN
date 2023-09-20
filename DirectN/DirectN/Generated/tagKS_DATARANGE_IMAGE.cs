// generated from <Windows SDK Path>\shared\ksmedia.h
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
