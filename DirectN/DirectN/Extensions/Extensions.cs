using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace DirectN
{
    public static class Extensions
    {
        public static bool IsValid(this float value) => !float.IsNaN(value);
        public static bool IsInvalid(this float value) => float.IsNaN(value);
        public static bool IsSet(this float value) => IsValid(value) && !float.IsInfinity(value);
        public static bool IsNotSet(this float value) => IsInvalid(value) || float.IsInfinity(value);
        public static bool IsMinOrMax(this float value) => value == float.MaxValue || value == float.MinValue;
        public static bool IsMax(this float value) => value == float.MaxValue;
        public static bool IsMin(this float value) => value == float.MinValue;
        public static int SignedLOWORD(this IntPtr value) => SignedLOWORD((int)(long)value);
        public static int SignedLOWORD(this int value) => (short)(value & 0xffff);
        public static int SignedHIWORD(this IntPtr value) => SignedHIWORD((int)(long)value);
        public static int SignedHIWORD(this int value) => (short)((value >> 0x10) & 0xffff);
        public static int HIWORD(this int value) => (value >> 0x10) & 0xffff;
        public static int HIWORD(this IntPtr value) => HIWORD((int)(long)value);
        public static int LOWORD(this int value) => value & 0xffff;
        public static int LOWORD(this IntPtr value) => LOWORD((int)(long)value);
        public static float ToZero(this float value) => float.IsNaN(value) ? 0 : value;

        public static float NextFloat(this Random random) => (float)random?.NextDouble();
        public static byte NextByte(this Random random, byte minValue = 0, byte maxValue = 255) => (byte)random?.Next(minValue, maxValue);

        public static bool IsValid(this Vector2 value) => value.X.IsValid() && value.Y.IsValid();
        public static bool IsInvalid(this Vector2 value) => value.X.IsInvalid() || value.Y.IsInvalid();
        public static bool IsSet(this Vector2 value) => value.X.IsSet() && value.Y.IsSet();
        public static bool IsNotSet(this Vector2 value) => value.X.IsNotSet() || value.Y.IsNotSet();
        public static bool IsNotZero(this Vector2 value) => IsValid(value) && value.X != 0 && value.Y != 0;
        public static bool IsZero(this Vector2 value) => IsValid(value) && value.X == 0 && value.Y == 0;

        public static float Ceiling(this float value) => (float)Math.Ceiling(value);
        public static int CeilingI(this float value) => Math.Ceiling(value).ToInt32();
        public static uint CeilingU(this float value) => Math.Ceiling(value).ToUInt32();
        public static float Floor(this float value) => (float)Math.Floor(value);
        public static int FloorI(this float value) => Math.Floor(value).ToInt32();
        public static uint FloorU(this float value) => Math.Floor(value).ToUInt32();
        public static float Round(this float value) => (float)Math.Round(value);
        public static int RoundI(this float value) => Math.Round(value).ToInt32();
        public static uint RoundU(this float value) => Math.Round(value).ToUInt32();

        public static double Ceiling(this double value) => Math.Ceiling(value);
        public static int CeilingI(this double value) => Math.Ceiling(value).ToInt32();
        public static uint CeilingU(this double value) => Math.Ceiling(value).ToUInt32();
        public static double Floor(this double value) => Math.Floor(value);
        public static int FloorI(this double value) => Math.Floor(value).ToInt32();
        public static uint FloorU(this double value) => Math.Floor(value).ToUInt32();
        public static double Round(this double value) => Math.Round(value);
        public static int RoundI(this double value) => Math.Round(value).ToInt32();
        public static uint RoundU(this double value) => Math.Round(value).ToUInt32();

        public static float Clamp(this float value, float min, float max = float.MaxValue) => value < min ? min : value > max ? max : value;
        public static byte Clamp(this byte value, byte min, byte max = byte.MaxValue) => value < min ? min : value > max ? max : value;
        public static int Clamp(this int value, int min, int max = int.MaxValue) => value < min ? min : value > max ? max : value;
        public static uint Clamp(this uint value, uint min, uint max = uint.MaxValue) => value < min ? min : value > max ? max : value;
        public static long Clamp(this long value, long min, long max = long.MaxValue) => value < min ? min : value > max ? max : value;
        public static ulong Clamp(this ulong value, ulong min, ulong max = ulong.MaxValue) => value < min ? min : value > max ? max : value;

        public static float ClampMinMax(this float value)
        {
            if (float.IsPositiveInfinity(value))
                return float.MaxValue;

            if (float.IsNegativeInfinity(value))
                return float.MinValue;

            return value;
        }

        public static uint ToUInt32(this float value)
        {
            if (float.IsNaN(value))
                throw new OverflowException();

            if (value <= 0)
                return 0;

            if (value >= uint.MaxValue)
                return uint.MaxValue;

            return (uint)value;
        }

        public static int ToInt32(this float value)
        {
            if (float.IsNaN(value))
                throw new OverflowException();

            if (value <= int.MinValue)
                return int.MinValue;

            if (value >= int.MaxValue)
                return int.MaxValue;

            return (int)value;
        }

        public static uint ToUInt32(this double value)
        {
            if (double.IsNaN(value))
                throw new OverflowException();

            if (value <= 0)
                return 0;

            if (value >= uint.MaxValue)
                return uint.MaxValue;

            return (uint)value;
        }

        public static int ToInt32(this double value)
        {
            if (double.IsNaN(value))
                throw new OverflowException();

            if (value <= int.MinValue)
                return int.MinValue;

            if (value >= int.MaxValue)
                return int.MaxValue;

            return (int)value;
        }

        public static bool IgnoreCase(this StringComparison comparison) => comparison == StringComparison.CurrentCultureIgnoreCase ||
            comparison == StringComparison.InvariantCultureIgnoreCase ||
            comparison == StringComparison.OrdinalIgnoreCase;

        public static bool IgnoreCase(this StringComparer comparer) => comparer == StringComparer.CurrentCultureIgnoreCase ||
            comparer == StringComparer.InvariantCultureIgnoreCase ||
            comparer == StringComparer.OrdinalIgnoreCase;

        public static int SizeOf(this Array array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));

            return array.Length * Marshal.SizeOf(array.GetType().GetElementType());
        }

        public static byte[] ToBytes<T>(this T structure) where T : struct
        {
            var size = Marshal.SizeOf<T>();
            var ptr = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.StructureToPtr(structure, ptr, false);
                var bytes = new byte[size];
                Marshal.Copy(ptr, bytes, 0, bytes.Length);
                return bytes;
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        public static T ToStructure<T>(this byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            var size = Marshal.SizeOf<T>();
            if (size != bytes.Length)
                throw new ArgumentException(null, nameof(bytes));

            var ptr = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.Copy(bytes, 0, ptr, size);
                return Marshal.PtrToStructure<T>(ptr);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }
        }

        public static int GetEnumMaxPower(Type enumType)
        {
            if (enumType == null)
                throw new ArgumentNullException(nameof(enumType));

            if (!enumType.IsEnum)
                throw new ArgumentException(null, nameof(enumType));

            var utype = Enum.GetUnderlyingType(enumType);
            return GetEnumUnderlyingTypeMaxPower(utype);
        }

        public static int GetEnumUnderlyingTypeMaxPower(Type underlyingType)
        {
            if (underlyingType == null)
                throw new ArgumentNullException(nameof(underlyingType));

            if (underlyingType == typeof(long) || underlyingType == typeof(ulong))
                return 64;

            if (underlyingType == typeof(int) || underlyingType == typeof(uint))
                return 32;

            if (underlyingType == typeof(short) || underlyingType == typeof(ushort))
                return 16;

            if (underlyingType == typeof(byte) || underlyingType == typeof(sbyte))
                return 8;

            throw new ArgumentException(null, nameof(underlyingType));
        }

        public static T GetAttribute<T>(this MemberDescriptor descriptor) where T : Attribute
        {
            if (descriptor == null)
                return null;

            return GetAttribute<T>(descriptor.Attributes);
        }

        public static T GetAttribute<T>(this AttributeCollection attributes) where T : Attribute
        {
            if (attributes == null)
                return null;

            foreach (var att in attributes)
            {
                if (typeof(T).IsAssignableFrom(att.GetType()))
                    return (T)att;
            }
            return null;
        }

        public static Lazy<T> ResetLazy<T>(this Lazy<T> disposable, Func<T> valueFactory = null, bool isThreadSafe = true) where T : IDisposable
        {
            if (disposable != null && disposable.IsValueCreated)
            {
                disposable.Value?.Dispose();
            }
            return valueFactory != null ? new Lazy<T>(valueFactory, isThreadSafe) : null;
        }

        public static string GetAllMessages(this Exception exception) => GetAllMessages(exception, Environment.NewLine);
        public static string GetAllMessages(this Exception exception, string separator)
        {
            if (exception == null)
                return null;

            var sb = new StringBuilder();
            AppendMessages(sb, exception, separator);
            return sb.ToString().Replace("..", ".");
        }

        private static void AppendMessages(StringBuilder sb, Exception e, string separator)
        {
            if (e == null)
                return;

            // this one is not interesting...
            if (!(e is TargetInvocationException))
            {
                if (sb.Length > 0)
                {
                    sb.Append(separator);
                }
                sb.Append(e.Message);
            }
            AppendMessages(sb, e.InnerException, separator);
        }

        public static string GetInterestingExceptionMessage(this Exception exception) => GetInterestingException(exception)?.Message;
        public static Exception GetInterestingException(this Exception exception)
        {
            if (exception is TargetInvocationException tie && tie.InnerException != null)
                return GetInterestingException(tie.InnerException);

            return exception;
        }

        public static void AddRangeOverwrite<TKey, TValue>(this IDictionary<TKey, TValue> dic, IEnumerable<KeyValuePair<TKey, TValue>> enumerable)
        {
            if (dic == null || enumerable == null)
                return;

            foreach (var kv in enumerable)
            {
                dic[kv.Key] = kv.Value;
            }
        }

        public static void AddRange<T>(this ICollection<T> collection, IEnumerable<T> enumerable)
        {
            if (collection == null || enumerable == null)
                return;

            foreach (var item in enumerable)
            {
                collection.Add(item);
            }
        }

        public static T[] ToArrayNullify<T>(this IEnumerable<IComObject<T>> enumerable)
        {
            if (enumerable == null)
                return null;

            return enumerable?.Where(e => e != null && e.Object != null)?.Select(e => e.Object)?.ToArray();
        }

        public static T[] ToArrayNullify<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
                return null;

            return enumerable?.Where(e => e != null)?.ToArray();
        }

        public static T[] ToArrayOrEmpty<T>(this ICollection<T> collection, bool allowsNull = false)
        {
            if (collection.IsEmpty())
            {
                if (allowsNull)
                    return null;

                return Array.Empty<T>();
            }

            return collection.ToArray();
        }

        public static string CapitalizeFirst(this string thisString, CultureInfo culture = null)
        {
            if (string.IsNullOrEmpty(thisString))
                return null;

            if (culture == null)
                return char.ToUpper(thisString[0]) + thisString.Substring(1);

            return char.ToUpper(thisString[0], culture) + thisString.Substring(1);
        }

        public static bool EqualsIgnoreCase(this string thisString, string text) => EqualsIgnoreCase(thisString, text, false);
        public static bool EqualsIgnoreCase(this string thisString, string text, bool trim)
        {
            if (trim)
            {
                thisString = thisString.Nullify();
                text = text.Nullify();
            }

            if (thisString == null)
                return text == null;

            if (text == null)
                return false;

            if (thisString.Length != text.Length)
                return false;

            return string.Compare(thisString, text, StringComparison.OrdinalIgnoreCase) == 0;
        }

        public static string Nullify(this string text)
        {
            if (text == null)
                return null;

            if (string.IsNullOrWhiteSpace(text))
                return null;

            string t = text.Trim();
            return t.Length == 0 ? null : t;
        }

        public static bool IsEmpty(this Array array) => array == null || array.Length == 0;
        public static bool IsEmpty(this IEnumerable enumerable)
        {
            if (enumerable == null)
                return true;

            var enumerator = enumerable.GetEnumerator();
            if (enumerator == null)
                return true;

            var next = enumerator.MoveNext();
            if (enumerator is IDisposable disp)
            {
                disp.Dispose();
            }
            return !next;
        }

        // to disambiguate callers between IsEmpty(this Array array) and IsEmpty<T>(this IEnumerable<T> enumerable)
        public static bool IsEmpty<T>(this T[] enumerable)
        {
            if (enumerable == null)
                return true;

            return !enumerable.Any();
        }

        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            if (enumerable == null)
                return true;

            return !enumerable.Any();
        }

        public static int IndexOf<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            if (source == null)
                return -1;

            var index = 0;
            foreach (var item in source)
            {
                if (predicate(item))
                    return index;

                index++;
            }
            return -1;
        }

        // we don't want unspecified datetimes
        public static bool IsValid(this DateTime dt) => dt != DateTime.MinValue && dt != DateTime.MaxValue && dt.Kind != DateTimeKind.Unspecified;
        public static bool IsValid(this DateTime? dt) => dt.HasValue && IsValid(dt.Value);

        public static void FinalDispose<T>(this IComObject<T> comObject) => ComObject.FinalDispose(comObject as ComObject);
    }
}
