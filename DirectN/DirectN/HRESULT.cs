using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct HRESULT : IEquatable<HRESULT>, IFormattable
    {
        private static readonly ConcurrentDictionary<int, string> _names = new ConcurrentDictionary<int, string>();

        public HRESULT(int value)
        {
            Value = value;
        }

        public HRESULT(uint value)
            : this((int)value)
        {
        }

        public HRESULT(HRESULTS value)
            : this((int)value)
        {
        }

        public int Value { get; }
        public uint UValue => (uint)Value;
        public string Name => ToString("n", null);
        public bool IsError => Value < 0;
        public bool IsSuccess => Value >= 0;
        public bool IsOk => Value == (int)HRESULTS.S_OK;
        public bool IsFalse => Value == (int)HRESULTS.S_FALSE;

        public void ThrowOnError(bool throwOnError = true)
        {
            if (!throwOnError)
                return;

            if (Value < 0)
                throw new Win32Exception(Value);
        }

        public override bool Equals(object obj) => Value.Equals(obj);
        public override int GetHashCode() => Value.GetHashCode();
        public bool Equals(HRESULT other) => Value.Equals(other.Value);

        public override string ToString() => ToString(null, null);
        public string ToString(string format, IFormatProvider formatProvider)
        {
            switch (format?.ToUpperInvariant())
            {
                case "I":
                    return Value.ToString(formatProvider);

                case "U":
                    return UValue.ToString(formatProvider);

                case "N":
                    if (!_names.TryGetValue(Value, out string text))
                    {
                        var value = Value;
                        text = typeof(HRESULTS).GetFields(BindingFlags.Static | BindingFlags.Public).FirstOrDefault(f => ((int)(HRESULTS)f.GetValue(null)) == value)?.Name;
                        _names[Value] = text;
                    }
                    return text;

                case "X":
                    return "0x" + Value.ToString("X8", formatProvider);

                default: // f
                    string name = ToString("n", formatProvider);
                    if (name != null)
                        return name + " (0x" + Value.ToString("X8", formatProvider) + ")";

                    return "0x" + Value.ToString("X8", formatProvider);
            }
        }

        public static bool operator ==(HRESULT left, HRESULT right) => left.Value == right.Value;
        public static bool operator !=(HRESULT left, HRESULT right) => left.Value != right.Value;

        public static implicit operator HRESULT(int value) => new HRESULT(value);
        public static implicit operator HRESULT(uint value) => new HRESULT(value);
        public static implicit operator HRESULT(HRESULTS value) => new HRESULT(value);

        public static explicit operator uint(HRESULT hr) => hr.UValue;
        public static explicit operator int(HRESULT hr) => hr.Value;
        public static explicit operator HRESULTS(HRESULT hr) => (HRESULTS)hr.UValue;

        public uint ToUInt32() => UValue;
        public int ToInt32() => Value;
        public HRESULTS ToHRESULTS() => (HRESULTS)UValue;

        public static HRESULT FromHRESULTS(HRESULTS result) => new HRESULT(result);
        public static HRESULT FromUInt32(uint value) => new HRESULT(value);
        public static HRESULT FromInt32(int value) => new HRESULT(value);
    }
}
