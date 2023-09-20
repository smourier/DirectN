// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _NABTS_BUFFER
    {
        public _VBICODECFILTERING_SCANLINES ScanlinesRequested;
        public long PictureNumber;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)] 
        public _NABTS_BUFFER_LINE[] NabtsLines;
    }
}
