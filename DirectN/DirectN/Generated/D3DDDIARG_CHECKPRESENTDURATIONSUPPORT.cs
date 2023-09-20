// generated from <Windows SDK Path>\um\d3dumddi.h
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
