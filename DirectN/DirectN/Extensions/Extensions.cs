﻿using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace DirectN
{
    public static class Extensions
    {
        private static readonly ConcurrentDictionary<Type, ConcurrentDictionary<Guid, string>> _guidsNames = new ConcurrentDictionary<Type, ConcurrentDictionary<Guid, string>>();

        public static void CopyTo(this IntPtr source, IntPtr destination, int length) => PropVariant.CopyMemory(destination, source, (IntPtr)length);
        public static void CopyTo(this IntPtr source, IntPtr destination, long length) => PropVariant.CopyMemory(destination, source, (IntPtr)length);
        public static void CopyTo(this IntPtr source, IntPtr destination, IntPtr length) => PropVariant.CopyMemory(destination, source, length);
        public static void CopyTo<T>(this T[] source, IntPtr destination)
        {
            if (source == null || source.Length == 0)
                return;

            source.WithArrayPointer(p => p.CopyTo(destination, source.Length * Marshal.SizeOf<T>()));
        }

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

        public static DateTimeOffset ToDateTimeOffset(this System.Runtime.InteropServices.ComTypes.FILETIME fileTime)
        {
            var ft = (((long)fileTime.dwHighDateTime) << 32) + fileTime.dwLowDateTime;
            return DateTimeOffset.FromFileTime(ft);
        }

        public static long CopyTo(this Stream input, Stream output, long count = long.MaxValue, int bufferSize = 0x14000)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (output == null)
                throw new ArgumentNullException(nameof(output));

            if (count <= 0)
                throw new ArgumentException(null, nameof(count));

            if (bufferSize <= 0)
                throw new ArgumentException(null, nameof(bufferSize));

            if (count < bufferSize)
            {
                bufferSize = (int)count;
            }

            var bytes = new byte[bufferSize];
            var total = 0;
            do
            {
                var max = (int)Math.Min(count - total, bytes.Length);
                var read = input.Read(bytes, 0, max);
                if (read == 0)
                    break;

                output.Write(bytes, 0, read);
                total += read;
                if (total == count)
                    break;
            }
            while (true);
            return total;
        }

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

        public static T[] ToArray<T>(this IEnumerable<IComObject<T>> enumerable)
        {
            if (enumerable == null)
                return null;

            return enumerable?.Select(e => e != null ? e.Object : default)?.ToArray();
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

            var t = text.Trim();
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

        public static void Dispose(this IEnumerable disposables, bool throwOnError = false)
        {
            if (disposables == null)
                return;

            if (throwOnError)
            {
                foreach (var disposable in disposables.OfType<IDisposable>())
                {
                    disposable?.Dispose();
                }
            }
            else
            {
                foreach (var disposable in disposables.OfType<IDisposable>())
                {
                    try
                    {
                        disposable?.Dispose();
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
        }

        public static void WithDispose(this IEnumerable disposables, Action action, bool throwOnError = false)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (disposables == null)
            {
                action();
                return;
            }

            try
            {
                action();
            }
            finally
            {
                if (throwOnError)
                {
                    foreach (var disposable in disposables.OfType<IDisposable>())
                    {
                        disposable?.Dispose();
                    }
                }
                else
                {
                    foreach (var disposable in disposables.OfType<IDisposable>())
                    {
                        try
                        {
                            disposable?.Dispose();
                        }
                        catch
                        {
                            // continue
                        }
                    }
                }
            }
        }

        public static T WithDispose<T>(this IEnumerable disposables, Func<T> func, bool throwOnError = false)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            if (disposables == null)
                return func();

            try
            {
                return func();
            }
            finally
            {
                if (throwOnError)
                {
                    foreach (var disposable in disposables.OfType<IDisposable>())
                    {
                        disposable?.Dispose();
                    }
                }
                else
                {
                    foreach (var disposable in disposables.OfType<IDisposable>())
                    {
                        try
                        {
                            disposable?.Dispose();
                        }
                        catch
                        {
                            // continue
                        }
                    }
                }
            }
        }

        public static void WithDispose(this IDisposable disposable, Action action, bool throwOnError = false)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (disposable == null)
            {
                action();
                return;
            }

            try
            {
                action();
            }
            finally
            {
                if (throwOnError)
                {
                    disposable.Dispose();
                }
                else
                {
                    try
                    {
                        disposable.Dispose();
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
        }

        public static T WithDispose<T>(this IDisposable disposable, Func<T> func, bool throwOnError = false)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            if (disposable == null)
                return func();

            try
            {
                return func();
            }
            finally
            {
                if (throwOnError)
                {
                    disposable.Dispose();
                }
                else
                {
                    try
                    {
                        disposable.Dispose();
                    }
                    catch
                    {
                        // continue
                    }
                }
            }
        }

        public static void WithArrayPointer(this Array array, Action<IntPtr> action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (array == null)
            {
                action(IntPtr.Zero);
                return;
            }

            var ghc = GCHandle.Alloc(array, GCHandleType.Pinned);
            try
            {
                var ptr = ghc.AddrOfPinnedObject();
                action(ptr);
            }
            finally
            {
                ghc.Free();
            }
        }

        public static T WithArrayPointer<T>(this Array array, Func<IntPtr, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            if (array == null)
                return func(IntPtr.Zero);

            var ghc = GCHandle.Alloc(array, GCHandleType.Pinned);
            try
            {
                var ptr = ghc.AddrOfPinnedObject();
                return func(ptr);
            }
            finally
            {
                ghc.Free();
            }
        }

        public static void Dispose(this IEnumerable<IDisposable> disposables, IEnumerable<IDisposable> excluded = null, bool throwOnError = false)
        {
            if (disposables == null)
                return;

            var hash = excluded != null ? new HashSet<IDisposable>(excluded) : null;
            foreach (var disposable in disposables)
            {
                if (disposable == null)
                    continue;

                if (hash?.Contains(disposable) == true)
                    continue;

                if (throwOnError)
                {
                    disposable.Dispose();
                }
                else
                {
                    try
                    {
                        disposable.Dispose();
                    }
                    catch
                    {
                        // continue;
                    }
                }
            }
        }

        public static void FinalDispose<T>(this IComObject<T> comObject) => ComObject.FinalDispose(comObject as ComObject);
        public static void WithComPointer<TCom>(this IComObject<TCom> comObject, Action<IntPtr> action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            if (comObject == null || comObject.IsDisposed)
            {
                action(IntPtr.Zero);
                return;
            }

            var ptr = Marshal.GetComInterfaceForObject(comObject.Object, typeof(TCom));
            try
            {
                action(ptr);
            }
            finally
            {
                Marshal.Release(ptr);
            }
        }

        public static T WithComPointer<TCom, T>(this IComObject<TCom> comObject, Func<IntPtr, T> func)
        {
            if (func == null)
                throw new ArgumentNullException(nameof(func));

            if (comObject == null || comObject.IsDisposed)
                return func(IntPtr.Zero);

            var ptr = Marshal.GetComInterfaceForObject(comObject.Object, typeof(TCom));
            try
            {
                return func(ptr);
            }
            finally
            {
                Marshal.Release(ptr);
            }
        }

        public static string GetGuidName(this Type type, Guid guid)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            if (TryGetGuidName(type, guid, out var name))
                return name;

            return guid.ToString("B");
        }

        public static bool TryGetGuidName(this Type type, Guid guid, out string name)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            if (!_guidsNames.TryGetValue(type, out var dic))
            {
                dic = new ConcurrentDictionary<Guid, string>();
                foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly))
                {
                    dic[(Guid)field.GetValue(null)] = field.Name;
                }
                _guidsNames[type] = dic;
            }

            if (dic.TryGetValue(guid, out name))
                return true;

            name = null;
            return false;
        }
    }
}
