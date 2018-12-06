using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagPOINT
    {
        public int x;
        public int y;

        public override string ToString() => "X=" + x + ",Y=" + y;
    }
}
