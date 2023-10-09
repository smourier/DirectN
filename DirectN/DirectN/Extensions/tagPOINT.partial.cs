using System;

namespace DirectN
{
    public partial struct tagPOINT : IEquatable<tagPOINT>
    {
        public tagPOINT(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public tagPOINT(float x, float y)
        {
#if DEBUG
            if (x.IsNotSet())
                throw new ArgumentException(null, nameof(x));

            if (y.IsNotSet())
                throw new ArgumentException(null, nameof(y));

#endif

            this.x = x.FloorI();
            this.y = y.FloorI();
        }

        public bool IsZero => x == 0 && y == 0;
        public override string ToString() => "X=" + x + ",Y=" + y;
        public bool Equals(tagPOINT other) => x == other.x && y == other.y;
        public override bool Equals(object obj) => obj is tagPOINT sz && Equals(sz);
        public override int GetHashCode() => x.GetHashCode() ^ y.GetHashCode();
        public D2D_POINT_2F ToD2D_POINT_2F() => new D2D_POINT_2F(x, y);

        public static bool operator ==(tagPOINT left, tagPOINT right) => left.Equals(right);
        public static bool operator !=(tagPOINT left, tagPOINT right) => !left.Equals(right);
    }
}
