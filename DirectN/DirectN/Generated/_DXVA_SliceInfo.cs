// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxva.h(525,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_SliceInfo
    {
        public ushort wHorizontalPosition;
        public ushort wVerticalPosition;
        public uint dwSliceBitsInBuffer;
        public uint dwSliceDataLocation;
        public byte bStartCodeBitOffset;
        public byte bReservedBits;
        public ushort wMBbitOffset;
        public ushort wNumberMBsInSlice;
        public ushort wQuantizerScaleCode;
        public ushort wBadSliceChopping;
    }
}
