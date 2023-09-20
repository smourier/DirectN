// generated from <Windows SDK Path>\shared\ks.h
using System;
using System.Runtime.InteropServices;
using KS_SEEKING_FLAGS = DirectN.KS_SEEKING;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_POSITIONS
    {
        public long Current;
        public long Stop;
        public KS_SEEKING_FLAGS CurrentFlags;
        public KS_SEEKING_FLAGS StopFlags;
    }
}
