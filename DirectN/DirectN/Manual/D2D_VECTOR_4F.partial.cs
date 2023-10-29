using System;

namespace DirectN
{
    public partial struct D2D_VECTOR_4F : IEquatable<D2D_VECTOR_4F>
    {
        public D2D_VECTOR_4F(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public override string ToString() => "X:" + x + " Y:" + y + " Z:" + z + " W:" + w;

        public bool IsValid => !IsInvalid;
        public bool IsInvalid => x.IsInvalid() || y.IsInvalid() || z.IsInvalid() || w.IsInvalid();
        public bool IsSet => x.IsSet() && y.IsSet() && z.IsSet() && w.IsSet();
        public bool IsNotSet => x.IsNotSet() || y.IsNotSet() || z.IsNotSet() || w.IsNotSet();
        public float[] ToArray() => new[] { x, y, z, w };
        public bool Equals(D2D_VECTOR_4F other) => x == other.x && y == other.y && z == other.z && w == other.w;
        public override bool Equals(object obj) => obj is D2D_VECTOR_4F sz && Equals(sz);
        public override int GetHashCode() => x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode() ^ w.GetHashCode();
        public static bool operator ==(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => left.Equals(right);
        public static bool operator !=(D2D_VECTOR_4F left, D2D_VECTOR_4F right) => !(left == right);
    }
}
