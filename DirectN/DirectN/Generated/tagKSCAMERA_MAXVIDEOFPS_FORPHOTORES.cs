// generated from <Windows SDK Path>\shared\ksmedia.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagKSCAMERA_MAXVIDEOFPS_FORPHOTORES
    {
        public uint PhotoResWidth;
        public uint PhotoResHeight;
        public uint PreviewFPSNum;
        public uint PreviewFPSDenom;
        public uint CaptureFPSNum;
        public uint CaptureFPSDenom;
    }
}
