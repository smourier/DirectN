using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_RATIONAL
    {
        public uint Numerator;
        public uint Denominator;

        public DXGI_RATIONAL(int numerator, int denominator)
        {
            Numerator = (uint)numerator;
            Denominator = (uint)denominator;
        }

        public DXGI_RATIONAL(uint numerator, uint denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public override string ToString() => Numerator + "/" + Denominator;
    }
}
