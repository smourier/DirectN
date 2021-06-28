// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(790,9)
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
