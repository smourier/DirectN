// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_AV1_SEGMENTATION_CONFIG_0095
    {
        public ulong UpdateMap;
        public ulong TemporalUpdate;
        public ulong UpdateData;
        public ulong NumSegments;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public D3D12DDI_VIDEO_ENCODER_AV1_SEGMENT_DATA_0095[] SegmentsData;
    }
}
