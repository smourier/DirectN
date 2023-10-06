using System;

namespace DirectN
{
    public struct WicSize
    {
        public double Width;
        public double Height;

        public WicSize(double width, double height)
        {
            if (width < 0)
                throw new ArgumentOutOfRangeException(nameof(width));

            if (height < 0)
                throw new ArgumentOutOfRangeException(nameof(height));

            Width = width;
            Height = height;
        }

        public override string ToString() => Width + " x " + Height;
        public override bool Equals(object obj) => obj is WicSize size && size.Width == Width && size.Height == Height;
        public override int GetHashCode() => Width.GetHashCode() ^ Height.GetHashCode();

        public static bool operator ==(WicSize left, WicSize right) => left.Equals(right);
        public static bool operator !=(WicSize left, WicSize right) => !left.Equals(right);

    }
}
