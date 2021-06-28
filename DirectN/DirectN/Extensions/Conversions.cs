using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace DirectN
{
    public static class Conversions
    {
        private static readonly char[] _enumSeparators = new char[] { ',', ';', '+', '|', ' ' };
        private static readonly Regex _decodeUnicode = new Regex(@"\\u(?<v>[a-zA-Z0-9]{4})", RegexOptions.Compiled);
        private static readonly string[] _dateFormatsUtc = { "yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'", "yyyy'-'MM'-'dd'T'HH':'mm'Z'", "yyyyMMdd'T'HH':'mm':'ss'Z'" };

        public static string EncodeUnicode(string text)
        {
            if (text == null)
                return null;

            var sb = new StringBuilder(text.Length);
            foreach (char c in text)
            {
                if (c > 127)
                {
                    var encodedValue = "\\u" + ((int)c).ToString("x4");
                    _ = sb.Append(encodedValue);
                }
                else
                {
                    _ = sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static string DecodeUnicode(string text) => text != null ? _decodeUnicode.Replace(text, m => ((char)int.Parse(m.Groups["v"].Value, NumberStyles.HexNumber)).ToString()) : null;

        public static bool IsFlagsEnum(Type enumType)
        {
            if (enumType == null)
                throw new ArgumentNullException(nameof(enumType));

            if (!enumType.IsEnum)
                throw new ArgumentException(null, nameof(enumType));

            return enumType.IsDefined(typeof(FlagsAttribute), true);
        }

        public static T CoerceToEnum<T>(object input) => (T)CoerceToEnum(typeof(T), input);
        public static object CoerceToEnum(Type enumType, object input)
        {
            if (enumType == null)
                throw new ArgumentNullException(nameof(enumType));

            if (!enumType.IsEnum)
                throw new ArgumentException(null, nameof(enumType));

            if (!TryChangeType(input, enumType, out object result))
                return Activator.CreateInstance(enumType);

            // validate
            var s = result.ToString();
            if (!char.IsDigit(s[0]) && s[0] != '-')
                return result;

            if (!IsFlagsEnum(enumType))
                return Activator.CreateInstance(enumType);

            var names = Enum.GetNames(enumType);
            if (names.Length == 0) // nothing defined...
                return Activator.CreateInstance(enumType);

            var values = Enum.GetValues(enumType);
            var tc = Type.GetTypeCode(result.GetType());
            if (tc == TypeCode.Int32 || tc == TypeCode.Int16 || tc == TypeCode.Int64 || tc == TypeCode.SByte)
            {
                long lvalue = 0;
                var l = long.Parse(s);
                for (var i = 0; i < names.Length; i++)
                {
                    if (TryChangeType(values.GetValue(i), out long vl) && vl != 0 && (l & vl) == vl)
                    {
                        lvalue |= vl;
                    }
                }
                return ChangeType(lvalue, enumType);
            }

            ulong ulvalue = 0;
            var ul = ulong.Parse(s);
            for (var i = 0; i < names.Length; i++)
            {
                if (TryChangeType(values.GetValue(i), out ulong vul) && vul != 0 && (ul & vul) == vul)
                {
                    ulvalue |= vul;
                }
            }
            return ChangeType(ulvalue, enumType);
        }

        public static bool TryCoerceToEnum<T>(object input, out object value) => TryCoerceToEnum(typeof(T), input, out value);
        public static bool TryCoerceToEnum(Type enumType, object input, out object value)
        {
            if (enumType == null)
                throw new ArgumentNullException(nameof(enumType));

            if (!enumType.IsEnum)
                throw new ArgumentException(null, nameof(enumType));

            if (!TryChangeType(input, enumType, out object result))
            {
                value = Activator.CreateInstance(enumType);
                return false;
            }

            // validate
            var s = result.ToString();
            if (!char.IsDigit(s[0]) && s[0] != '-')
            {
                value = result;
                return true;
            }

            value = Activator.CreateInstance(enumType);
            return false;
        }

        public static string Decamelize(string text) => Decamelize(text, DecamelizeOptions.Default);
        public static string Decamelize(string text, DecamelizeOptions options)
        {
            // input: a string like loadByWhateverStuff
            // output: a string like Load By Whatever Stuff
            // BBKing -> BBKing
            // BBOKing -> BboKing
            // LoadBy25Years -> Load By 25 Years
            // SoftFluent.PetShop -> Soft Fluent. Pet Shop
            // Data2_FileName -> Data 2 File Name
            // _WhatIs -> _What is
            // __WhatIs -> __What is
            // __What__Is -> __What is
            // MyParam1 -> My Param 1
            // MyParam1Baby -> My Param1 Baby (if DontDecamelizeNumbers)

            if (string.IsNullOrWhiteSpace(text))
                return text;

            var lastCategory = CharUnicodeInfo.GetUnicodeCategory(text[0]);
            var prevCategory = lastCategory;
            if (lastCategory == UnicodeCategory.UppercaseLetter)
            {
                lastCategory = UnicodeCategory.LowercaseLetter;
            }

            int i = 0;
            bool firstIsStillUnderscore = text[0] == '_';
            var sb = new StringBuilder(text.Length);

            bool separated = false;
            var cat = char.GetUnicodeCategory(text[0]);
            switch (cat)
            {
                case UnicodeCategory.ClosePunctuation:
                case UnicodeCategory.ConnectorPunctuation:
                case UnicodeCategory.DashPunctuation:
                case UnicodeCategory.EnclosingMark:
                case UnicodeCategory.FinalQuotePunctuation:
                case UnicodeCategory.Format:
                case UnicodeCategory.InitialQuotePunctuation:
                case UnicodeCategory.LineSeparator:
                case UnicodeCategory.OpenPunctuation:
                case UnicodeCategory.OtherPunctuation:
                case UnicodeCategory.ParagraphSeparator:
                case UnicodeCategory.SpaceSeparator:
                case UnicodeCategory.SpacingCombiningMark:
                    separated = true;
                    break;

            }

#pragma warning disable CA1062 // Validate arguments of public methods
            if (options.HasFlag(DecamelizeOptions.UnescapeUnicode) && CanUnicodeEscape(text, 0))
#pragma warning restore CA1062 // Validate arguments of public methods
            {
                _ = sb.Append(GetUnicodeEscape(text, ref i));
            }
            else if (options.HasFlag(DecamelizeOptions.UnescapeHexadecimal) && CanHexadecimalEscape(text, 0))
            {
                _ = sb.Append(GetHexadecimalEscape(text, ref i));
            }
            else
            {
                if (options.HasFlag(DecamelizeOptions.ForceFirstUpper))
                {
                    _ = sb.Append(char.ToUpper(text[0]));
                }
                else
                {
                    _ = sb.Append(text[0]);
                }
            }

            for (i++; i < text.Length; i++)
            {
                char c = text[i];
                if (options.HasFlag(DecamelizeOptions.UnescapeUnicode) && CanUnicodeEscape(text, i))
                {
                    _ = sb.Append(GetUnicodeEscape(text, ref i));
                    separated = true;
                }
                else if (options.HasFlag(DecamelizeOptions.UnescapeHexadecimal) && CanHexadecimalEscape(text, i))
                {
                    _ = sb.Append(GetHexadecimalEscape(text, ref i));
                    separated = true;
                }
                else if (c == '_')
                {
                    if (!firstIsStillUnderscore || !options.HasFlag(DecamelizeOptions.KeepFirstUnderscores))
                    {
                        _ = sb.Append(' ');
                        separated = true;
                    }
                    else
                    {
                        _ = sb.Append(c);
                    }
                }
                else
                {
                    var category = CharUnicodeInfo.GetUnicodeCategory(c);
                    switch (category)
                    {
                        case UnicodeCategory.ClosePunctuation:
                        case UnicodeCategory.ConnectorPunctuation:
                        case UnicodeCategory.DashPunctuation:
                        case UnicodeCategory.EnclosingMark:
                        case UnicodeCategory.FinalQuotePunctuation:
                        case UnicodeCategory.Format:
                        case UnicodeCategory.InitialQuotePunctuation:
                        case UnicodeCategory.LineSeparator:
                        case UnicodeCategory.OpenPunctuation:
                        case UnicodeCategory.OtherPunctuation:
                        case UnicodeCategory.ParagraphSeparator:
                        case UnicodeCategory.SpaceSeparator:
                        case UnicodeCategory.SpacingCombiningMark:
                            if (options.HasFlag(DecamelizeOptions.KeepFormattingIndices) && c == '{')
                            {
                                while (c != '}')
                                {
                                    c = text[i++];
                                    _ = sb.Append(c);
                                }

                                i--;
                                separated = true;
                                break;
                            }

                            if (options.HasFlag(DecamelizeOptions.ForceRestLower))
                            {
                                _ = sb.Append(char.ToLower(c));
                            }
                            else
                            {
                                _ = sb.Append(c);
                            }

                            if (c != ' ' && !separated)
                            {
                                _ = sb.Append(' ');
                            }
                            separated = true;
                            break;

                        case UnicodeCategory.LetterNumber:
                        case UnicodeCategory.DecimalDigitNumber:
                        case UnicodeCategory.OtherNumber:

                        case UnicodeCategory.CurrencySymbol:
                        case UnicodeCategory.LowercaseLetter:
                        case UnicodeCategory.MathSymbol:
                        case UnicodeCategory.ModifierLetter:
                        case UnicodeCategory.ModifierSymbol:
                        case UnicodeCategory.NonSpacingMark:
                        case UnicodeCategory.OtherLetter:
                        case UnicodeCategory.OtherNotAssigned:
                        case UnicodeCategory.Control:
                        case UnicodeCategory.OtherSymbol:
                        case UnicodeCategory.Surrogate:
                        case UnicodeCategory.PrivateUse:
                        case UnicodeCategory.TitlecaseLetter:
                        case UnicodeCategory.UppercaseLetter:
                            if (category != lastCategory && c != ' ' && IsNewCategory(category, options))
                            {
                                if (!separated && prevCategory != UnicodeCategory.UppercaseLetter &&
                                    (!firstIsStillUnderscore || !options.HasFlag(DecamelizeOptions.KeepFirstUnderscores)))
                                {
                                    _ = sb.Append(' ');
                                }

                                if (options.HasFlag(DecamelizeOptions.ForceRestLower))
                                {
                                    _ = sb.Append(char.ToLower(c));
                                }
                                else
                                {
                                    _ = sb.Append(char.ToUpper(c));
                                }

                                var upper = char.ToUpper(c);
                                category = CharUnicodeInfo.GetUnicodeCategory(upper);
                                if (category == UnicodeCategory.UppercaseLetter)
                                {
                                    lastCategory = UnicodeCategory.LowercaseLetter;
                                }
                                else
                                {
                                    lastCategory = category;
                                }
                            }
                            else
                            {
                                if (options.HasFlag(DecamelizeOptions.ForceRestLower))
                                {
                                    _ = sb.Append(char.ToLower(c));
                                }
                                else
                                {
                                    _ = sb.Append(c);
                                }
                            }
                            separated = false;
                            break;
                    }

                    firstIsStillUnderscore = firstIsStillUnderscore && c == '_';
                    prevCategory = category;
                }
            }

            if (options.HasFlag(DecamelizeOptions.ReplaceSpacesByUnderscore))
                return sb.Replace(' ', '_').ToString();

            if (options.HasFlag(DecamelizeOptions.ReplaceSpacesByMinus))
                return sb.Replace(' ', '-').ToString();

            if (options.HasFlag(DecamelizeOptions.ReplaceSpacesByDot))
                return sb.Replace(' ', '.').ToString();

            return sb.ToString();
        }

        // note: we don't want to use char.IsDigit nor char.IsNumber
        private static bool IsAsciiNumber(char c) => c >= '0' && c <= '9';
        private static bool CanUnicodeEscape(string text, int i) => (i + 5) < text.Length && text[i] == '\\' && text[i + 1] == 'u' && IsAsciiNumber(text[i + 2]) && IsAsciiNumber(text[i + 3]) && IsAsciiNumber(text[i + 4]) && IsAsciiNumber(text[i + 5]);
        private static bool IsHexNumber(char c) => IsAsciiNumber(c) || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F');
        private static bool CanHexadecimalEscape(string text, int i) => (i + 6) < text.Length && text[i] == '_' && text[i + 1] == 'x' && text[i + 6] == '_' && IsHexNumber(text[i + 2]) && IsHexNumber(text[i + 3]) && IsHexNumber(text[i + 4]) && IsHexNumber(text[i + 5]);

        private static char GetUnicodeEscape(string text, ref int i)
        {
            i += 5;
            return (char)int.Parse(text.Substring(2, 4));
        }


        private static char GetHexadecimalEscape(string text, ref int i)
        {
            i += 6;
            return (char)int.Parse(text.Substring(2, 4), NumberStyles.HexNumber);
        }

        private static bool IsNewCategory(UnicodeCategory category, DecamelizeOptions options)
        {
            if (options.HasFlag(DecamelizeOptions.DontDecamelizeNumbers))
            {
                if (category == UnicodeCategory.LetterNumber ||
                    category == UnicodeCategory.DecimalDigitNumber ||
                    category == UnicodeCategory.OtherNumber)
                    return false;
            }
            return true;
        }

        public static Type GetEnumeratedType(Type collectionType)
        {
            if (collectionType == null)
                throw new ArgumentNullException(nameof(collectionType));

            foreach (Type type in collectionType.GetInterfaces())
            {
                if (!type.IsGenericType)
                    continue;

                if (type.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                    return type.GetGenericArguments()[0];

                if (type.GetGenericTypeDefinition() == typeof(ICollection<>))
                    return type.GetGenericArguments()[0];

                if (type.GetGenericTypeDefinition() == typeof(IList<>))
                    return type.GetGenericArguments()[0];
            }
            return null;
        }

        public static long ToPositiveFileTime(DateTime dt)
        {
            var ft = ToFileTimeUtc(dt.ToUniversalTime());
            return ft < 0 ? 0 : ft;
        }

        public static long ToPositiveFileTimeUtc(DateTime dt)
        {
            var ft = ToFileTimeUtc(dt);
            return ft < 0 ? 0 : ft;
        }

        public static long ToFileTime(DateTime dt) => ToFileTimeUtc(dt.ToUniversalTime());
        public static long ToFileTimeUtc(DateTime dt)
        {
            const long ticksPerMillisecond = 10000;
            const long ticksPerSecond = ticksPerMillisecond * 1000;
            const long ticksPerMinute = ticksPerSecond * 60;
            const long ticksPerHour = ticksPerMinute * 60;
            const long ticksPerDay = ticksPerHour * 24;
            const int daysPerYear = 365;
            const int daysPer4Years = daysPerYear * 4 + 1;
            const int daysPer100Years = daysPer4Years * 25 - 1;
            const int daysPer400Years = daysPer100Years * 4 + 1;
            const int daysTo1601 = daysPer400Years * 4;
            const long fileTimeOffset = daysTo1601 * ticksPerDay;
            long ticks = dt.Kind == DateTimeKind.Local ? dt.ToUniversalTime().Ticks : dt.Ticks;
            ticks -= fileTimeOffset;
            return ticks;
        }

        public static Guid ComputeGuidHash(string text)
        {
            if (text == null)
                return Guid.Empty;

#pragma warning disable CA5351 // Do Not Use Broken Cryptographic Algorithms
            using (var md5 = MD5.Create())
#pragma warning restore CA5351 // Do Not Use Broken Cryptographic Algorithms
            {
                return new Guid(md5.ComputeHash(Encoding.UTF8.GetBytes(text)));
            }
        }

        public static byte[] ToBytesFromHexa(string text)
        {
            if (text == null)
                return null;

            var list = new List<byte>();
            var lo = false;
            byte prev = 0;
            int offset;

            // handle 0x or 0X notation
            if (text.Length >= 2 && text[0] == '0' && (text[1] == 'x' || text[1] == 'X'))
            {
                offset = 2;
            }
            else
            {
                offset = 0;
            }

            for (var i = 0; i < text.Length - offset; i++)
            {
                var b = GetHexaByte(text[i + offset]);
                if (b == 0xFF)
                    continue;

                if (lo)
                {
                    list.Add((byte)(prev * 16 + b));
                }
                else
                {
                    prev = b;
                }
                lo = !lo;
            }
            return list.ToArray();
        }

        public static byte GetHexaByte(char c)
        {
            if (c >= '0' && c <= '9')
                return (byte)(c - '0');

            if (c >= 'A' && c <= 'F')
                return (byte)(c - 'A' + 10);

            if (c >= 'a' && c <= 'f')
                return (byte)(c - 'a' + 10);

            return 0xFF;
        }

        public static string ToHexa(this byte[] bytes, bool addEllipsis = false) => bytes != null ? ToHexa(bytes, 0, bytes.Length, addEllipsis) : "0x";
        public static string ToHexa(this byte[] bytes, int count, bool addEllipsis = false) => ToHexa(bytes, 0, count, addEllipsis);
        public static string ToHexa(this byte[] bytes, int offset, int count, bool addEllipsis = false)
        {
            if (bytes == null)
                return "0x";

            if (offset < 0)
                throw new ArgumentException(null, nameof(offset));

            if (count < 0)
                throw new ArgumentException(null, nameof(count));

            if (offset >= bytes.Length)
                throw new ArgumentException(null, nameof(offset));

            count = Math.Min(count, bytes.Length - offset);
            var sb = new StringBuilder(count * 2);
            for (var i = offset; i < (offset + count); i++)
            {
                _ = sb.Append(bytes[i].ToString("X2"));
            }

            var s = "0x" + sb.ToString();
            if (addEllipsis && bytes.Length > (offset + count))
            {
                s += "... (" + (bytes.Length - (offset + count)) + ")";
            }
            return s;
        }

        public static string ToHexaDump(string text) => ToHexaDump(text, null);
        public static string ToHexaDump(string text, Encoding encoding)
        {
            if (text == null)
                return null;

            if (encoding == null)
            {
                encoding = Encoding.Unicode;
            }

            return ToHexaDump(encoding.GetBytes(text));
        }

        public static string ToHexaDump(this byte[] bytes)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            return ToHexaDump(bytes, null);
        }

        public static string ToHexaDump(this byte[] bytes, string prefix)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            return ToHexaDump(bytes, 0, bytes.Length, prefix, true);
        }

        public static string ToHexaDump(this IntPtr ptr, int count) => ToHexaDump(ptr, 0, count, null, true);

        public static string ToHexaDump(this IntPtr ptr, int offset, int count, string prefix, bool addHeader)
        {
            if (ptr == IntPtr.Zero)
                throw new ArgumentNullException(nameof(ptr));

            var bytes = new byte[count];
            Marshal.Copy(ptr, bytes, offset, count);
            return ToHexaDump(bytes, 0, count, prefix, addHeader);
        }

        public static string ToHexaDump(this byte[] bytes, int count) => ToHexaDump(bytes, 0, count, null, true);
        public static string ToHexaDump(this byte[] bytes, int offset, int count) => ToHexaDump(bytes, offset, count, null, true);
        public static string ToHexaDump(this byte[] bytes, int offset, int count, string prefix, bool addHeader)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            if (offset < 0)
            {
                offset = 0;
            }

            if (count < 0)
            {
                count = bytes.Length;
            }

            if ((offset + count) > bytes.Length)
            {
                count = bytes.Length - offset;
            }

            var sb = new StringBuilder();
            if (addHeader)
            {
                _ = sb.Append(prefix);
                //             0         1         2         3         4         5         6         7
                //             01234567890123456789012345678901234567890123456789012345678901234567890123456789
                _ = sb.AppendLine("Offset    00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F  0123456789ABCDEF");
                _ = sb.AppendLine("--------  -----------------------------------------------  ----------------");
            }

            for (var i = 0; i < count; i += 16)
            {
                _ = sb.Append(prefix);
                _ = sb.AppendFormat("{0:X8}  ", i + offset);

                int j;
                for (j = 0; (j < 16) && ((i + j) < count); j++)
                {
                    _ = sb.AppendFormat("{0:X2} ", bytes[i + j + offset]);
                }

                _ = sb.Append(' ');
                if (j < 16)
                {
                    _ = sb.Append(new string(' ', 3 * (16 - j)));
                }
                for (j = 0; j < 16 && (i + j) < count; j++)
                {
                    var b = bytes[i + j + offset];
                    if (b > 31 && b < 128)
                    {
                        _ = sb.Append((char)b);
                    }
                    else
                    {
                        _ = sb.Append('.');
                    }
                }

                _ = sb.AppendLine();
            }
            return sb.ToString();
        }

        public static IReadOnlyList<T> SplitToList<T>(string text, params char[] separators) => SplitToList<T>(text, null, separators);
        public static IReadOnlyList<T> SplitToList<T>(string text, IFormatProvider provider, params char[] separators)
        {
            var al = new List<T>();
            if (text == null || separators == null || separators.Length == 0)
                return al;

            foreach (string s in text.Split(separators))
            {
                string value = s.Nullify();
                if (value == null)
                    continue;

                var item = ChangeType(value, default(T), provider);
                al.Add(item);
            }
            return al;
        }

        public static string ToNullifiedString(object input, string defaultValue = null, IFormatProvider provider = null)
        {
            if (input == null)
                return defaultValue;

            if (input is string s)
                return s;

            s = string.Format(provider, "{0}", input).Nullify();
            if (s == null)
                return defaultValue;

            return s;
        }

        public static object ChangeType(object input, Type conversionType) => ChangeType(input, conversionType, null, null);
        public static object ChangeType(object input, Type conversionType, object defaultValue) => ChangeType(input, conversionType, defaultValue, null);
        public static object ChangeType(object input, Type conversionType, object defaultValue, IFormatProvider provider)
        {
            if (!TryChangeType(input, conversionType, provider, out object value))
            {
                if (TryChangeType(defaultValue, conversionType, provider, out var def))
                    return def;

                if (conversionType.IsReallyValueType())
                    return Activator.CreateInstance(conversionType);

                return null;
            }

            return value;
        }

        public static T ChangeType<T>(object input) => ChangeType(input, default(T));
        public static T ChangeType<T>(object input, T defaultValue) => ChangeType(input, defaultValue, null);
        public static T ChangeType<T>(object input, T defaultValue, IFormatProvider provider)
        {
            if (!TryChangeType(input, provider, out T value))
                return defaultValue;

            return value;
        }

        public static DateTime ChangeTypeToDateTime(object input, DateTimeStyles styles = DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal) => ChangeTypeToDateTime(input, styles, DateTime.MinValue);
        public static DateTime ChangeTypeToDateTime(object input, DateTimeStyles styles, DateTime defaultValue) => ChangeTypeToDateTime(input, null, styles, defaultValue);
        public static DateTime ChangeTypeToDateTime(object input, IFormatProvider provider, DateTimeStyles styles, DateTime defaultValue)
        {
            if (!TryChangeToDateTime(input, provider, styles, out var value))
                return defaultValue;

            return value;
        }

        public static bool TryChangeToDateTime(object input, DateTimeStyles styles, out DateTime value) => TryChangeToDateTime(input, null, styles, out value);
        public static bool TryChangeToDateTime(object input, IFormatProvider provider, DateTimeStyles styles, out DateTime value)
        {
            if (input == null)
            {
                value = DateTime.MinValue;
                return false;
            }

            if (input is long il)
            {
                if (styles.HasFlag(DateTimeStyles.AssumeLocal))
                {
                    value = new DateTime(il, DateTimeKind.Local);
                }
                else
                {
                    value = new DateTime(il, DateTimeKind.Utc);
                }
                return true;
            }

            if (input is DateTimeOffset offset)
            {
                value = offset.DateTime;
                return true;
            }

            var text = string.Format(provider, "{0}", input).Nullify();
            if (text == null)
            {
                value = DateTime.MinValue;
                return false;
            }

            if (DateTime.TryParse(text, provider, styles, out value))
                return true;

            DateTime dt;
            // 01234567890123456
            // 20150525T15:50:00
            if (text != null && text.Length == 17)
            {
                if ((text[8] == 'T' || text[8] == 't') && text[11] == ':' && text[14] == ':')
                {
                    _ = int.TryParse(text.Substring(0, 4), out int year);
                    _ = int.TryParse(text.Substring(4, 2), out int month);
                    _ = int.TryParse(text.Substring(6, 2), out int day);
                    _ = int.TryParse(text.Substring(9, 2), out int hour);
                    _ = int.TryParse(text.Substring(12, 2), out int minute);
                    _ = int.TryParse(text.Substring(15, 2), out int second);
                    if (month > 0 && month < 13 &&
                        day > 0 && day < 32 &&
                        year >= 0 &&
                        hour >= 0 && hour < 24 &&
                        minute >= 0 && minute < 60 &&
                        second >= 0 && second < 60)
                    {
                        try
                        {
                            dt = new DateTime(year, month, day, hour, minute, second);
                            value = dt;
                            return true;
                        }
                        catch
                        {
                            // do nothing
                        }
                    }
                }
            }

            if (text != null && text.EndsWith("Z", StringComparison.OrdinalIgnoreCase))
            {
                if (DateTime.TryParseExact(text, _dateFormatsUtc, CultureInfo.InvariantCulture, DateTimeStyles.AllowWhiteSpaces | DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal, out dt))
                {
                    value = dt;
                    return true;
                }
            }

            if (long.TryParse(text, out var l))
            {
                if (styles.HasFlag(DateTimeStyles.AssumeLocal))
                {
                    value = new DateTime(l, DateTimeKind.Local);
                }
                else
                {
                    value = new DateTime(l, DateTimeKind.Utc);
                }
                return true;
            }
            return false;
        }

        public static bool TryChangeType<T>(object input, out T value) => TryChangeType(input, null, out value);
        public static bool TryChangeType<T>(object input, IFormatProvider provider, out T value)
        {
            if (!TryChangeType(input, typeof(T), provider, out object tvalue))
            {
                value = default;
                return false;
            }

            value = (T)tvalue;
            return true;
        }

        public static bool TryChangeType(object input, Type conversionType, out object value) => TryChangeType(input, conversionType, null, out value);
        public static bool TryChangeType(object input, Type conversionType, IFormatProvider provider, out object value)
        {
            if (conversionType == null)
                throw new ArgumentNullException(nameof(conversionType));

            if (conversionType == typeof(object))
            {
                value = input;
                return true;
            }

            if (IsNullable(conversionType))
            {
                if (input == null)
                {
                    value = null;
                    return true;
                }

                Type gType = conversionType.GetGenericArguments()[0];
                if (TryChangeType(input, gType, provider, out object vtValue))
                {
                    var nt = typeof(Nullable<>).MakeGenericType(gType);
                    value = Activator.CreateInstance(nt, vtValue);
                    return true;
                }

                value = null;
                return false;
            }

            value = conversionType.IsReallyValueType() ? Activator.CreateInstance(conversionType) : null;
            if (input == null)
                return !conversionType.IsReallyValueType();

            var inputType = input.GetType();
            if (conversionType.IsAssignableFrom(inputType))
            {
                value = input;
                return true;
            }

            if (Marshal.IsComObject(input) && conversionType.IsInterface)
            {
                var p = Marshal.GetComInterfaceForObject(input, conversionType);
                if (p == IntPtr.Zero)
                    return false;

                _ = Marshal.Release(p);
                value = input;
                return true;
            }

            if (conversionType.IsEnum)
                return EnumTryParse(conversionType, input, out value);

            if (inputType.IsEnum)
            {
                var tc = Type.GetTypeCode(inputType);
                if (conversionType == typeof(int))
                {
                    switch (tc)
                    {
                        case TypeCode.Int32:
                            value = (int)input;
                            return true;

                        case TypeCode.Int16:
                            value = (int)(short)input;
                            return true;

                        case TypeCode.Int64:
                            value = (int)(long)input;
                            return true;

                        case TypeCode.UInt32:
                            value = (int)(uint)input;
                            return true;

                        case TypeCode.UInt16:
                            value = (int)(ushort)input;
                            return true;

                        case TypeCode.UInt64:
                            value = (int)(ulong)input;
                            return true;

                        case TypeCode.Byte:
                            value = (int)(byte)input;
                            return true;

                        case TypeCode.SByte:
                            value = (int)(sbyte)input;
                            return true;
                    }
                    return false;
                }

                if (conversionType == typeof(short))
                {
                    switch (tc)
                    {
                        case TypeCode.Int32:
                            value = (short)(int)input;
                            return true;

                        case TypeCode.Int16:
                            value = (short)input;
                            return true;

                        case TypeCode.Int64:
                            value = (short)(long)input;
                            return true;

                        case TypeCode.UInt32:
                            value = (short)(uint)input;
                            return true;

                        case TypeCode.UInt16:
                            value = (short)(ushort)input;
                            return true;

                        case TypeCode.UInt64:
                            value = (short)(ulong)input;
                            return true;

                        case TypeCode.Byte:
                            value = (short)(byte)input;
                            return true;

                        case TypeCode.SByte:
                            value = (short)(sbyte)input;
                            return true;
                    }
                    return false;
                }

                if (conversionType == typeof(long))
                {
                    switch (tc)
                    {
                        case TypeCode.Int32:
                            value = (long)(int)input;
                            return true;

                        case TypeCode.Int16:
                            value = (long)(short)input;
                            return true;

                        case TypeCode.Int64:
                            value = (long)input;
                            return true;

                        case TypeCode.UInt32:
                            value = (long)(uint)input;
                            return true;

                        case TypeCode.UInt16:
                            value = (long)(ushort)input;
                            return true;

                        case TypeCode.UInt64:
                            value = (long)(ulong)input;
                            return true;

                        case TypeCode.Byte:
                            value = (long)(byte)input;
                            return true;

                        case TypeCode.SByte:
                            value = (long)(sbyte)input;
                            return true;
                    }
                    return false;
                }

                if (conversionType == typeof(uint))
                {
                    switch (tc)
                    {
                        case TypeCode.Int32:
                            value = (uint)(int)input;
                            return true;

                        case TypeCode.Int16:
                            value = (uint)(short)input;
                            return true;

                        case TypeCode.Int64:
                            value = (uint)(long)input;
                            return true;

                        case TypeCode.UInt32:
                            value = (uint)input;
                            return true;

                        case TypeCode.UInt16:
                            value = (uint)(ushort)input;
                            return true;

                        case TypeCode.UInt64:
                            value = (uint)(ulong)input;
                            return true;

                        case TypeCode.Byte:
                            value = (uint)(byte)input;
                            return true;

                        case TypeCode.SByte:
                            value = (uint)(sbyte)input;
                            return true;
                    }
                    return false;
                }

                if (conversionType == typeof(ushort))
                {
                    switch (tc)
                    {
                        case TypeCode.Int32:
                            value = (ushort)(int)input;
                            return true;

                        case TypeCode.Int16:
                            value = (ushort)(short)input;
                            return true;

                        case TypeCode.Int64:
                            value = (ushort)(long)input;
                            return true;

                        case TypeCode.UInt32:
                            value = (ushort)(uint)input;
                            return true;

                        case TypeCode.UInt16:
                            value = (ushort)input;
                            return true;

                        case TypeCode.UInt64:
                            value = (ushort)(ulong)input;
                            return true;

                        case TypeCode.Byte:
                            value = (ushort)(byte)input;
                            return true;

                        case TypeCode.SByte:
                            value = (ushort)(sbyte)input;
                            return true;
                    }
                    return false;
                }

                if (conversionType == typeof(ulong))
                {
                    switch (tc)
                    {
                        case TypeCode.Int32:
                            value = (ulong)(int)input;
                            return true;

                        case TypeCode.Int16:
                            value = (ulong)(short)input;
                            return true;

                        case TypeCode.Int64:
                            value = (ulong)(long)input;
                            return true;

                        case TypeCode.UInt32:
                            value = (ulong)(uint)input;
                            return true;

                        case TypeCode.UInt16:
                            value = (ulong)(ushort)input;
                            return true;

                        case TypeCode.UInt64:
                            value = (ulong)input;
                            return true;

                        case TypeCode.Byte:
                            value = (ulong)(byte)input;
                            return true;

                        case TypeCode.SByte:
                            value = (ulong)(sbyte)input;
                            return true;
                    }
                    return false;
                }

                if (conversionType == typeof(byte))
                {
                    switch (tc)
                    {
                        case TypeCode.Int32:
                            value = (byte)(int)input;
                            return true;

                        case TypeCode.Int16:
                            value = (byte)(short)input;
                            return true;

                        case TypeCode.Int64:
                            value = (byte)(long)input;
                            return true;

                        case TypeCode.UInt32:
                            value = (byte)(uint)input;
                            return true;

                        case TypeCode.UInt16:
                            value = (byte)(ushort)input;
                            return true;

                        case TypeCode.UInt64:
                            value = (byte)(ulong)input;
                            return true;

                        case TypeCode.Byte:
                            value = (byte)input;
                            return true;

                        case TypeCode.SByte:
                            value = (byte)(sbyte)input;
                            return true;
                    }
                    return false;
                }

                if (conversionType == typeof(sbyte))
                {
                    switch (tc)
                    {
                        case TypeCode.Int32:
                            value = (sbyte)(int)input;
                            return true;

                        case TypeCode.Int16:
                            value = (sbyte)(short)input;
                            return true;

                        case TypeCode.Int64:
                            value = (sbyte)(long)input;
                            return true;

                        case TypeCode.UInt32:
                            value = (sbyte)(uint)input;
                            return true;

                        case TypeCode.UInt16:
                            value = (sbyte)(ushort)input;
                            return true;

                        case TypeCode.UInt64:
                            value = (sbyte)(ulong)input;
                            return true;

                        case TypeCode.Byte:
                            value = (sbyte)(byte)input;
                            return true;

                        case TypeCode.SByte:
                            value = (sbyte)input;
                            return true;
                    }
                    return false;
                }
            }

            if (conversionType == typeof(Guid))
            {
                string svalue = string.Format(provider, "{0}", input).Nullify();
                if (svalue != null && Guid.TryParse(svalue, out Guid guid))
                {
                    value = guid;
                    return true;
                }
                return false;
            }

            if (conversionType == typeof(Uri))
            {
                string svalue = string.Format(provider, "{0}", input).Nullify();
                if (svalue != null && Uri.TryCreate(svalue, UriKind.RelativeOrAbsolute, out var uri))
                {
                    value = uri;
                    return true;
                }
                return false;
            }

            if (conversionType == typeof(IntPtr))
            {
                if (IntPtr.Size == 8)
                {
                    if (TryChangeType(input, provider, out long l))
                    {
                        value = new IntPtr(l);
                        return true;
                    }
                }
                else if (TryChangeType(input, provider, out int i))
                {
                    value = new IntPtr(i);
                    return true;
                }
                return false;
            }

            if (conversionType == typeof(int))
            {
                if (inputType == typeof(uint))
                {
                    value = unchecked((int)(uint)input);
                    return true;
                }

                if (inputType == typeof(ulong))
                {
                    value = unchecked((int)(ulong)input);
                    return true;
                }

                if (inputType == typeof(ushort))
                {
                    value = unchecked((int)(ushort)input);
                    return true;
                }

                if (inputType == typeof(byte))
                {
                    value = unchecked((int)(byte)input);
                    return true;
                }
            }

            if (conversionType == typeof(long))
            {
                if (inputType == typeof(uint))
                {
                    value = unchecked((long)(uint)input);
                    return true;
                }

                if (inputType == typeof(ulong))
                {
                    value = unchecked((long)(ulong)input);
                    return true;
                }

                if (inputType == typeof(ushort))
                {
                    value = unchecked((long)(ushort)input);
                    return true;
                }

                if (inputType == typeof(byte))
                {
                    value = unchecked((long)(byte)input);
                    return true;
                }

                if (inputType == typeof(TimeSpan))
                {
                    value = ((TimeSpan)input).Ticks;
                    return true;
                }
            }

            if (conversionType == typeof(short))
            {
                if (inputType == typeof(uint))
                {
                    value = unchecked((short)(uint)input);
                    return true;
                }

                if (inputType == typeof(ulong))
                {
                    value = unchecked((short)(ulong)input);
                    return true;
                }

                if (inputType == typeof(ushort))
                {
                    value = unchecked((short)(ushort)input);
                    return true;
                }

                if (inputType == typeof(byte))
                {
                    value = unchecked((short)(byte)input);
                    return true;
                }
            }

            if (conversionType == typeof(sbyte))
            {
                if (inputType == typeof(uint))
                {
                    value = unchecked((sbyte)(uint)input);
                    return true;
                }

                if (inputType == typeof(ulong))
                {
                    value = unchecked((sbyte)(ulong)input);
                    return true;
                }

                if (inputType == typeof(ushort))
                {
                    value = unchecked((sbyte)(ushort)input);
                    return true;
                }

                if (inputType == typeof(byte))
                {
                    value = unchecked((sbyte)(byte)input);
                    return true;
                }
            }

            if (conversionType == typeof(uint))
            {
                if (inputType == typeof(int))
                {
                    value = unchecked((uint)(int)input);
                    return true;
                }

                if (inputType == typeof(long))
                {
                    value = unchecked((uint)(long)input);
                    return true;
                }

                if (inputType == typeof(short))
                {
                    value = unchecked((uint)(short)input);
                    return true;
                }

                if (inputType == typeof(sbyte))
                {
                    value = unchecked((uint)(sbyte)input);
                    return true;
                }
            }

            if (conversionType == typeof(ulong))
            {
                if (inputType == typeof(int))
                {
                    value = unchecked((ulong)(int)input);
                    return true;
                }

                if (inputType == typeof(long))
                {
                    value = unchecked((ulong)(long)input);
                    return true;
                }

                if (inputType == typeof(short))
                {
                    value = unchecked((ulong)(short)input);
                    return true;
                }

                if (inputType == typeof(sbyte))
                {
                    value = unchecked((ulong)(sbyte)input);
                    return true;
                }
            }

            if (conversionType == typeof(ushort))
            {
                if (inputType == typeof(int))
                {
                    value = unchecked((ushort)(int)input);
                    return true;
                }

                if (inputType == typeof(long))
                {
                    value = unchecked((ushort)(long)input);
                    return true;
                }

                if (inputType == typeof(short))
                {
                    value = unchecked((ushort)(short)input);
                    return true;
                }

                if (inputType == typeof(sbyte))
                {
                    value = unchecked((ushort)(sbyte)input);
                    return true;
                }
            }

            if (conversionType == typeof(byte))
            {
                if (inputType == typeof(int))
                {
                    value = unchecked((byte)(int)input);
                    return true;
                }

                if (inputType == typeof(long))
                {
                    value = unchecked((byte)(long)input);
                    return true;
                }

                if (inputType == typeof(short))
                {
                    value = unchecked((byte)(short)input);
                    return true;
                }

                if (inputType == typeof(sbyte))
                {
                    value = unchecked((byte)(sbyte)input);
                    return true;
                }
            }

            if (conversionType == typeof(DateTime))
            {
                if (inputType == typeof(long))
                {
                    value = new DateTime((long)input, DateTimeKind.Utc);
                    return true;
                }

                if (inputType == typeof(DateTimeOffset))
                {
                    value = ((DateTimeOffset)input).DateTime;
                    return true;
                }

                if (TryChangeToDateTime(input, provider, DateTimeStyles.None, out var dt))
                {
                    value = dt;
                    return true;
                }
            }

            if (conversionType == typeof(DateTimeOffset))
            {
                if (inputType == typeof(long))
                {
                    value = new DateTimeOffset(new DateTime((long)input, DateTimeKind.Utc));
                    return true;
                }

                if (inputType == typeof(DateTime))
                {
                    var dt = (DateTime)input;
                    if (dt.IsValid())
                    {
                        value = new DateTimeOffset((DateTime)input);
                        return true;
                    }
                }

                if (TryChangeToDateTime(input, provider, DateTimeStyles.None, out var dt2))
                {
                    value = new DateTimeOffset(dt2);
                    return true;
                }
            }

            if (conversionType == typeof(TimeSpan))
            {
                if (inputType == typeof(long))
                {
                    value = new TimeSpan((long)input);
                    return true;
                }

                if (inputType == typeof(DateTime))
                {
                    value = ((DateTime)value).TimeOfDay;
                    return true;
                }

                if (inputType == typeof(DateTimeOffset))
                {
                    value = ((DateTimeOffset)value).TimeOfDay;
                    return true;
                }

                if (TryChangeType(input, provider, out string sv) && TimeSpan.TryParse(sv, provider, out var ts))
                {
                    value = ts;
                    return true;
                }
            }

            var isGenericList = IsGenericList(conversionType, out var elementType);
            if (conversionType.IsArray || isGenericList)
            {
                if (input is IEnumerable enumerable)
                {
                    if (!isGenericList)
                    {
                        elementType = conversionType.GetElementType();
                    }

                    var list = (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(elementType));
                    int count = 0;
                    foreach (var obj in enumerable)
                    {
                        count++;
                        if (TryChangeType(obj, elementType, provider, out object element))
                        {
                            _ = list.Add(element);
                        }
                    }

                    // at least one was converted
                    if (count > 0 && list.Count > 0)
                    {
                        if (isGenericList)
                        {
                            value = list;
                        }
                        else
                        {
                            value = list.GetType().GetMethod(nameof(List<object>.ToArray)).Invoke(list, null);
                        }
                        return true;
                    }
                }
            }

            if (conversionType == typeof(CultureInfo) || conversionType == typeof(IFormatProvider))
            {
                try
                {
                    if (input is int lcid)
                    {
                        value = CultureInfo.GetCultureInfo(lcid);
                        return true;
                    }
                    else
                    {
                        var si = input?.ToString();
                        if (si != null)
                        {
                            if (int.TryParse(si, out lcid))
                            {
                                value = CultureInfo.GetCultureInfo(lcid);
                                return true;
                            }

                            value = CultureInfo.GetCultureInfo(si);
                            return true;
                        }
                    }
                }
                catch
                {
                    // do nothing, wrong culture, etc.
                }
                return false;
            }

            if (conversionType == typeof(bool))
            {
                if (true.Equals(input))
                {
                    value = true;
                    return true;
                }

                if (false.Equals(input))
                {
                    value = false;
                    return true;
                }

                var svalue = string.Format(provider, "{0}", input).Nullify();
                if (svalue == null)
                    return false;

                if (bool.TryParse(svalue, out bool b))
                {
                    value = b;
                    return true;
                }

                if (svalue.EqualsIgnoreCase("y") || svalue.EqualsIgnoreCase("yes"))
                {
                    value = true;
                    return true;
                }

                if (svalue.EqualsIgnoreCase("n") || svalue.EqualsIgnoreCase("no"))
                {
                    value = false;
                    return true;
                }

                if (TryChangeType(input, out long bl))
                {
                    value = bl != 0;
                    return true;
                }
                return false;
            }

            // in general, nothing is convertible to anything but one of these, IConvertible is 100% stupid thing
            bool isWellKnownConvertible()
            {
                return conversionType == typeof(short) || conversionType == typeof(int) ||
                    conversionType == typeof(string) || conversionType == typeof(byte) ||
                    conversionType == typeof(char) || conversionType == typeof(DateTime) ||
                    conversionType == typeof(DBNull) || conversionType == typeof(decimal) ||
                    conversionType == typeof(double) || conversionType.IsEnum ||
                    conversionType == typeof(short) || conversionType == typeof(int) ||
                    conversionType == typeof(long) || conversionType == typeof(sbyte) ||
                    conversionType == typeof(bool) || conversionType == typeof(float) ||
                    conversionType == typeof(ushort) || conversionType == typeof(uint) ||
                    conversionType == typeof(ulong);
            }

            if (isWellKnownConvertible() && input is IConvertible convertible)
            {
                try
                {
                    value = convertible.ToType(conversionType, provider);
                    if (value is DateTime dt && !dt.IsValid())
                        return false;

                    return true;
                }
                catch
                {
                    // continue;
                }
            }

            if (input != null)
            {
                var inputConverter = TypeDescriptor.GetConverter(input);
                if (inputConverter != null)
                {
                    if (inputConverter.CanConvertTo(conversionType))
                    {
                        try
                        {
                            value = inputConverter.ConvertTo(null, provider as CultureInfo, input, conversionType);
                            return true;
                        }
                        catch
                        {
                            // continue;
                        }
                    }
                }
            }

            var converter = TypeDescriptor.GetConverter(conversionType);
            if (converter != null)
            {
                if (converter.CanConvertTo(conversionType))
                {
                    try
                    {
                        value = converter.ConvertTo(null, provider as CultureInfo, input, conversionType);
                        return true;
                    }
                    catch
                    {
                        // continue;
                    }
                }

                if (converter.CanConvertFrom(inputType))
                {
                    try
                    {
                        value = converter.ConvertFrom(null, provider as CultureInfo, input);
                        return true;
                    }
                    catch
                    {
                        // continue;
                    }
                }
            }

            if (conversionType == typeof(string))
            {
                value = string.Format(provider, "{0}", input);
                return true;
            }

            return false;
        }

        public static T GetNumber<T>(string value, T defaultValue) => GetNumber(value, null, defaultValue);
        public static T GetNumber<T>(object value, T defaultValue) => GetNumber(value, null, defaultValue);
        public static T GetNumber<T>(object input, IFormatProvider provider, T defaultValue)
        {
            if (!TryGetNumber(input, provider, out T value))
                return defaultValue;

            return value;
        }

        public static bool TryGetNumber<T>(object input, IFormatProvider provider, out T value)
        {
            if (!TryGetNumber(input, typeof(T), provider, out object obj))
            {
                value = default;
                return false;
            }

            value = (T)obj;
            return true;
        }

        public static bool TryGetNumber(object input, Type conversionType, IFormatProvider provider, out object value)
        {
            if (conversionType == null)
                throw new ArgumentNullException(nameof(conversionType));

            value = Activator.CreateInstance(conversionType);
            if (provider == null)
            {
                provider = CultureInfo.InvariantCulture;
            }

            if (input is byte[] bytes)
            {
                switch (bytes.Length)
                {
                    case 1:
                        if (conversionType == typeof(sbyte))
                        {
                            value = (sbyte)bytes[0];
                            return true;
                        }

                        return TryGetNumber(bytes[0], conversionType, provider, out value);

                    case 2:
                        if (conversionType == typeof(ushort))
                        {
                            value = BitConverter.ToUInt16(bytes, 0);
                            return true;
                        }

                        return TryGetNumber(BitConverter.ToInt16(bytes, 0), conversionType, provider, out value);

                    case 4:
                        if (conversionType == typeof(float))
                        {
                            try
                            {
                                value = BitConverter.ToSingle(bytes, 0);
                                return true;
                            }
                            catch
                            {
                                return false;
                            }
                        }

                        if (conversionType == typeof(uint))
                        {
                            value = BitConverter.ToUInt32(bytes, 0);
                            return true;
                        }

                        return TryGetNumber(BitConverter.ToInt32(bytes, 0), conversionType, provider, out value);

                    case 8:
                        if (conversionType == typeof(double))
                        {
                            try
                            {
                                value = BitConverter.ToDouble(bytes, 0);
                                return true;
                            }
                            catch
                            {
                                return false;
                            }
                        }

                        if (conversionType == typeof(ulong))
                        {
                            value = BitConverter.ToUInt64(bytes, 0);
                            return true;
                        }

                        return TryGetNumber(BitConverter.ToInt64(bytes, 0), conversionType, provider, out value);
                }
                return false;
            }

            string s = input as string;
            if (input == null || s != null)
                return TryGetNumber(s, conversionType, provider, out value);

            Type type = input.GetType();
            if (conversionType == typeof(object))
            {
                TypeCode tc = Type.GetTypeCode(type);
                switch (tc)
                {
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.Single:
                    case TypeCode.Double:
                    case TypeCode.Decimal:
                        value = input;
                        return true;

                    case TypeCode.Boolean:
                        bool b = (bool)input;
                        value = b ? 1 : 0;
                        return true;

                    case TypeCode.Byte:
                        byte by = (byte)input;
                        value = (int)by;
                        return true;

                    case TypeCode.Int16:
                        short sh = (short)input;
                        value = (int)sh;
                        return true;

                    case TypeCode.SByte:
                        sbyte sb = (sbyte)input;
                        value = (int)sb;
                        return true;

                    case TypeCode.UInt16:
                        ushort us = (ushort)input;
                        value = (int)us;
                        return true;

                    case TypeCode.UInt32:
                        uint ui = (uint)input;
                        value = (long)ui;
                        return true;

                    case TypeCode.UInt64:
                        ulong ul = (ulong)input;
                        value = (decimal)ul;
                        return true;
                }
            }

            if (conversionType == type)
            {
                value = input;
                return true;
            }

            s = string.Format(provider, "{0}", input);
            return TryGetNumber(s, conversionType, provider, out value);
        }

        public static T GetNumber<T>(string input, IFormatProvider provider, T defaultValue)
        {
            if (!TryGetNumber(input, provider, out T value))
                return defaultValue;

            return value;
        }

        public static bool TryGetNumber<T>(string input, IFormatProvider provider, out T value)
        {
            if (!TryGetNumber(input, typeof(T), provider, out object obj))
            {
                value = default;
                return false;
            }

            value = (T)obj;
            return true;
        }

        private static bool IsHexNumber(string input, out string output)
        {
            if (string.IsNullOrEmpty(input))
            {
                output = input;
                return false;
            }

            if (input[0] == 'x' || input[0] == 'X')
            {
                output = input.Substring(1);
                return true;
            }

            if (input.Length < 2)
            {
                output = input;
                return false;
            }

            if (input[1] == 'x' || input[1] == 'X')
            {
                output = input.Substring(2);
                return true;
            }

            output = input;
            return false;
        }

        public static bool TryGetNumber(string input, Type conversionType, IFormatProvider provider, out object value)
        {
            if (conversionType == null)
                throw new ArgumentNullException(nameof(conversionType));

            value = Activator.CreateInstance(conversionType);
            if (provider == null)
            {
                provider = CultureInfo.InvariantCulture;
            }

            if (input == null)
                return false;

            input = input.Trim();
            if (input.Length == 0)
                return false;

            var ns = IsHexNumber(input, out string hexInput) ? NumberStyles.HexNumber | NumberStyles.AllowHexSpecifier : NumberStyles.Any;

            if (conversionType == typeof(int))
            {
                if (!int.TryParse(hexInput, ns, provider, out int n))
                    return false;

                value = n;
                return true;
            }

            if (conversionType == typeof(long))
            {
                if (!long.TryParse(hexInput, ns, provider, out long n))
                    return false;

                value = n;
                return true;
            }

            if (conversionType == typeof(float))
            {
                if (!float.TryParse(input, NumberStyles.Any, provider, out float n))
                    return false;

                value = n;
                return true;
            }

            if (conversionType == typeof(double))
            {
                if (!double.TryParse(input, NumberStyles.Any, provider, out double n))
                    return false;

                value = n;
                return true;
            }

            if (conversionType == typeof(decimal))
            {
                if (!decimal.TryParse(input, NumberStyles.Any, provider, out decimal n))
                    return false;

                value = n;
                return true;
            }

            // asked for the "best number"...
            string decSep = GetDecimalSeparator(provider);
            bool hasDecimal = input.IndexOf(decSep) >= 0;
            if (!hasDecimal)
            {
                if (int.TryParse(hexInput, ns, provider, out int i))
                {
                    value = i;
                    return true;
                }

                if (long.TryParse(hexInput, ns, provider, out long l))
                {
                    value = l;
                    return true;
                }
            }
            else
            {
                if (float.TryParse(input, NumberStyles.Any, provider, out float f))
                {
                    value = f;
                    return true;
                }

                if (double.TryParse(input, NumberStyles.Any, provider, out double d))
                {
                    value = d;
                    return true;
                }
            }

            if (decimal.TryParse(input, NumberStyles.Any, provider, out decimal dec))
            {
                value = dec;
                return true;
            }

            return false;
        }

        private static string GetDecimalSeparator(IFormatProvider provider)
        {
            if (!(provider is CultureInfo ci) || ci.NumberFormat == null)
                return ".";

            return ci.NumberFormat.CurrencyDecimalSeparator ?? ".";
        }

        public static ulong EnumToUInt64(string text, Type enumType)
        {
            if (enumType == null)
                throw new ArgumentNullException(nameof(enumType));

            return EnumToUInt64(ChangeType(text, enumType));
        }

        public static ulong EnumToUInt64(object value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var typeCode = Convert.GetTypeCode(value);
            switch (typeCode)
            {
                case TypeCode.SByte:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                    return (ulong)Convert.ToInt64(value, CultureInfo.InvariantCulture);

                case TypeCode.Byte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return Convert.ToUInt64(value, CultureInfo.InvariantCulture);

                //case TypeCode.String:
                default:
                    return ChangeType<ulong>(value, 0, CultureInfo.InvariantCulture);
            }
        }

        public static int GetEnumMaxPower(Type enumType)
        {
            if (enumType == null)
                throw new ArgumentNullException(nameof(enumType));

            if (!enumType.IsEnum)
                throw new ArgumentException(null, nameof(enumType));

            return GetEnumUnderlyingTypeMaxPower(Enum.GetUnderlyingType(enumType));
        }

        public static Type GetEnumUnderlyingType(int enumMaxPower)
        {
            switch (enumMaxPower)
            {
                case 8:
                    return typeof(sbyte);

                case 16:
                    return typeof(short);

                case 64:
                    return typeof(long);
            }
            return typeof(int);
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

        private static bool StringToEnum(Type type, string[] names, Array values, string input, out object value)
        {
            for (var i = 0; i < names.Length; i++)
            {
                if (names[i].EqualsIgnoreCase(input))
                {
                    value = values.GetValue(i);
                    return true;
                }
            }

            for (var i = 0; i < values.GetLength(0); i++)
            {
                var valuei = values.GetValue(i);
                if (input.Length > 0 && input[0] == '-')
                {
                    var ul = (long)EnumToUInt64(valuei);
                    if (ul.ToString().EqualsIgnoreCase(input))
                    {
                        value = valuei;
                        return true;
                    }
                }
                else
                {
                    var ul = EnumToUInt64(valuei);
                    if (ul.ToString().EqualsIgnoreCase(input))
                    {
                        value = valuei;
                        return true;
                    }
                }
            }

            if (char.IsDigit(input[0]) || input[0] == '-' || input[0] == '+')
            {
                var obj = EnumToObject(type, input);
                if (obj == null)
                {
                    value = Activator.CreateInstance(type);
                    return false;
                }
                value = obj;
                return true;
            }

            value = Activator.CreateInstance(type);
            return false;
        }

        public static object EnumToObject(Type enumType, object value)
        {
            if (enumType == null)
                throw new ArgumentNullException(nameof(enumType));

            if (!enumType.IsEnum)
                throw new ArgumentException(null, nameof(enumType));

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var underlyingType = Enum.GetUnderlyingType(enumType);
            if (underlyingType == typeof(long))
                return Enum.ToObject(enumType, ChangeType<long>(value));

            if (underlyingType == typeof(ulong))
                return Enum.ToObject(enumType, ChangeType<ulong>(value));

            if (underlyingType == typeof(int))
                return Enum.ToObject(enumType, ChangeType<int>(value));

            if ((underlyingType == typeof(uint)))
                return Enum.ToObject(enumType, ChangeType<uint>(value));

            if (underlyingType == typeof(short))
                return Enum.ToObject(enumType, ChangeType<short>(value));

            if (underlyingType == typeof(ushort))
                return Enum.ToObject(enumType, ChangeType<ushort>(value));

            if (underlyingType == typeof(byte))
                return Enum.ToObject(enumType, ChangeType<byte>(value));

            if (underlyingType == typeof(sbyte))
                return Enum.ToObject(enumType, ChangeType<sbyte>(value));

            throw new ArgumentException(null, nameof(enumType));
        }

        public static object ToEnum(object obj, Enum defaultValue)
        {
            if (obj == null)
                return defaultValue;

            if (obj.GetType() == defaultValue.GetType())
                return obj;

            if (EnumTryParse(defaultValue.GetType(), obj.ToString(), out object value))
                return value;

            return defaultValue;
        }

        public static object ToEnum(string text, Type enumType)
        {
            if (enumType == null)
                throw new ArgumentNullException(nameof(enumType));

            _ = EnumTryParse(enumType, text, out object value);
            return value;
        }

        public static Enum ToEnum(string text, Enum defaultValue)
        {
            if (EnumTryParse(defaultValue.GetType(), text, out object value))
                return (Enum)value;

            return defaultValue;
        }

        public static bool EnumTryParse(Type type, object input, out object value)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            if (!type.IsEnum)
                throw new ArgumentException(null, nameof(type));

            if (input == null)
            {
                value = Activator.CreateInstance(type);
                return false;
            }

            var stringInput = string.Format(CultureInfo.InvariantCulture, "{0}", input);
            stringInput = stringInput.Nullify();
            if (stringInput == null)
            {
                value = Activator.CreateInstance(type);
                return false;
            }

            if (stringInput.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                if (ulong.TryParse(stringInput.Substring(2), NumberStyles.HexNumber, null, out ulong ulx))
                {
                    value = ToEnum(ulx.ToString(CultureInfo.InvariantCulture), type);
                    return true;
                }
            }

            var names = Enum.GetNames(type);
            if (names.Length == 0)
            {
                value = Activator.CreateInstance(type);
                return false;
            }

            var values = Enum.GetValues(type);
            // some enums like System.CodeDom.MemberAttributes *are* flags but are not declared with Flags...
            if (!type.IsDefined(typeof(FlagsAttribute), true) && stringInput.IndexOfAny(_enumSeparators) < 0)
                return StringToEnum(type, names, values, stringInput, out value);

            // multi value enum
            var tokens = stringInput.Split(_enumSeparators, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length == 0)
            {
                value = Activator.CreateInstance(type);
                return false;
            }

            ulong ul = 0;
            foreach (string tok in tokens)
            {
                string token = tok.Nullify(); // NOTE: we don't consider empty tokens as errors
                if (token == null)
                    continue;

                if (!StringToEnum(type, names, values, token, out object tokenValue))
                {
                    value = Activator.CreateInstance(type);
                    return false;
                }

                ulong tokenUl;
                switch (Convert.GetTypeCode(tokenValue))
                {
                    case TypeCode.Int16:
                    case TypeCode.Int32:
                    case TypeCode.Int64:
                    case TypeCode.SByte:
                        tokenUl = (ulong)Convert.ToInt64(tokenValue, CultureInfo.InvariantCulture);
                        break;

                    default:
                        tokenUl = Convert.ToUInt64(tokenValue, CultureInfo.InvariantCulture);
                        break;
                }

                ul |= tokenUl;
            }
            value = Enum.ToObject(type, ul);
            return true;
        }

        public static bool IsGenericList(Type type, out Type elementType)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
            {
                elementType = type.GetGenericArguments()[0];
                return true;
            }

            elementType = null;
            return false;
        }

        public static bool IsReallyValueType(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            return type.IsValueType && !IsNullable(type);
        }

        public static bool IsNullable(this Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        public static string ConvertToUnsecureString(this SecureString securePassword)
        {
            if (securePassword == null)
                throw new ArgumentNullException(nameof(securePassword));

            var unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(securePassword);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }

        public static string FormatByteSize(long size)
        {
            var sb = new StringBuilder(64);
            _ = StrFormatByteSizeW(size, sb, sb.Capacity);
            return sb.ToString();
        }

        [DllImport("shlwapi", CharSet = CharSet.Unicode, ExactSpelling = true)]
        private static extern long StrFormatByteSizeW(long qdw, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszBuf, int cchBuf);
    }
}
