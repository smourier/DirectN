// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(22071,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_PLAYBACK_LOCATION
    {
        public uint TitleNum;
        public uint ChapterNum;
        public uint TimeCode;
    }
}
