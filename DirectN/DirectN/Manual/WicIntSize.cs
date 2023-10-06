using System;

namespace DirectN
{
    public struct WicIntSize
    {
        public uint Width;
        public uint Height;

        public WicIntSize(uint width, uint height)
        {
            Width = width;
            Height = height;
        }

        public WicIntSize(int width, int height)
        {
            if (width < 0)
                throw new ArgumentOutOfRangeException(nameof(width));

            if (height < 0)
                throw new ArgumentOutOfRangeException(nameof(height));

            Width = (uint)width;
            Height = (uint)height;
        }

        public override string ToString() => Width + " x " + Height;
        public override bool Equals(object obj) => obj is WicIntSize size && size.Width == Width && size.Height == Height;
        public override int GetHashCode() => Width.GetHashCode() ^ Height.GetHashCode();

        public D2D_SIZE_F ToD2D_SIZE_F() => new D2D_SIZE_F(Width, Height);

        public static bool operator ==(WicIntSize left, WicIntSize right) => left.Equals(right);
        public static bool operator !=(WicIntSize left, WicIntSize right) => !left.Equals(right);
    }
}
