// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Slice_H264_Short
    {
        public uint BSNALunitDataLocation;
        public uint SliceBytesInBuffer;
        public ushort wBadSliceChopping;
    }
}
