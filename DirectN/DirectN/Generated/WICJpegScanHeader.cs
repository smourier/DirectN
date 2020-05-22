// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(1090,24)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICJpegScanHeader
    {
        public uint cComponents;
        public uint RestartInterval;
        public uint ComponentSelectors;
        public uint HuffmanTableIndices;
        public byte StartSpectralSelection;
        public byte EndSpectralSelection;
        public byte SuccessiveApproximationHigh;
        public byte SuccessiveApproximationLow;
    }
}
