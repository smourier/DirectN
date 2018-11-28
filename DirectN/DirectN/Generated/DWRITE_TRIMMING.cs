using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DWRITE_TRIMMING
    {
        public DWRITE_TRIMMING_GRANULARITY granularity;
        public int delimiter;
        public int delimiterCount;
    }
}
