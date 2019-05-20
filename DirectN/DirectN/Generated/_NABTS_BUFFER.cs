// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(4631,9)
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
