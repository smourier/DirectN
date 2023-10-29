using System;

namespace DirectN
{
    public partial struct D2D_VECTOR_2F : IEquatable<D2D_VECTOR_2F>
    {
        public D2D_VECTOR_2F(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() => "X:" + x + " Y:" + y;

        public bool IsValid => !IsInvalid;
        public bool IsInvalid => x.IsInvalid() || y.IsInvalid();
        public bool IsSet => x.IsSet() && y.IsSet();
        public bool IsNotSet => x.IsNotSet() || y.IsNotSet();
        public bool Equals(D2D_VECTOR_2F other) => x == other.x && y == other.y;
        public float[] ToArray() => new[] { x, y };
        public override bool Equals(object obj) => obj is D2D_VECTOR_2F sz && Equals(sz);
        public override int GetHashCode() => x.GetHashCode() ^ y.GetHashCode();
        public static bool operator ==(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => left.Equals(right);
        public static bool operator !=(D2D_VECTOR_2F left, D2D_VECTOR_2F right) => !(left == right);
        public D2D_SIZE_F ToD2D_SIZE_F() => new D2D_SIZE_F(x, y);
    }
}
