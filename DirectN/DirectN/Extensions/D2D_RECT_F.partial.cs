using System;

namespace DirectN
{
    public partial struct D2D_RECT_F
    {
        public D2D_RECT_F(float left, float top, float right, float bottom)
        {
            this.left = left;
            this.top = top;
            this.right = right;
            this.bottom = bottom;
        }

        public float Width => Math.Abs(right - left);
        public float Height => Math.Abs(bottom - top);

        public override string ToString() => "L=" + left + ",T=" + top + ",W=" + Width + ",H=" + Height;
    }
}
