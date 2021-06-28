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

        public int ThrowOnError(bool throwOnError = true)
        {
            if (!throwOnError)
                return Value;

            var exception = GetException();
            if (exception != null)
                throw exception;

            return Value;
        }

        public Exception GetException()
        {
            if (Value == (int)HRESULTS.DISP_E_EXCEPTION)
            {
                var error = ComError.GetError();
                if (error != null)
                    return error;
            }

            if (Value < 0)
                return new Win32Exception(Value);

            return null;
        }

        public override bool Equals(object obj) => Value.Equals(obj);
        public override int GetHashCode() => Value.GetHashCode();
        public bool Equals(HRESULT other) => Value.Equals(other.Value);

        public override string ToString() => ToString(null, null);
        public string ToString(string format, IFormatProvider formatProvider)
        {
#pragma warning disable CA1308 // Normalize strings to uppercase
            switch (format?.ToLowerInvariant())
#pragma warning restore CA1308 // Normalize strings to uppercase
            {
                case "i":
                    return Value.ToString();

                case "u":
                    return UValue.ToString();

                case "n":
                    if (!_names.TryGetValue(Value, out string text))
                    {
                        var value = Value;
                        text = typeof(HRESULTS).GetFields(BindingFlags.Static | BindingFlags.Public).FirstOrDefault(f => ((int)(HRESULTS)f.GetValue(null)) == value)?.Name;
                        _names[Value] = text;
                    }
                    return text;

                case "x":
                    return "0x" + Value.ToString("X8");

                default: // f
                    string name = ToString("n", formatProvider);
                    if (name != null)
                        return name + " (0x" + Value.ToString("X8") + ")";

                    return "0x" + Value.ToString("X8");
            }
        }

        public static bool operator ==(HRESULT left, HRESULT right) => left.Value == right.Value;
        public static bool operator !=(HRESULT left, HRESULT right) => left.Value != right.Value;

        public static implicit operator HRESULT(int value) => new HRESULT(value);
        public static implicit operator HRESULT(uint result) => new HRESULT(result);
        public static implicit operator HRESULT(HRESULTS result) => new HRESULT(result);

        public static explicit operator uint(HRESULT hr) => hr.UValue;
        public static explicit operator int(HRESULT hr) => hr.Value;
        public static explicit operator HRESULTS(HRESULT hr) => (HRESULTS)hr.UValue;
    }
}
