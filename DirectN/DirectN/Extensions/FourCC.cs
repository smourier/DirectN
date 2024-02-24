using System;
using System.Globalization;
using System.Linq;

namespace DirectN
{
    // https://docs.microsoft.com/en-us/windows/desktop/medfound/video-fourccs
    // https://docs.microsoft.com/en-us/windows/desktop/medfound/video-subtype-guids
    public struct FourCC : IEquatable<FourCC>, IFormattable
    {
        public const string Postfix = "0000-0010-8000-00aa00389b71";
        public static readonly FourCC Empty = new FourCC(0);

        private readonly uint _value;

        public FourCC(Guid guid)
        {
            var s = guid.ToString();
            if (!s.EndsWith(Postfix))
                throw new ArgumentNullException(nameof(guid));

            var bytes = guid.ToByteArray();
            if (bytes.Take(4).Any(b => b < 32 || b > 127))
                throw new ArgumentNullException(nameof(guid));

            var fourCC = new string(bytes.Take(4).Select(b => (char)b).ToArray());
            _value = ((uint)fourCC[3]) << 24 | ((uint)fourCC[2]) << 16 | ((uint)fourCC[1]) << 8 | fourCC[0];
        }

        public FourCC(string fourCC)
        {
            if (fourCC == null)
                throw new ArgumentNullException(nameof(fourCC));

            if (fourCC.Length != 4)
                throw new ArgumentException(null, nameof(fourCC));

            _value = ((uint)fourCC[3]) << 24 | ((uint)fourCC[2]) << 16 | ((uint)fourCC[1]) << 8 | fourCC[0];
        }

        public FourCC(char byte1, char byte2, char byte3, char byte4)
        {
            _value = ((uint)byte4) << 24 | ((uint)byte3) << 16 | ((uint)byte2) << 8 | byte1;
        }

        public FourCC(uint fourCC)
        {
            _value = fourCC;
        }

        public FourCC(int fourCC)
        {
            _value = unchecked((uint)fourCC);
        }

        public override int GetHashCode() => (int)_value;
        public bool Equals(FourCC other) => _value == other._value;
        public override bool Equals(object obj)
        {
            if (obj is FourCC fcc)
                return Equals(fcc);

            return false;
        }

        public Guid ToGuid() => new Guid(ToString("I", null) + "-" + Postfix);

        public static bool IsFourCC(Guid guid)
        {
            var s = guid.ToString();
            if (!s.EndsWith(Postfix))
                return false;

            var bytes = guid.ToByteArray();
            return !bytes.Take(4).Any(b => b < 32 || b > 127);
        }

        public static string ToString(Guid guid)
        {
            var s = guid.ToString();
            if (!s.EndsWith(Postfix))
                return s;

            var bytes = guid.ToByteArray();
            if (bytes.Take(4).Any(b => b < 32 || b > 127))
                return s;

            return new string(bytes.Take(4).Select(b => (char)b).ToArray());
        }

        public override string ToString() => string.Format("{0}", new string(new[]
                                  {
                                      (char) (_value & 0xFF),
                                      (char) ((_value >> 8) & 0xFF),
                                      (char) ((_value >> 16) & 0xFF),
                                      (char) ((_value >> 24) & 0xFF),
                                  }));

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "G";
            }

            formatProvider = formatProvider ?? CultureInfo.CurrentCulture;

            switch (format.ToUpperInvariant())
            {
                case "G":
                    return ToString();

                case "I":
                    return _value.ToString("X08", formatProvider);

                default:
                    return _value.ToString(format, formatProvider);
            }
        }

        public static bool operator ==(FourCC left, FourCC right) => left.Equals(right);
        public static bool operator !=(FourCC left, FourCC right) => !left.Equals(right);
        public static implicit operator uint(FourCC fcc) => fcc._value;
        public static implicit operator int(FourCC fcc) => unchecked((int)fcc._value);
        public static implicit operator FourCC(uint fcc) => new FourCC(fcc);
        public static implicit operator FourCC(int fcc) => new FourCC(fcc);
        public static implicit operator string(FourCC fcc) => fcc.ToString();
        public static implicit operator FourCC(string fcc) => new FourCC(fcc);
    }
}
