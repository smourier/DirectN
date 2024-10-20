// generated from <Windows SDK Path>\um\dxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_MJPEG
    {
        public uint width;
        public uint height;
        public byte numComponents;
        public byte bitDepth;
        public ushort reserved16Bits;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte[] quantizationTableSelector;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] scanOffset;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public uint[] scanSize;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte[] componentIdentifier;
        public ushort restartInterval;
        public ushort reserved16Bits2;
        public uint reserved32Bits;
        public uint statusReportFeedbackNumber;
    }
}
