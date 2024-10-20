// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DSFXI3DL2Reverb
    {
        public int lRoom;
        public int lRoomHF;
        public float flRoomRolloffFactor;
        public float flDecayTime;
        public float flDecayHFRatio;
        public int lReflections;
        public float flReflectionsDelay;
        public int lReverb;
        public float flReverbDelay;
        public float flDiffusion;
        public float flDensity;
        public float flHFReference;
    }
}
