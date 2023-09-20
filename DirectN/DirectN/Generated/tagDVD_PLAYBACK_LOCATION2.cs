// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_PLAYBACK_LOCATION2
    {
        public uint TitleNum;
        public uint ChapterNum;
        public tagDVD_HMSF_TIMECODE TimeCode;
        public uint TimeCodeFlags;
    }
}
