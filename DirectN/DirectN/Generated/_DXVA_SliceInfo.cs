// generated from <Windows SDK Path>\um\dxva.h
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
