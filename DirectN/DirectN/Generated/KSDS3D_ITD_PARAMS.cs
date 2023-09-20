// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDS3D_ITD_PARAMS
    {
        public int Channel;
        public float VolSmoothScale;
        public float TotalDryAttenuation;
        public float TotalWetAttenuation;
        public int SmoothFrequency;
        public int Delay;
    }
}
