using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;

namespace DirectN
{
#pragma warning disable IDE1006 // Naming Styles
    [TypeConverter(typeof(_D3DCOLORVALUEConverter))]
    public partial struct _D3DCOLORVALUE : IEquatable<_D3DCOLORVALUE>
#pragma warning restore IDE1006 // Naming Styles
    {
        private static readonly ConcurrentDictionary<uint, string> _names = new ConcurrentDictionary<uint, string>();
        private static readonly ConcurrentDictionary<string, _D3DCOLORVALUE> _colors = new ConcurrentDictionary<string, _D3DCOLORVALUE>(StringComparer.OrdinalIgnoreCase);

        static _D3DCOLORVALUE()
        {
            foreach (var fi in typeof(_D3DCOLORVALUE).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                var color = (_D3DCOLORVALUE)fi.GetValue(null);
                _names[color.UInt32Value] = fi.Name;
                _colors[fi.Name] = color;
            }
        }

        public float r;
        public float g;
        public float b;
        public float a;

        public _D3DCOLORVALUE(int argb)
            : this((uint)argb)
        {
        }

        public _D3DCOLORVALUE(int argb, byte alpha)
            : this((uint)((alpha << 24) | argb))
        {
        }

        public _D3DCOLORVALUE(uint argb, byte alpha)
            : this(((uint)(alpha << 24) | argb))
        {
        }

        public _D3DCOLORVALUE(uint argb)
        {
            a = ByteToSingle((byte)((argb & 0xff000000) >> 24));
            r = ByteToSingle((byte)((argb & 0xff0000) >> 16));
            g = ByteToSingle((byte)((argb & 0xff00) >> 8));
            b = ByteToSingle((byte)(argb & 0xff));
        }

        public _D3DCOLORVALUE(float r, float g, float b)
            : this(1f, r, g, b)
        {
        }

        public _D3DCOLORVALUE(float a, float r, float g, float b)
        {
#if DEBUG
            if (a < 0 || a > 1)
                throw new ArgumentException(null, nameof(a));

            if (r < 0 || r > 1)
                throw new ArgumentException(null, nameof(r));

            if (g < 0 || g > 1)
                throw new ArgumentException(null, nameof(g));

            if (b < 0 || b > 1)
                throw new ArgumentException(null, nameof(b));
#endif
            this.a = a;
            this.r = r;
            this.g = g;
            this.b = b;
        }

        private static bool IsHexa(char c) => (c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F');

        public static _D3DCOLORVALUE FromArgb(byte r, byte g, byte b) => FromArgb(1, r, g, b);
        public static _D3DCOLORVALUE FromArgb(byte a, byte r, byte g, byte b) => new _D3DCOLORVALUE(ByteToSingle(a), ByteToSingle(r), ByteToSingle(g), ByteToSingle(b));
        public static _D3DCOLORVALUE FromName(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (name.Length > 0)
            {
                if (name.StartsWith("#"))
                {
                    if (uint.TryParse(name.Substring(1), System.Globalization.NumberStyles.HexNumber, null, out var ui))
                        return new _D3DCOLORVALUE(ui);
                }
                else
                {
                    if (_colors.TryGetValue(name, out var value))
                        return value;

                    if (IsHexa(name[0]))
                    {
                        if (uint.TryParse(name, System.Globalization.NumberStyles.HexNumber, null, out var ui))
                            return new _D3DCOLORVALUE(ui);
                    }
                }
            }
            return new _D3DCOLORVALUE();
        }

        public byte BA { get => SingleToByte(a); set => a = ByteToSingle(value); }
        public byte BR { get => SingleToByte(r); set => r = ByteToSingle(value); }
        public byte BG { get => SingleToByte(g); set => g = ByteToSingle(value); }
        public byte BB { get => SingleToByte(b); set => b = ByteToSingle(value); }
        public uint UInt32Value => (((uint)BA) << 24) | (((uint)BR) << 16) | (((uint)BG) << 8) | BB;
        public int Int32Value => (int)UInt32Value;
        public string HtmlString => "#" + UInt32Value.ToString("X8");

        public string Name
        {
            get
            {
                var value = UInt32Value;
                if (_names.TryGetValue(value, out var name))
                    return name;

                return new _D3DCOLORVALUE(value).HtmlString;
            }
        }

        public _D3DCOLORVALUE Complementary => Hsv.From(this).Complementary.ToD3DCOLORVALUE();
        public Tuple<_D3DCOLORVALUE, _D3DCOLORVALUE> Triadic
        {
            get
            {
                var value = Hsl.From(this).Triadic;
                return new Tuple<_D3DCOLORVALUE, _D3DCOLORVALUE>(value.Item1.ToD3DCOLORVALUE(), value.Item2.ToD3DCOLORVALUE());
            }
        }

        public float ScA => RgbToScRgb(BA);
        public float ScR => RgbToScRgb(BR);
        public float ScG => RgbToScRgb(BG);
        public float ScB => RgbToScRgb(BB);

        public static float RgbToScRgb(byte value)
        {
            var val = value / 255.0f;
            if (val <= 0)
                return 0;

            if (val <= 0.04045)
                return val / 12.92f;

            if (val < 1)
                return (float)Math.Pow((val + 0.055) / 1.055, 2.4);

            return 1;
        }

        public static byte ScRgbToRgb(float value)
        {
            if ((value <= 0))
                return 0;

            if (value <= 0.0031308)
                return (byte)((255 * value * 12.92f) + 0.5f);

            if (value < 1)
                return (byte)((255 * ((1.055f * (float)Math.Pow(value, 1.0 / 2.4)) - 0.055f)) + 0.5f);

            return 255;
        }

        public override string ToString()
        {
#if DEBUG
            return Name;
#else
            return HtmlString;
#endif
        }

        public _D3DCOLORVALUE ChangeAlpha(byte newAlpha) => FromArgb(newAlpha, BR, BG, BB);
        public _D3DCOLORVALUE ChangeAlpha(float newAlpha) => new _D3DCOLORVALUE(newAlpha, r, g, b);
        public float[] ToArray() => new[] { r, g, b, a };
        public override bool Equals(object obj) => (obj is _D3DCOLORVALUE c && Equals(c)) || (obj is D2D_VECTOR_4F v && r == v.x && g == v.y && b == v.z && a == v.w);
        public bool Equals(_D3DCOLORVALUE other) => a == other.a && r == other.r && g == other.g && b == other.b;
        public override int GetHashCode() => a.GetHashCode() ^ r.GetHashCode() ^ g.GetHashCode() ^ b.GetHashCode();
        public static bool operator ==(_D3DCOLORVALUE left, _D3DCOLORVALUE right) => left.Equals(right);
        public static bool operator !=(_D3DCOLORVALUE left, _D3DCOLORVALUE right) => !left.Equals(right);
        public static bool operator ==(D2D_VECTOR_4F left, _D3DCOLORVALUE right) => right.Equals(left);
        public static bool operator !=(D2D_VECTOR_4F left, _D3DCOLORVALUE right) => !right.Equals(left);
        public static bool operator ==(_D3DCOLORVALUE left, D2D_VECTOR_4F right) => left.Equals(right);
        public static bool operator !=(_D3DCOLORVALUE left, D2D_VECTOR_4F right) => !left.Equals(right);
        public static implicit operator D2D_VECTOR_4F(_D3DCOLORVALUE c) => new D2D_VECTOR_4F(c.r, c.g, c.b, c.a);
        public static implicit operator _D3DCOLORVALUE(D2D_VECTOR_4F vc) => new _D3DCOLORVALUE(vc.x, vc.y, vc.z, vc.w);

        private static float ByteToSingle(byte value) => value / 255f;
        private static byte SingleToByte(float value) => (byte)(value * 255);

        public static readonly _D3DCOLORVALUE AliceBlue = new _D3DCOLORVALUE(0xFFF0F8FF);
        public static readonly _D3DCOLORVALUE AntiqueWhite = new _D3DCOLORVALUE(0xFFFAEBD7);
        public static readonly _D3DCOLORVALUE Aqua = new _D3DCOLORVALUE(0xFF00FFFF);
        public static readonly _D3DCOLORVALUE Aquamarine = new _D3DCOLORVALUE(0xFF7FFFD4);
        public static readonly _D3DCOLORVALUE Azure = new _D3DCOLORVALUE(0xFFF0FFFF);
        public static readonly _D3DCOLORVALUE Beige = new _D3DCOLORVALUE(0xFFF5F5DC);
        public static readonly _D3DCOLORVALUE Bisque = new _D3DCOLORVALUE(0xFFFFE4C4);
        public static readonly _D3DCOLORVALUE Black = new _D3DCOLORVALUE(0xFF000000);
        public static readonly _D3DCOLORVALUE BlanchedAlmond = new _D3DCOLORVALUE(0xFFFFEBCD);
        public static readonly _D3DCOLORVALUE Blue = new _D3DCOLORVALUE(0xFF0000FF);
        public static readonly _D3DCOLORVALUE BlueViolet = new _D3DCOLORVALUE(0xFF8A2BE2);
        public static readonly _D3DCOLORVALUE Brown = new _D3DCOLORVALUE(0xFFA52A2A);
        public static readonly _D3DCOLORVALUE BurlyWood = new _D3DCOLORVALUE(0xFFDEB887);
        public static readonly _D3DCOLORVALUE CadetBlue = new _D3DCOLORVALUE(0xFF5F9EA0);
        public static readonly _D3DCOLORVALUE Chartreuse = new _D3DCOLORVALUE(0xFF7FFF00);
        public static readonly _D3DCOLORVALUE Chocolate = new _D3DCOLORVALUE(0xFFD2691E);
        public static readonly _D3DCOLORVALUE Coral = new _D3DCOLORVALUE(0xFFFF7F50);
        public static readonly _D3DCOLORVALUE CornflowerBlue = new _D3DCOLORVALUE(0xFF6495ED);
        public static readonly _D3DCOLORVALUE Cornsilk = new _D3DCOLORVALUE(0xFFFFF8DC);
        public static readonly _D3DCOLORVALUE Crimson = new _D3DCOLORVALUE(0xFFDC143C);
        public static readonly _D3DCOLORVALUE Cyan = new _D3DCOLORVALUE(0xFF00FFFF);
        public static readonly _D3DCOLORVALUE DarkBlue = new _D3DCOLORVALUE(0xFF00008B);
        public static readonly _D3DCOLORVALUE DarkCyan = new _D3DCOLORVALUE(0xFF008B8B);
        public static readonly _D3DCOLORVALUE DarkGoldenrod = new _D3DCOLORVALUE(0xFFB8860B);
        public static readonly _D3DCOLORVALUE DarkGray = new _D3DCOLORVALUE(0xFFA9A9A9);
        public static readonly _D3DCOLORVALUE DarkGreen = new _D3DCOLORVALUE(0xFF006400);
        public static readonly _D3DCOLORVALUE DarkKhaki = new _D3DCOLORVALUE(0xFFBDB76B);
        public static readonly _D3DCOLORVALUE DarkMagenta = new _D3DCOLORVALUE(0xFF8B008B);
        public static readonly _D3DCOLORVALUE DarkOliveGreen = new _D3DCOLORVALUE(0xFF556B2F);
        public static readonly _D3DCOLORVALUE DarkOrange = new _D3DCOLORVALUE(0xFFFF8C00);
        public static readonly _D3DCOLORVALUE DarkOrchid = new _D3DCOLORVALUE(0xFF9932CC);
        public static readonly _D3DCOLORVALUE DarkRed = new _D3DCOLORVALUE(0xFF8B0000);
        public static readonly _D3DCOLORVALUE DarkSalmon = new _D3DCOLORVALUE(0xFFE9967A);
        public static readonly _D3DCOLORVALUE DarkSeaGreen = new _D3DCOLORVALUE(0xFF8FBC8F);
        public static readonly _D3DCOLORVALUE DarkSlateBlue = new _D3DCOLORVALUE(0xFF483D8B);
        public static readonly _D3DCOLORVALUE DarkSlateGray = new _D3DCOLORVALUE(0xFF2F4F4F);
        public static readonly _D3DCOLORVALUE DarkTurquoise = new _D3DCOLORVALUE(0xFF00CED1);
        public static readonly _D3DCOLORVALUE DarkViolet = new _D3DCOLORVALUE(0xFF9400D3);
        public static readonly _D3DCOLORVALUE DeepPink = new _D3DCOLORVALUE(0xFFFF1493);
        public static readonly _D3DCOLORVALUE DeepSkyBlue = new _D3DCOLORVALUE(0xFF00BFFF);
        public static readonly _D3DCOLORVALUE DimGray = new _D3DCOLORVALUE(0xFF696969);
        public static readonly _D3DCOLORVALUE DodgerBlue = new _D3DCOLORVALUE(0xFF1E90FF);
        public static readonly _D3DCOLORVALUE Firebrick = new _D3DCOLORVALUE(0xFFB22222);
        public static readonly _D3DCOLORVALUE FloralWhite = new _D3DCOLORVALUE(0xFFFFFAF0);
        public static readonly _D3DCOLORVALUE ForestGreen = new _D3DCOLORVALUE(0xFF228B22);
        public static readonly _D3DCOLORVALUE Fuchsia = new _D3DCOLORVALUE(0xFFFF00FF);
        public static readonly _D3DCOLORVALUE Gainsboro = new _D3DCOLORVALUE(0xFFDCDCDC);
        public static readonly _D3DCOLORVALUE GhostWhite = new _D3DCOLORVALUE(0xFFF8F8FF);
        public static readonly _D3DCOLORVALUE Gold = new _D3DCOLORVALUE(0xFFFFD700);
        public static readonly _D3DCOLORVALUE Goldenrod = new _D3DCOLORVALUE(0xFFDAA520);
        public static readonly _D3DCOLORVALUE Gray = new _D3DCOLORVALUE(0xFF808080);
        public static readonly _D3DCOLORVALUE Green = new _D3DCOLORVALUE(0xFF008000);
        public static readonly _D3DCOLORVALUE GreenYellow = new _D3DCOLORVALUE(0xFFADFF2F);
        public static readonly _D3DCOLORVALUE Honeydew = new _D3DCOLORVALUE(0xFFF0FFF0);
        public static readonly _D3DCOLORVALUE HotPink = new _D3DCOLORVALUE(0xFFFF69B4);
        public static readonly _D3DCOLORVALUE IndianRed = new _D3DCOLORVALUE(0xFFCD5C5C);
        public static readonly _D3DCOLORVALUE Indigo = new _D3DCOLORVALUE(0xFF4B0082);
        public static readonly _D3DCOLORVALUE Ivory = new _D3DCOLORVALUE(0xFFFFFFF0);
        public static readonly _D3DCOLORVALUE Khaki = new _D3DCOLORVALUE(0xFFF0E68C);
        public static readonly _D3DCOLORVALUE Lavender = new _D3DCOLORVALUE(0xFFE6E6FA);
        public static readonly _D3DCOLORVALUE LavenderBlush = new _D3DCOLORVALUE(0xFFFFF0F5);
        public static readonly _D3DCOLORVALUE LawnGreen = new _D3DCOLORVALUE(0xFF7CFC00);
        public static readonly _D3DCOLORVALUE LemonChiffon = new _D3DCOLORVALUE(0xFFFFFACD);
        public static readonly _D3DCOLORVALUE LightBlue = new _D3DCOLORVALUE(0xFFADD8E6);
        public static readonly _D3DCOLORVALUE LightCoral = new _D3DCOLORVALUE(0xFFF08080);
        public static readonly _D3DCOLORVALUE LightCyan = new _D3DCOLORVALUE(0xFFE0FFFF);
        public static readonly _D3DCOLORVALUE LightGoldenrodYellow = new _D3DCOLORVALUE(0xFFFAFAD2);
        public static readonly _D3DCOLORVALUE LightGray = new _D3DCOLORVALUE(0xFFD3D3D3);
        public static readonly _D3DCOLORVALUE LightGreen = new _D3DCOLORVALUE(0xFF90EE90);
        public static readonly _D3DCOLORVALUE LightPink = new _D3DCOLORVALUE(0xFFFFB6C1);
        public static readonly _D3DCOLORVALUE LightSalmon = new _D3DCOLORVALUE(0xFFFFA07A);
        public static readonly _D3DCOLORVALUE LightSeaGreen = new _D3DCOLORVALUE(0xFF20B2AA);
        public static readonly _D3DCOLORVALUE LightSkyBlue = new _D3DCOLORVALUE(0xFF87CEFA);
        public static readonly _D3DCOLORVALUE LightSlateGray = new _D3DCOLORVALUE(0xFF778899);
        public static readonly _D3DCOLORVALUE LightSteelBlue = new _D3DCOLORVALUE(0xFFB0C4DE);
        public static readonly _D3DCOLORVALUE LightYellow = new _D3DCOLORVALUE(0xFFFFFFE0);
        public static readonly _D3DCOLORVALUE Lime = new _D3DCOLORVALUE(0xFF00FF00);
        public static readonly _D3DCOLORVALUE LimeGreen = new _D3DCOLORVALUE(0xFF32CD32);
        public static readonly _D3DCOLORVALUE Linen = new _D3DCOLORVALUE(0xFFFAF0E6);
        public static readonly _D3DCOLORVALUE Magenta = new _D3DCOLORVALUE(0xFFFF00FF);
        public static readonly _D3DCOLORVALUE Maroon = new _D3DCOLORVALUE(0xFF800000);
        public static readonly _D3DCOLORVALUE MediumAquamarine = new _D3DCOLORVALUE(0xFF66CDAA);
        public static readonly _D3DCOLORVALUE MediumBlue = new _D3DCOLORVALUE(0xFF0000CD);
        public static readonly _D3DCOLORVALUE MediumOrchid = new _D3DCOLORVALUE(0xFFBA55D3);
        public static readonly _D3DCOLORVALUE MediumPurple = new _D3DCOLORVALUE(0xFF9370DB);
        public static readonly _D3DCOLORVALUE MediumSeaGreen = new _D3DCOLORVALUE(0xFF3CB371);
        public static readonly _D3DCOLORVALUE MediumSlateBlue = new _D3DCOLORVALUE(0xFF7B68EE);
        public static readonly _D3DCOLORVALUE MediumSpringGreen = new _D3DCOLORVALUE(0xFF00FA9A);
        public static readonly _D3DCOLORVALUE MediumTurquoise = new _D3DCOLORVALUE(0xFF48D1CC);
        public static readonly _D3DCOLORVALUE MediumVioletRed = new _D3DCOLORVALUE(0xFFC71585);
        public static readonly _D3DCOLORVALUE MidnightBlue = new _D3DCOLORVALUE(0xFF191970);
        public static readonly _D3DCOLORVALUE MintCream = new _D3DCOLORVALUE(0xFFF5FFFA);
        public static readonly _D3DCOLORVALUE MistyRose = new _D3DCOLORVALUE(0xFFFFE4E1);
        public static readonly _D3DCOLORVALUE Moccasin = new _D3DCOLORVALUE(0xFFFFE4B5);
        public static readonly _D3DCOLORVALUE NavajoWhite = new _D3DCOLORVALUE(0xFFFFDEAD);
        public static readonly _D3DCOLORVALUE Navy = new _D3DCOLORVALUE(0xFF000080);
        public static readonly _D3DCOLORVALUE OldLace = new _D3DCOLORVALUE(0xFFFDF5E6);
        public static readonly _D3DCOLORVALUE Olive = new _D3DCOLORVALUE(0xFF808000);
        public static readonly _D3DCOLORVALUE OliveDrab = new _D3DCOLORVALUE(0xFF6B8E23);
        public static readonly _D3DCOLORVALUE Orange = new _D3DCOLORVALUE(0xFFFFA500);
        public static readonly _D3DCOLORVALUE OrangeRed = new _D3DCOLORVALUE(0xFFFF4500);
        public static readonly _D3DCOLORVALUE Orchid = new _D3DCOLORVALUE(0xFFDA70D6);
        public static readonly _D3DCOLORVALUE PaleGoldenrod = new _D3DCOLORVALUE(0xFFEEE8AA);
        public static readonly _D3DCOLORVALUE PaleGreen = new _D3DCOLORVALUE(0xFF98FB98);
        public static readonly _D3DCOLORVALUE PaleTurquoise = new _D3DCOLORVALUE(0xFFAFEEEE);
        public static readonly _D3DCOLORVALUE PaleVioletRed = new _D3DCOLORVALUE(0xFFDB7093);
        public static readonly _D3DCOLORVALUE PapayaWhip = new _D3DCOLORVALUE(0xFFFFEFD5);
        public static readonly _D3DCOLORVALUE PeachPuff = new _D3DCOLORVALUE(0xFFFFDAB9);
        public static readonly _D3DCOLORVALUE Peru = new _D3DCOLORVALUE(0xFFCD853F);
        public static readonly _D3DCOLORVALUE Pink = new _D3DCOLORVALUE(0xFFFFC0CB);
        public static readonly _D3DCOLORVALUE Plum = new _D3DCOLORVALUE(0xFFDDA0DD);
        public static readonly _D3DCOLORVALUE PowderBlue = new _D3DCOLORVALUE(0xFFB0E0E6);
        public static readonly _D3DCOLORVALUE Purple = new _D3DCOLORVALUE(0xFF800080);
        public static readonly _D3DCOLORVALUE Red = new _D3DCOLORVALUE(0xFFFF0000);
        public static readonly _D3DCOLORVALUE RosyBrown = new _D3DCOLORVALUE(0xFFBC8F8F);
        public static readonly _D3DCOLORVALUE RoyalBlue = new _D3DCOLORVALUE(0xFF4169E1);
        public static readonly _D3DCOLORVALUE SaddleBrown = new _D3DCOLORVALUE(0xFF8B4513);
        public static readonly _D3DCOLORVALUE Salmon = new _D3DCOLORVALUE(0xFFFA8072);
        public static readonly _D3DCOLORVALUE SandyBrown = new _D3DCOLORVALUE(0xFFF4A460);
        public static readonly _D3DCOLORVALUE SeaGreen = new _D3DCOLORVALUE(0xFF2E8B57);
        public static readonly _D3DCOLORVALUE SeaShell = new _D3DCOLORVALUE(0xFFFFF5EE);
        public static readonly _D3DCOLORVALUE Sienna = new _D3DCOLORVALUE(0xFFA0522D);
        public static readonly _D3DCOLORVALUE Silver = new _D3DCOLORVALUE(0xFFC0C0C0);
        public static readonly _D3DCOLORVALUE SkyBlue = new _D3DCOLORVALUE(0xFF87CEEB);
        public static readonly _D3DCOLORVALUE SlateBlue = new _D3DCOLORVALUE(0xFF6A5ACD);
        public static readonly _D3DCOLORVALUE SlateGray = new _D3DCOLORVALUE(0xFF708090);
        public static readonly _D3DCOLORVALUE Snow = new _D3DCOLORVALUE(0xFFFFFAFA);
        public static readonly _D3DCOLORVALUE SpringGreen = new _D3DCOLORVALUE(0xFF00FF7F);
        public static readonly _D3DCOLORVALUE SteelBlue = new _D3DCOLORVALUE(0xFF4682B4);
        public static readonly _D3DCOLORVALUE Tan = new _D3DCOLORVALUE(0xFFD2B48C);
        public static readonly _D3DCOLORVALUE Teal = new _D3DCOLORVALUE(0xFF008080);
        public static readonly _D3DCOLORVALUE Thistle = new _D3DCOLORVALUE(0xFFD8BFD8);
        public static readonly _D3DCOLORVALUE Tomato = new _D3DCOLORVALUE(0xFFFF6347);
        public static readonly _D3DCOLORVALUE Transparent = new _D3DCOLORVALUE(0x00FFFFFF);
        public static readonly _D3DCOLORVALUE Turquoise = new _D3DCOLORVALUE(0xFF40E0D0);
        public static readonly _D3DCOLORVALUE Violet = new _D3DCOLORVALUE(0xFFEE82EE);
        public static readonly _D3DCOLORVALUE Wheat = new _D3DCOLORVALUE(0xFFF5DEB3);
        public static readonly _D3DCOLORVALUE White = new _D3DCOLORVALUE(0xFFFFFFFF);
        public static readonly _D3DCOLORVALUE WhiteSmoke = new _D3DCOLORVALUE(0xFFF5F5F5);
        public static readonly _D3DCOLORVALUE Yellow = new _D3DCOLORVALUE(0xFFFFFF00);
        public static readonly _D3DCOLORVALUE YellowGreen = new _D3DCOLORVALUE(0xFF9ACD32);
    }

#pragma warning disable IDE1006 // Naming Styles
    public class _D3DCOLORVALUEConverter : TypeConverter
#pragma warning restore IDE1006 // Naming Styles
    {
        public override bool CanConvertFrom(ITypeDescriptorContext td, Type t) => t == typeof(string);
        public override object ConvertFrom(ITypeDescriptorContext td, CultureInfo ci, object value)
        {
            if (value is string s)
                return _D3DCOLORVALUE.FromName(s);

            return null;
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string))
                return ((_D3DCOLORVALUE)value).Name;

            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
