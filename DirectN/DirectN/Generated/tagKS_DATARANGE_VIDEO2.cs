// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\ksmedia.h(4357,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_DATARANGE_VIDEO2
    {
        public int DataRange;
        public bool bFixedSizeSamples;
        public bool bTemporalCompression;
        public uint StreamDescriptionFlags;
        public uint MemoryAllocationFlags;
        public _KS_VIDEO_STREAM_CONFIG_CAPS ConfigCaps;
        public tagKS_VIDEOINFOHEADER2 VideoInfoHeader;
    }
}
