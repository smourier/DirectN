using System;

namespace DirectN
{
    public partial struct tagRECT
    {
        public int Width => Math.Abs(right - bottom);
        public int Height => Math.Abs(bottom - top);

        public override string ToString() => "L=" + left + ",T=" + top + ",W=" + Width + ",H=" + Height;
    }
}
