// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(8018,9)
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
