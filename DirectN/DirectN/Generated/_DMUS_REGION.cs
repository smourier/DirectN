// generated from <Windows SDK Path>\shared\dmdls.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DMUS_REGION
    {
        public _RGNRANGE RangeKey;
        public _RGNRANGE RangeVelocity;
        public ushort fusOptions;
        public ushort usKeyGroup;
        public uint ulRegionArtIdx;
        public uint ulNextRegionIdx;
        public uint ulFirstExtCkIdx;
        public _WAVELINK WaveLink;
        public _rwsmp WSMP;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _rloop[] WLOOP;
    }
}
