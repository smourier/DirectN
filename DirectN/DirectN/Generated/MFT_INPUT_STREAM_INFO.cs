using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MFT_INPUT_STREAM_INFO
    {
        public long hnsMaxLatency;
        public MFT_INPUT_STREAM_INFO_FLAGS dwFlags;
        public int cbSize;
        public int cbMaxLookahead;
        public int cbAlignment;
    }
}
