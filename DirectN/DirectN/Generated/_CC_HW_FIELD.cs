// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\ksmedia.h(4640,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _CC_HW_FIELD
    {
        public _VBICODECFILTERING_SCANLINES ScanlinesRequested;
        public uint fieldFlags;
        public long PictureNumber;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)] 
        public _CC_BYTE_PAIR[] Lines;
    }
}
