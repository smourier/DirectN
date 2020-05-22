// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\spatialaudiohrtf.h(100,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SpatialAudioHrtfDirectivity
    {
        public SpatialAudioHrtfDirectivityType Type;
        public float Scaling;
    }
}
