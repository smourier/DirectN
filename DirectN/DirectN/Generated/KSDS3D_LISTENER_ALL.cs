// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDS3D_LISTENER_ALL
    {
        public _DS3DVECTOR Position;
        public _DS3DVECTOR Velocity;
        public _DS3DVECTOR OrientFront;
        public _DS3DVECTOR OrientTop;
        public float DistanceFactor;
        public float RolloffFactor;
        public float DopplerFactor;
    }
}
