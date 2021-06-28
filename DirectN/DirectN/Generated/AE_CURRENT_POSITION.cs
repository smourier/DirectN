// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\audioengineendpoint.h(174,9)
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
