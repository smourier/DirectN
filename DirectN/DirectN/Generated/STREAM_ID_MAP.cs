// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct STREAM_ID_MAP
    {
        public uint stream_id;
        public uint dwMediaSampleContent;
        public uint ulSubstreamFilterValue;
        public int iDataOffset;
    }
}
