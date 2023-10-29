using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XMFLOAT3 : IEquatable<XMFLOAT3>
    {
        public float x;
        public float y;
        public float z;

        public XMFLOAT3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString() => "X:" + x + " Y:" + y + " Z:" + z;

        public bool Equals(XMFLOAT3 other) => x == other.x && y == other.y && z == other.z;
        public override bool Equals(object obj) => obj is XMFLOAT3 xf && Equals(xf);
        public override int GetHashCode() => x.GetHashCode() ^ y.GetHashCode() ^ z.GetHashCode();
        public static bool operator ==(XMFLOAT3 left, XMFLOAT3 right) => left.Equals(right);
        public static bool operator !=(XMFLOAT3 left, XMFLOAT3 right) => !(left == right);
    };
}
