using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_RECT_U
    {
        public uint left;
        public uint top;
        public uint right;
        public uint bottom;
    }
}
