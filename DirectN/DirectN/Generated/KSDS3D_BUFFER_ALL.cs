// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(1202,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSDS3D_BUFFER_ALL
    {
        public _DS3DVECTOR Position;
        public _DS3DVECTOR Velocity;
        public uint InsideConeAngle;
        public uint OutsideConeAngle;
        public _DS3DVECTOR ConeOrientation;
        public int ConeOutsideVolume;
        public float MinDistance;
        public float MaxDistance;
        public uint Mode;
    }
}
