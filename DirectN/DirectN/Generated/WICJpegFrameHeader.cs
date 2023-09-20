// generated from <Windows SDK Path>\um\wincodec.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct WICJpegFrameHeader
    {
        public uint Width;
        public uint Height;
        public WICJpegTransferMatrix TransferMatrix;
        public WICJpegScanType ScanType;
        public uint cComponents;
        public uint ComponentIdentifiers;
        public uint SampleFactors;
        public uint QuantizationTableIndices;
    }
}
