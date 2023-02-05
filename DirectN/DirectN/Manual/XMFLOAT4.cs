using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XMFLOAT4 : IEquatable<XMFLOAT4>
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public XMFLOAT4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public override string ToString() => "X:" + x + " Y:" + y + " Z:" + z + " W:" + w;

        public bool Equals(XMFLOAT4 other) => x == other.x && y == other.y && z == other.z && w == other.w;
        public override bool Equals(object obj) => obj is XMFLOAT4 xf && Equals(xf);
        public override int GetHashCode() => x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode() ^ w.GetHashCode();
        public static bool operator ==(XMFLOAT4 left, XMFLOAT4 right) => left.Equals(right);
        public static bool operator !=(XMFLOAT4 left, XMFLOAT4 right) => !(left == right);
    };
}
