// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2856,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DDDIARG_CHECKPRESENTDURATIONSUPPORT
    {
        public uint VidPnSourceId;
        public uint DesiredPresentDuration;
        public uint ClosestSmallerDuration;
        public uint ClosestLargerDuration;
    }
}
