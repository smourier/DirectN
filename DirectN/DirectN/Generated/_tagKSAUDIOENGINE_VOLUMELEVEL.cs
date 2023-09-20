// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _tagKSAUDIOENGINE_VOLUMELEVEL
    {
        public int TargetVolume;
        public AUDIO_CURVE_TYPE CurveType;
        public ulong CurveDuration;
    }
}
