using System;

namespace DirectN
{
    public partial struct WICRect
    {
        public WICRect(int x, int y, int width, int height)
        {
            if (width < 0)
                throw new ArgumentOutOfRangeException(nameof(width));

            if (height < 0)
                throw new ArgumentOutOfRangeException(nameof(height));

            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public int Right => X + Width;
        public int Bottom => Y + Height;

        public override string ToString() => "L:" + X + " T:" + Y + " W:" + Width + " H:" + Height + " R:" + Right + " B:" + Bottom;
        public override bool Equals(object obj) => obj is WICRect rect && rect.X == X && rect.Y == Y && rect.Width == Width && rect.Height == Height;
        public override int GetHashCode() => X.GetHashCode() ^ Y.GetHashCode() ^ Width.GetHashCode() ^ Height.GetHashCode();

        public static bool operator ==(WICRect left, WICRect right) => left.Equals(right);
        public static bool operator !=(WICRect left, WICRect right) => !left.Equals(right);
    }
}
