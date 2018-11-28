using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MFT_OUTPUT_STREAM_INFO
    {
        public MFT_OUTPUT_STREAM_INFO_FLAGS dwFlags;
        public int cbSize;
        public int cbAlignment;
    }
}
