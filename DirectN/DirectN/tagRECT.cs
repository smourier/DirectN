using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct tagRECT
    {
        public int left;
        public int top;
        public int right;
        public int bottom;

        public int Width => Math.Abs(right - bottom);
        public int Height => Math.Abs(bottom - top);

        public override string ToString() => "L=" + left + ",T=" + top + ",W=" + Width + ",H=" + Height;
    }
}
