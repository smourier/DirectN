using System;

namespace DirectN
{
    public partial struct D2D_POINT_2F : IEquatable<D2D_POINT_2F>, IEquatable<D2D_VECTOR_2F>
    {
        public D2D_POINT_2F(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public D2D_POINT_2F(double x, double y)
        {
            this.x = (float)x;
            this.y = (float)y;
        }

        public override string ToString() => "X:" + x + " Y:" + y;

        public bool IsValid => !IsInvalid;
        public bool IsInvalid => x.IsInvalid() || y.IsInvalid();
        public bool IsSet => x.IsSet() && y.IsSet();
        public bool IsZero => x == 0 && y == 0;
        public bool IsNotSet => x.IsNotSet() || y.IsNotSet();
        public bool Equals(D2D_VECTOR_2F other) => x == other.x && y == other.y;
        public bool Equals(D2D_POINT_2F other) => x == other.x && y == other.y;
        public tagPOINT TotagPOINT() => new tagPOINT((int)x, (int)y);
        public tagPOINT TotagPOINTFloor() => new tagPOINT(x.FloorI(), y.FloorI());
        public D2D_POINT_2F Floor() => new D2D_POINT_2F(x.Floor(), y.Floor());
        public D2D_POINT_2F Ceiling() => new D2D_POINT_2F(x.Ceiling(), y.Ceiling());
        public override bool Equals(object obj) => (obj is D2D_POINT_2F sz && Equals(sz)) || (obj is D2D_VECTOR_2F vc && Equals(vc));
        public override int GetHashCode() => x.GetHashCode() ^ y.GetHashCode();
        public static bool operator ==(D2D_POINT_2F left, D2D_POINT_2F right) => left.Equals(right);
        public static bool operator !=(D2D_POINT_2F left, D2D_POINT_2F right) => !left.Equals(right);
        public static D2D_POINT_2F operator +(D2D_POINT_2F left, D2D_POINT_2F right) => new D2D_POINT_2F(left.x + right.x, left.y + right.y);
        public static D2D_POINT_2F operator -(D2D_POINT_2F left, D2D_POINT_2F right) => new D2D_POINT_2F(left.x - right.x, left.y - right.y);
        public static D2D_POINT_2F operator *(D2D_POINT_2F left, D2D_MATRIX_3X2_F right) => right.Multiply(left);
        public static D2D_POINT_2F operator *(D2D_MATRIX_3X2_F left, D2D_POINT_2F right) => left.Multiply(right);
        public static implicit operator D2D_VECTOR_2F(D2D_POINT_2F pt) => new D2D_VECTOR_2F(pt.x, pt.y);
        public static implicit operator D2D_POINT_2F(D2D_VECTOR_2F vc) => new D2D_POINT_2F(vc.x, vc.y);
    }
}
