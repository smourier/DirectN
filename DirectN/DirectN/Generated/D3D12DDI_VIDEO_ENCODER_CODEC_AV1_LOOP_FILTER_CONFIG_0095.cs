// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_CODEC_AV1_LOOP_FILTER_CONFIG_0095
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public ulong[] LoopFilterLevel;
        public ulong LoopFilterLevelU;
        public ulong LoopFilterLevelV;
        public ulong LoopFilterSharpnessLevel;
        public ulong LoopFilterDeltaEnabled;
        public ulong UpdateRefDelta;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public long[] RefDeltas;
        public ulong UpdateModeDelta;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)] 
        public long[] ModeDeltas;
    }
}
