// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\spatialaudiohrtf.h(126,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SpatialAudioHrtfDistanceDecay
    {
        public SpatialAudioHrtfDistanceDecayType Type;
        public float MaxGain;
        public float MinGain;
        public float UnityGainDistance;
        public float CutoffDistance;
    }
}
