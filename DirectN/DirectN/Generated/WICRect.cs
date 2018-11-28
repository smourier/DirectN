using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public class WICRect
    {
        public int X;
        public int Y;
        public int Width;
        public int Height;
    }
}
