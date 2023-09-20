// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKS_DATARANGE_MPEG2_VIDEO
    {
        public int DataRange;
        public bool bFixedSizeSamples;
        public bool bTemporalCompression;
        public uint StreamDescriptionFlags;
        public uint MemoryAllocationFlags;
        public _KS_VIDEO_STREAM_CONFIG_CAPS ConfigCaps;
        public tagKS_MPEGVIDEOINFO2 VideoInfoHeader;
    }
}
