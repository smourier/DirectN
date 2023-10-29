using System;

namespace DirectN
{
    public struct Hsv : IEquatable<Hsv>
    {
        public float Hue;
        public float Saturation;
        public float Value;

        public Hsv(float hue, float saturation, float value)
        {
            Hue = hue;
            Saturation = saturation;
            Value = value;
        }

        public Hsv Complementary
        {
            get
            {
                var hue = Hue;
                hue += 180f;
                if (hue > 360f)
                {
                    hue -= 360f;
                }
                return new Hsv(hue, Saturation, Value);
            }
        }

        public _D3DCOLORVALUE ToD3DCOLORVALUE(float a = 1f)
        {
            var hue = Hue;
            var saturation = Saturation;
            var value = Value;

            while (hue >= 360f)
            {
                hue -= 360f;
            }

            while (hue < 0f)
            {
                hue += 360f;
            }

            saturation = saturation < 0f ? 0f : saturation;
            saturation = saturation > 1f ? 1f : saturation;

            value = value < 0f ? 0f : value;
            value = value > 1f ? 1f : value;

            var chroma = saturation * value;
            var min = value - chroma;

            if (chroma == 0f)
                return new _D3DCOLORVALUE(a, min, min, min);

            var sextant = (int)(hue / 60f);
            var intermediateColorPercentage = hue / 60f - sextant;
            var max = chroma + min;

            var r = 0f;
            var g = 0f;
            var b = 0f;

            switch (sextant)
            {
                case 0:
                    r = max;
                    g = min + chroma * intermediateColorPercentage;
                    b = min;
                    break;

                case 1:
                    r = min + chroma * (1 - intermediateColorPercentage);
                    g = max;
                    b = min;
                    break;

                case 2:
                    r = min;
                    g = max;
                    b = min + chroma * intermediateColorPercentage;
                    break;

                case 3:
                    r = min;
                    g = min + chroma * (1 - intermediateColorPercentage);
                    b = max;
                    break;

                case 4:
                    r = min + chroma * intermediateColorPercentage;
                    g = min;
                    b = max;
                    break;

                case 5:
                    r = max;
                    g = min;
                    b = min + chroma * (1 - intermediateColorPercentage);
                    break;
            }

            return new _D3DCOLORVALUE(a, r, g, b);
        }

        public override int GetHashCode() => Hue.GetHashCode() ^ Saturation.GetHashCode() ^ Value.GetHashCode();
        public override bool Equals(object other) => other is Hsv hsv && Equals(hsv);
        public bool Equals(Hsv other) => Value == other.Value && Hue == other.Hue && Saturation == other.Saturation;
        public override string ToString() => "H:" + Hue + " S:" + Saturation + " V:" + Value;

        public static Hsv From(_D3DCOLORVALUE color) => new Hsv(GetHue(color.r, color.g, color.b), GetSaturation(color.r, color.g, color.b), GetValue(color.r, color.g, color.b));

        public static float GetHue(float r, float g, float b)
        {
            if (r == g && g == b)
                return 0;

            var max = r;
            var min = r;

            if (g > max) max = g;
            if (b > max) max = b;
            if (g < min) min = g;
            if (b < min) min = b;

            var delta = max - min;
            var hue = 0f;
            if (r == max)
            {
                hue = (g - b) / delta;
            }
            else if (g == max)
            {
                hue = 2 + (b - r) / delta;
            }
            else if (b == max)
            {
                hue = 4 + (r - g) / delta;
            }

            hue *= 60;

            if (hue < 0)
            {
                hue += 360;
            }
            return hue;
        }

        public static float GetValue(float r, float g, float b) => r >= g ? (r >= b ? r : b) : (g >= b ? g : b);

        public static float GetSaturation(float r, float g, float b)
        {
            var min = r <= g ? (r <= b ? r : b) : (g <= b ? g : b);
            var value = GetValue(r, g, b);
            var chroma = value - min;
            if (chroma == 0f)
                return 0f;

            return chroma / value;
        }

        public static bool operator ==(Hsv x, Hsv y) => x.Equals(y);
        public static bool operator !=(Hsv x, Hsv y) => !x.Equals(y);
    }
}
