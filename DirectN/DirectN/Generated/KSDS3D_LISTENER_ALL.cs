// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\ksmedia.h(1156,9)
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
