// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG
    {
        public ulong UpdateMap;
        public ulong TemporalUpdate;
        public ulong UpdateData;
        public ulong NumSegments;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public D3D12_VIDEO_ENCODER_AV1_SEGMENT_DATA[] SegmentsData;
    }
}
