using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XMFLOAT2 : IEquatable<XMFLOAT2>
    {
        public float x;
        public float y;

        public XMFLOAT2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() => "X:" + x + " Y:" + y;

        public bool Equals(XMFLOAT2 other) => x == other.x && y == other.y;
        public override bool Equals(object obj) => obj is XMFLOAT2 xf && Equals(xf);
        public override int GetHashCode() => x.GetHashCode() ^ y.GetHashCode();
        public static bool operator ==(XMFLOAT2 left, XMFLOAT2 right) => left.Equals(right);
        public static bool operator !=(XMFLOAT2 left, XMFLOAT2 right) => !(left == right);
    };
}
