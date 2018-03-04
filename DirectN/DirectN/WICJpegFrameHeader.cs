using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WICJpegFrameHeader
    {
        public int Width;
        public int Height;
        public WICJpegTransferMatrix TransferMatrix;
        public WICJpegScanType ScanType;
        public int cComponents;
        public int ComponentIdentifiers;
        public int SampleFactors;
        public int QuantizationTableIndices;
    }
}
