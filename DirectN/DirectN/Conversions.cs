using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace DirectN
{
    internal static class Conversions
    {
        private static readonly char[] _enumSeparators = new char[] { ',', ';', '+', '|', ' ' };

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

        public static object ChangeType(object input, Type conversionType) => ChangeType(input, conversionType, null, null);
        public static object ChangeType(object input, Type conversionType, object defaultValue) => ChangeType(input, conversionType, defaultValue, null);
        public static object ChangeType(object input, Type conversionType, object defaultValue, IFormatProvider provider)
        {
            if (!TryChangeType(input, conversionType, provider, out object value))
                return defaultValue;

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

        public static bool TryChangeType<T>(object input, out T value) => TryChangeType(input, null, out value);
        public static bool TryChangeType<T>(object input, IFormatProvider provider, out T value)
        {
            if (!TryChangeType(input, typeof(T), provider, out object tvalue))
            {
                value = default(T);
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

            value = conversionType.IsValueType ? Activator.CreateInstance(conversionType) : null;
            if (input == null)
                return !conversionType.IsValueType;

            var inputType = input.GetType();
            if (inputType.IsAssignableFrom(conversionType))
            {
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
                    value = new DateTime((long)input);
                    return true;
                }

                if (inputType == typeof(DateTimeOffset))
                {
                    value = ((DateTimeOffset)input).DateTime;
                    return true;
                }
            }

            if (conversionType == typeof(DateTimeOffset))
            {
                if (inputType == typeof(long))
                {
                    value = new DateTimeOffset(new DateTime((long)input));
                    return true;
                }

                if (inputType == typeof(DateTime))
                {
                    value = new DateTimeOffset((DateTime)input);
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

            bool isGenericList = IsGenericList(conversionType, out var elementType);
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
                            list.Add(element);
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
                    if (TryChangeType(input, provider, out int lcid))
                    {
                        value = CultureInfo.GetCultureInfo((int)input);
                        return true;
                    }
                    else
                    {
                        if (TryChangeType(input, provider, out string s))
                        {
                            value = CultureInfo.GetCultureInfo(s);
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
                    return true;
                }
                catch
                {
                    // continue;
                }
            }

            if (value != null)
            {
                var converter = TypeDescriptor.GetConverter(value);
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
            }

            if (input != null)
            {
                var converter = TypeDescriptor.GetConverter(input);
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
                }
            }

            if (conversionType == typeof(string))
            {
                value = string.Format(provider, "{0}", input);
                return true;
            }

            return false;
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

                case TypeCode.String:
                default:
                    return ChangeType<ulong>(value, 0, CultureInfo.InvariantCulture);
            }
        }

        private static bool StringToEnum(Type type, Type underlyingType, string[] names, Array values, string input, out object value)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].EqualsIgnoreCase(input))
                {
                    value = values.GetValue(i);
                    return true;
                }
            }

            for (int i = 0; i < values.GetLength(0); i++)
            {
                object valuei = values.GetValue(i);
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
            if (defaultValue == null)
                throw new ArgumentNullException(nameof(defaultValue));

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

            EnumTryParse(enumType, text, out object value);
            return value;
        }

        public static Enum ToEnum(string text, Enum defaultValue)
        {
            if (defaultValue == null)
                throw new ArgumentNullException(nameof(defaultValue));

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

            var underlyingType = Enum.GetUnderlyingType(type);
            var values = Enum.GetValues(type);
            // some enums like System.CodeDom.MemberAttributes *are* flags but are not declared with Flags...
            if (!type.IsDefined(typeof(FlagsAttribute), true) && stringInput.IndexOfAny(_enumSeparators) < 0)
                return StringToEnum(type, underlyingType, names, values, stringInput, out value);

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

                if (!StringToEnum(type, underlyingType, names, values, token, out object tokenValue))
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

        public static bool IsNullable(Type type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }
    }
}
