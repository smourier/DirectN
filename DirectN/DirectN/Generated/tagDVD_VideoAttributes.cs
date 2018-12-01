// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(21207,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_VideoAttributes
    {
        public bool fPanscanPermitted;
        public bool fLetterboxPermitted;
        public uint ulAspectX;
        public uint ulAspectY;
        public uint ulFrameRate;
        public uint ulFrameHeight;
        public tagDVD_VIDEO_COMPRESSION Compression;
        public bool fLine21Field1InGOP;
        public bool fLine21Field2InGOP;
        public uint ulSourceResolutionX;
        public uint ulSourceResolutionY;
        public bool fIsSourceLetterboxed;
        public bool fIsFilmMode;
    }
}
