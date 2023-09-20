// generated from <Windows SDK Path>\um\audioengineendpoint.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AE_CURRENT_POSITION
    {
        public ulong u64DevicePosition;
        public ulong u64StreamPosition;
        public ulong u64PaddingFrames;
        public long hnsQPCPosition;
        public float f32FramesPerSecond;
        public AE_POSITION_FLAGS Flag;
    }
}
