using System;

namespace DirectN
{
    public partial struct D2D_SIZE_F : IEquatable<D2D_SIZE_F>
    {
        public D2D_SIZE_F(float width, float height)
        {
#if DEBUG
            if (width.IsInvalid())
                throw new ArgumentException(null, nameof(width));

            if (height.IsInvalid())
                throw new ArgumentException(null, nameof(height));

            if (width < 0)
                throw new ArgumentException(null, nameof(width));

            if (height < 0)
                throw new ArgumentException(null, nameof(height));

#endif

            this.width = width;
            this.height = height;
        }

        public D2D_SIZE_F(double width, double height)
            : this((float)width, (float)height)
        {
        }

        public override string ToString() => "W:" + width + " H:" + height;

        public bool IsZero => width == 0 && height == 0;
        public bool IsEmpty => width == 0 || height == 0;
        public bool IsValid => !IsInvalid;
        public bool IsInvalid => width.IsInvalid() || height.IsInvalid();
        public bool IsSet => width.IsSet() && height.IsSet();
        public bool IsNotSet => width.IsNotSet() || height.IsNotSet();
        public bool IsMax => width.IsMax() || height.IsMax();
        public bool IsMin => width.IsMin() || height.IsMin();
        public bool Equals(D2D_SIZE_F other) => width == other.width && height == other.height;
        public override bool Equals(object obj) => (obj is D2D_SIZE_F sz && Equals(sz));
        public override int GetHashCode() => width.GetHashCode() ^ height.GetHashCode();
        public static bool operator ==(D2D_SIZE_F left, D2D_SIZE_F right) => left.Equals(right);
        public static bool operator !=(D2D_SIZE_F left, D2D_SIZE_F right) => !left.Equals(right);
        public static D2D_SIZE_F operator +(D2D_SIZE_F left, D2D_SIZE_F right) => new D2D_SIZE_F(left.width + right.width, left.height + right.height);
        public static D2D_SIZE_F operator -(D2D_SIZE_F left, D2D_SIZE_F right) => new D2D_SIZE_F(left.width - right.width, left.height - right.height);

        public tagSIZE ToSize() => new tagSIZE((int)width, (int)height);
        public D2D_SIZE_U ToD2D_SIZE_U() => new D2D_SIZE_U(width.ToUInt32(), height.ToUInt32());
        public D2D_SIZE_F ToD2D_SIZE_F() => new D2D_SIZE_F(width, height);
        public D2D_VECTOR_2F ToD2D_VECTOR_2F() => new D2D_VECTOR_2F(width, height);

#if DEBUG
        public static readonly D2D_SIZE_F Invalid = new D2D_SIZE_F { width = float.NaN, height = float.NaN };
#else
        public static readonly D2D_SIZE_F Invalid = new D2D_SIZE_F(float.NaN, float.NaN);
#endif

#if DEBUG
        public static readonly D2D_SIZE_F MaxValue = new D2D_SIZE_F { width = float.MaxValue, height = float.MaxValue };
        public static readonly D2D_SIZE_F PositiveInfinity = new D2D_SIZE_F { width = float.PositiveInfinity, height = float.PositiveInfinity };
#else
        public static readonly D2D_SIZE_F MaxValue = new D2D_SIZE_F(float.MaxValue, float.MaxValue);
        public static readonly D2D_SIZE_F PositiveInfinity = new D2D_SIZE_F(float.PositiveInfinity, float.PositiveInfinity);
#endif

        public D2D_SIZE_F PixelToHiMetricF()
        {
            var dpi = D2D1Functions.Dpi;
            return new D2D_SIZE_F(tagSIZE.HIMETRIC_PER_INCH * width / dpi.width, tagSIZE.HIMETRIC_PER_INCH * height / dpi.height);
        }

        public tagSIZE PixelToHiMetric()
        {
            var dpi = D2D1Functions.Dpi;
            return new tagSIZE((uint)(tagSIZE.HIMETRIC_PER_INCH * width / dpi.width), (uint)(tagSIZE.HIMETRIC_PER_INCH * height / dpi.height));
        }

        public D2D_SIZE_F HiMetricToPixelF()
        {
            var dpi = D2D1Functions.Dpi;
            return new D2D_SIZE_F(width * dpi.width / tagSIZE.HIMETRIC_PER_INCH, height * dpi.height / tagSIZE.HIMETRIC_PER_INCH);
        }

        public tagSIZE HiMetricToPixel()
        {
            var dpi = D2D1Functions.Dpi;
            return new tagSIZE((uint)(width * dpi.width / tagSIZE.HIMETRIC_PER_INCH), (uint)(height * dpi.height / tagSIZE.HIMETRIC_PER_INCH));
        }

        public D2D_SIZE_F PixelToDip()
        {
            var scale = D2D1Functions.DpiScale;
            return new D2D_SIZE_F(width / scale.width, height / scale.height);
        }

        public D2D_SIZE_F DipToPixel()
        {
            var scale = D2D1Functions.DpiScale;
            return new D2D_SIZE_F(width * scale.width, height * scale.height);
        }
    }
}
