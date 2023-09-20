// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_EXTENDEDPROP_ROI_INFO
    {
        public tagRECT Region;
        public ulong Flags;
        public int Weight;
        public int RegionOfInterestType;
    }
}
