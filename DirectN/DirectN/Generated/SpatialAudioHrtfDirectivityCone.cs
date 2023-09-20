// generated from <Windows SDK Path>\um\spatialaudiohrtf.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SpatialAudioHrtfDirectivityCone
    {
        public SpatialAudioHrtfDirectivity directivity;
        public float InnerAngle;
        public float OuterAngle;
    }
}
