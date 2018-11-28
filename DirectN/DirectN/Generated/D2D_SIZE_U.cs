using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct D2D_SIZE_U
    {
        public uint width;
        public uint height;
    }
}
