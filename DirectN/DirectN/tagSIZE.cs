using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagSIZE
    {
        public tagSIZE(int cx, int cy)
        {
            this.cx = cx;
            this.cy = cy;
        }

        public int cx;
        public int cy;

        public override string ToString() => "x=" + cx + ",y=" + cy;
    }
}
