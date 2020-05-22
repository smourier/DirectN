// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(6145,9)
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
