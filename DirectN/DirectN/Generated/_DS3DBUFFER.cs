// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DS3DBUFFER
    {
        public uint dwSize;
        public _D3DVECTOR vPosition;
        public _D3DVECTOR vVelocity;
        public uint dwInsideConeAngle;
        public uint dwOutsideConeAngle;
        public _D3DVECTOR vConeOrientation;
        public int lConeOutsideVolume;
        public float flMinDistance;
        public float flMaxDistance;
        public uint dwMode;
    }
}
