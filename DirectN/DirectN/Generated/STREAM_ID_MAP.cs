// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(16371,9)
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
