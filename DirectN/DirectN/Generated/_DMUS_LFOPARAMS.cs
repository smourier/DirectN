// generated from <Windows SDK Path>\shared\dmdls.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DMUS_LFOPARAMS
    {
        public int pcFrequency;
        public int tcDelay;
        public int gcVolumeScale;
        public int pcPitchScale;
        public int gcMWToVolume;
        public int pcMWToPitch;
    }
}
