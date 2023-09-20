// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DEVICEINFO
    {
        public uint DmaBufferSize;
        public uint DmaBufferSegmentSet;
        public uint DmaBufferPrivateDataSize;
        public uint AllocationListSize;
        public uint PatchLocationListSize;
        public _DXGK_DEVICEINFOFLAGS Flags;
    }
}
