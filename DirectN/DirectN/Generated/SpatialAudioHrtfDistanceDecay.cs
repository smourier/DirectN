// generated from <Windows SDK Path>\um\spatialaudiohrtf.h
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
