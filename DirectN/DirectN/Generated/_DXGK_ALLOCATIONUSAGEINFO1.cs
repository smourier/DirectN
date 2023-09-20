// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_ALLOCATIONUSAGEINFO1
    {
        public _DXGK_ALLOCATIONUSAGEINFO1__union_0 Flags;
        public _DXGK_ALLOCATIONUSAGEINFO1__union_1 __union_1;
        public uint SwizzledFormat;
        public uint ByteOffset;
        public uint Width;
        public uint Height;
        public uint Pitch;
        public uint Depth;
        public uint SlicePitch;
    }
}
