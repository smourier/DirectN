// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_EXTENDEDPROP_FIELDOFVIEW2_CONFIGCAPS
    {
        public ushort DefaultDiagonalFieldOfViewInDegrees;
        public ushort DiscreteFoVStopsCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 360)] 
        public ushort[] DiscreteFoVStops;
        public uint Reserved;
    }
}
