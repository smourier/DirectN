using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct WICJpegScanHeader
    {
        public int cComponents;
        public int RestartInterval;
        public int ComponentSelectors;
        public int HuffmanTableIndices;
        public byte StartSpectralSelection;
        public byte EndSpectralSelection;
        public byte SuccessiveApproximationHigh;
        public byte SuccessiveApproximationLow;
    }
}
