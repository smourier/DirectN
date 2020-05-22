// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(1078,24)
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
