// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DS3DLISTENER
    {
        public uint dwSize;
        public _D3DVECTOR vPosition;
        public _D3DVECTOR vVelocity;
        public _D3DVECTOR vOrientFront;
        public _D3DVECTOR vOrientTop;
        public float flDistanceFactor;
        public float flRolloffFactor;
        public float flDopplerFactor;
    }
}
