using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct SIZE
    {
        public SIZE(int cx, int cy)
        {
            this.cx = cx;
            this.cy = cy;
        }

        public int cx;
        public int cy;

        public override string ToString() => "x=" + cx + ",y=" + cy;
    }
}
