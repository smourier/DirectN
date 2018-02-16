using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_OUTDUPL_POINTER_SHAPE_INFO
    {
        public int Type;
        public int Width;
        public int Height;
        public int Pitch;
        public POINT HotSpot;
    }
}
