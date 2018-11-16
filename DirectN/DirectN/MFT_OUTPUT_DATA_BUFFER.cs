using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MFT_OUTPUT_DATA_BUFFER
    {
        public int dwStreamID;
        public IMFSample pSample;
        public int dwStatus;
        public IMFCollection pEvents;
    }
}
