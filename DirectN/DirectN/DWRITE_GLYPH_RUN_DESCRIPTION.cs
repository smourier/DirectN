using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DWRITE_GLYPH_RUN_DESCRIPTION
    {
        public string localeName;
        public string @string;
        public int stringLength;
        public ushort[] clusterMap;
        public int textPosition;
    }
}
