using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace DirectN
{
    public static class ID2D1PropertiesExtensions
    {
        public static T GetValue<T>(this IComObject<ID2D1Properties> properties, int index, T defaultValue = default)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            if (!TryGetValue(properties, index, out var value))
                return default;

            return Conversions.ChangeType(value, defaultValue);
        }

        public static T GetValue<T>(this IComObject<ID2D1Properties> properties, string name, T defaultValue = default)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (!TryGetValue(properties, name, out var value))
                return default;

            return Conversions.ChangeType(value, defaultValue);
        }

        public static bool TryGetValue(this IComObject<ID2D1Properties> properties, string name, out object value) => TryGetValue(properties?.Object, name, out value);
        public static bool TryGetValue(this ID2D1Properties properties, string name, out object value)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            if (name == null)
                throw new ArgumentNullException(nameof(name));

            value = null;
            var index = properties.GetPropertyIndex(name);
            if (index < 0)
                return false;

            return TryGetValue(properties, (int)index, out value);
        }

        public static bool TryGetValue(this IComObject<ID2D1Properties> properties, int index, out object value) => TryGetValue(properties?.Object, index, out value);
        public static bool TryGetValue(this ID2D1Properties properties, int index, out object value)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            value = null;
            var size = properties.GetValueSize((uint)index);
            if (size < 0)
                return false;

            var type = properties.GetType((uint)index);

            var bytes = new byte[size];
            var hr = properties.GetValue((uint)index, type, bytes, bytes.Length);
            if (hr.IsError)
                return false;

            return TryGetValue(type, bytes, out value);
        }

        public static bool TryGetValue(D2D1_PROPERTY_TYPE type, byte[] data, out object value)
        {
            value = null;
            if (data == null || data.Length == 0)
                return false;

            switch (type)
            {
                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_BOOL:
                    value = BitConverter.ToInt32(data, 0) != 0;
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_STRING:
                    var s = Encoding.Unicode.GetString(data);
                    if (!string.IsNullOrEmpty(s))
                    {
                        while (s[s.Length - 1] == '0')
                        {
                            s = s.Substring(0, s.Length - 1);
                        }
                    }
                    value = s;
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UINT32:
                    value = BitConverter.ToUInt32(data, 0);
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_INT32:
                    value = BitConverter.ToInt32(data, 0);
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_FLOAT:
                    value = BitConverter.ToSingle(data, 0);
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR2:
                    value = data.BytesToStructure<D2D_VECTOR_2F>();
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR3:
                    value = data.BytesToStructure<D2D_VECTOR_3F>();
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR4:
                    value = data.BytesToStructure<D2D_VECTOR_4F>();
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_BLOB:
                    value = data;
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_ENUM:
                    value = BitConverter.ToUInt32(data, 0);
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_CLSID:
                    value = new Guid(data);
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_3X2:
                    value = data.BytesToStructure<D2D_MATRIX_3X2_F>();
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_4X3:
                    value = data.BytesToStructure<D2D_MATRIX_4X3_F>();
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_4X4:
                    value = data.BytesToStructure<D2D_MATRIX_4X4_F>();
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_5X4:
                    value = data.BytesToStructure<D2D_MATRIX_5X4_F>();
                    return true;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_IUNKNOWN:
                    var ptr = data.BytesToIntPtr();
                    if (ptr != IntPtr.Zero)
                    {
                        value = Marshal.GetObjectForIUnknown(ptr);
                    }
                    return true;
            }
            return false;
        }

        public static IReadOnlyList<D2D1Property> GetProperties(this IComObject<ID2D1Properties> properties) => GetProperties(properties?.Object);
        public static IReadOnlyList<D2D1Property> GetProperties(this ID2D1Properties properties)
        {
            if (properties == null)
                return Array.Empty<D2D1Property>();

            var list = new List<D2D1Property>();
            for (uint i = 0; i < properties.GetPropertyCount(); i++)
            {
                var len = properties.GetPropertyNameLength(i);
                var name = new string('\0', (int)len);
                properties.GetPropertyName(i, name, len + 1).ThrowOnError();
                var property = new D2D1Property();
                property.Name = name;
                property.Type = properties.GetType(i);

                var size = properties.GetValueSize(i);
                if (size > 0)
                {
                    var data = new byte[size];
                    properties.GetValue(i, property.Type, data, data.Length).ThrowOnError();
                    property.ValueBytes = data;
                }

                properties.GetSubProperties(i, out var sub);
                property.SubProperties = GetProperties(sub);
                list.Add(property);
            }

            var prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_AUTHOR));
            if (prop != null)
            {
                list.Add(prop);
            }

            prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_CATEGORY));
            if (prop != null)
            {
                list.Add(prop);
            }

            prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_DESCRIPTION));
            if (prop != null)
            {
                list.Add(prop);
            }

            prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_DISPLAYNAME));
            if (prop != null)
            {
                list.Add(prop);
            }

            prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_CLSID));
            if (prop != null)
            {
                list.Add(prop);
            }

            prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_INPUTS));
            if (prop != null)
            {
                list.Add(prop);
            }

            prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_MIN_INPUTS));
            if (prop != null)
            {
                list.Add(prop);
            }

            prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_MAX_INPUTS));
            if (prop != null)
            {
                list.Add(prop);
            }

            prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_CACHED));
            if (prop != null)
            {
                list.Add(prop);
            }

            prop = GetProperty(properties, unchecked((uint)D2D1_PROPERTY.D2D1_PROPERTY_PRECISION));
            if (prop != null)
            {
                list.Add(prop);
            }
            return list;
        }

        //public static bool TryGetProperty(this IComObject<ID2D1Effect> effect, string name, out object value) => TryGetProperty(effect?.Object, name, out value);
        public static bool TryGetProperty(this IComObject<ID2D1Properties> properties, string name, out object value) => TryGetProperty(properties?.Object, name, out value);
        public static bool TryGetProperty(this ID2D1Properties properties, string name, out object value)
        {
            if (properties == null)
            {
                value = null;
                return false;
            }

            if (name == null)
                throw new ArgumentNullException(nameof(name));

            var index = properties.GetPropertyIndex(name);
            if (index == uint.MaxValue)
            {
                value = null;
                return false;
            }
            return TryGetProperty(properties, index, out value);
        }

        //public static bool TryGetProperty(this IComObject<ID2D1Effect> effect, uint index, out object value) => TryGetProperty(effect?.Object, index, out value);
        public static bool TryGetProperty(this IComObject<ID2D1Properties> properties, uint index, out object value) => TryGetProperty(properties?.Object, index, out value);
        public static bool TryGetProperty(this ID2D1Properties properties, uint index, out object value)
        {
            if (properties == null)
            {
                value = null;
                return false;
            }

            var size = properties.GetValueSize(index);
            if (size == 0)
            {
                value = null;
                return false;
            }

            var data = new byte[size];
            if (properties.GetValue(index, D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN, data, data.Length).IsError)
            {
                value = null;
                return false;
            }

            var type = properties.GetType(index);
            value = D2D1Property.GetValue(type, data);
            return true;
        }

        //public static D2D1Property GetProperty(this IComObject<ID2D1Effect> effect, uint index) => GetProperty(effect?.Object, index);
        public static D2D1Property GetProperty(this IComObject<ID2D1Properties> properties, uint index) => GetProperty(properties?.Object, index);
        public static D2D1Property GetProperty(this ID2D1Properties properties, uint index)
        {
            if (properties == null)
                return null;

            var prop = new D2D1Property();
            prop.Type = properties.GetType(index);

            var len = properties.GetPropertyNameLength(index);
            if (len > 0)
            {
                var name = new string('\0', (int)len);
                properties.GetPropertyName(index, name, len + 1);
                prop.Name = name;
            }

            var size = properties.GetValueSize(index);
            if (size > 0)
            {
                var data = new byte[size];
                if (properties.GetValue(index, D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN, data, data.Length).IsSuccess)
                {
                    prop.ValueBytes = data;
                }
            }

            if (prop.Type == D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN && prop.Name == null)
                return null;

            return prop;
        }

        public static void SetValue(this ID2D1Properties properties, int index, string value)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            var bytes = value != null ? Encoding.Unicode.GetBytes(value) : null;
            properties.SetValue((uint)index, D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN, bytes, (bytes?.Length).GetValueOrDefault()).ThrowOnError();
        }

        public static void SetValue(this IComObject<ID2D1Properties> properties, int index, object value) => SetValue(properties?.Object, index, value);
        public static void SetValue(this ID2D1Properties properties, int index, object value)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            if (!TryGetData(value, out var type, out var data))
                throw new NotSupportedException();

            properties.SetValue((uint)index, type, data, data.Length).ThrowOnError();
        }

        public static void SetValue(this IComObject<ID2D1Properties> properties, string name, object value) => SetValue(properties?.Object, name, value);
        public static void SetValue(this ID2D1Properties properties, string name, object value)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (!TryGetData(value, out var type, out var data))
                throw new NotSupportedException();

            properties.SetValueByName(name, type, data, data.Length).ThrowOnError();
        }

        public static void SetValue(this IComObject<ID2D1Properties> properties, int index, D2D1_PROPERTY_TYPE type, byte[] data) => SetValue(properties?.Object, index, type, data);
        public static void SetValue(this ID2D1Properties properties, int index, D2D1_PROPERTY_TYPE type, byte[] data)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            if (data == null)
                throw new ArgumentNullException(nameof(data));

            properties.SetValue((uint)index, type, data, data.Length).ThrowOnError();
        }

        public static void SetValue(this IComObject<ID2D1Properties> properties, string name, D2D1_PROPERTY_TYPE type, byte[] data) => SetValue(properties?.Object, name, type, data);
        public static void SetValue(this ID2D1Properties properties, string name, D2D1_PROPERTY_TYPE type, byte[] data)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (data == null)
                throw new ArgumentNullException(nameof(data));

            properties.SetValueByName(name, type, data, data.Length).ThrowOnError();
        }

        public static bool TryGetData(object value, out D2D1_PROPERTY_TYPE type, out byte[] data)
        {
            type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN;
            data = null;
            if (value == null)
                return false;

            var vt = value.GetType();
            if (vt.IsEnum && TryGetData(Convert.ToUInt32(value), out type, out data))
            {
                type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_ENUM;
                return true;
            }

            var tc = Type.GetTypeCode(vt);
            switch (tc)
            {
                case TypeCode.Boolean:
                    type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_BOOL;
                    data = BitConverter.GetBytes(Convert.ToInt32(value));
                    return true;

                case TypeCode.Int64:  // possible overflow
                case TypeCode.Int16:
                case TypeCode.UInt16:
                case TypeCode.Byte:
                case TypeCode.SByte:
                    type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_INT32;
                    data = BitConverter.GetBytes(Convert.ToInt32(value));
                    return true;

                case TypeCode.Int32:
                    type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_INT32;
                    data = BitConverter.GetBytes((int)value);
                    return true;

                case TypeCode.UInt64: // possible overflow
                    type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UINT32;
                    data = BitConverter.GetBytes(Convert.ToUInt32(value));
                    return true;

                case TypeCode.UInt32:
                    type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UINT32;
                    data = BitConverter.GetBytes((uint)value);
                    return true;

                case TypeCode.Single:
                    type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_FLOAT;
                    data = BitConverter.GetBytes((float)value);
                    return true;

                case TypeCode.Double:
                case TypeCode.Decimal:
                    type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_FLOAT;
                    data = BitConverter.GetBytes(Convert.ToSingle(value));
                    return true;

                case TypeCode.Char:
                    type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_STRING;
                    data = Encoding.Unicode.GetBytes(((char)value).ToString() + '\0');
                    break;

                case TypeCode.String:
                    type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_STRING;
                    data = Encoding.Unicode.GetBytes(((string)value) + '\0');
                    break;

                case TypeCode.Object:
                    if (value is Guid guid)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_CLSID;
                        data = guid.ToByteArray();
                        return true;
                    }

                    if (value is byte[] bytes)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_BLOB;
                        data = bytes;
                        return true;
                    }

                    if (value is D2D_VECTOR_2F v2)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR2;
                        data = v2.StructureToBytes();
                        return true;
                    }

                    if (value is D2D_VECTOR_3F v3)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR3;
                        data = v3.StructureToBytes();
                        return true;
                    }

                    if (value is D2D_VECTOR_4F v4)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR4;
                        data = v4.StructureToBytes();
                        return true;
                    }

                    if (value is D2D_MATRIX_3X2_F m32)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_3X2;
                        data = m32.StructureToBytes();
                        return true;
                    }

                    if (value is D2D_MATRIX_4X3_F m43)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_4X3;
                        data = m43.StructureToBytes();
                        return true;
                    }

                    if (value is D2D_MATRIX_4X4_F m44)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_4X4;
                        data = m44.StructureToBytes();
                        return true;
                    }

                    if (value is D2D_MATRIX_5X4_F m54)
                    {
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_5X4;
                        data = m54.StructureToBytes();
                        return true;
                    }

                    if (value is IComObject co)
                    {
                        var unk = Marshal.GetComInterfaceForObject(co.Object, co.InterfaceType);
                        type = typeof(ID2D1ColorContext).IsAssignableFrom(co.InterfaceType) ? D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_COLOR_CONTEXT : D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_IUNKNOWN;
                        data = unk.IntPtrToBytes();
                        Marshal.Release(unk);
                        return true;
                    }

                    try
                    {
                        var unk = Marshal.GetIUnknownForObject(value);
                        type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_IUNKNOWN;
                        data = unk.IntPtrToBytes();
                        Marshal.Release(unk);
                        return true;
                    }
                    catch
                    {
                        // continue
                    }
                    break;
            }
            return false;
        }

        public static void SetValue(this ID2D1Properties properties, int index, bool value) => SetValue(properties, index, value ? 1 : 0);
        public static void SetValue(this ID2D1Properties properties, int index, Guid value) => SetValue(properties, index, value.ToByteArray());
        public static void SetValue(this ID2D1Properties properties, int index, float value) => SetValue(properties, index, BitConverter.GetBytes(value));
        public static void SetValue(this ID2D1Properties properties, int index, uint value) => SetValue(properties, index, BitConverter.GetBytes(value));
        public static void SetValue(this ID2D1Properties properties, int index, int value) => SetValue(properties, index, BitConverter.GetBytes(value));
        public static void SetValue(this ID2D1Properties properties, int index, byte[] value, D2D1_PROPERTY_TYPE type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            properties.SetValue((uint)index, type, value, value.Length).ThrowOnError();
        }

        public static void SetValueByName(this ID2D1Properties properties, string name, object value)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (value is null)
            {
                SetValueByName(properties, name, null);
                return;
            }

            var type = value.GetType();
            if (type.IsEnum)
            {
                value = (int)value;
            }

            if (value is bool bv)
            {
                SetValueByName(properties, name, bv);
                return;
            }

            if (value is Guid gv)
            {
                SetValueByName(properties, name, gv);
                return;
            }

            if (value is float fv)
            {
                SetValueByName(properties, name, fv);
                return;
            }

            if (value is uint uiv)
            {
                SetValueByName(properties, name, uiv);
                return;
            }

            if (value is int iv)
            {
                SetValueByName(properties, name, iv);
                return;
            }

            if (value is byte[] byv)
            {
                SetValueByName(properties, name, byv);
                return;
            }

            if (value is string sv)
            {
                SetValueByName(properties, name, sv);
                return;
            }

            if (value is ValueType vt) // matrix & vector types
            {
                using (var mem = new ComMemory(vt))
                {
                    SetValueByName(properties, name, mem.ToArray());
                    return;
                }
            }
            throw new NotSupportedException("Value of type '" + value.GetType().FullName + "' is not supported.");
        }

        public static void SetValueByName(this ID2D1Properties properties, string name, string value)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            if (name == null)
                throw new ArgumentNullException(nameof(name));

            var bytes = value != null ? Encoding.Unicode.GetBytes(value) : null;
            properties.SetValueByName(name, D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN, bytes, (bytes?.Length).GetValueOrDefault()).ThrowOnError();
        }

        public static void SetValueByName(this ID2D1Properties properties, string name, bool value) => SetValueByName(properties, name, value ? 1 : 0);
        public static void SetValueByName(this ID2D1Properties properties, string name, Guid value) => SetValueByName(properties, name, value.ToByteArray());
        public static void SetValueByName(this ID2D1Properties properties, string name, float value) => SetValueByName(properties, name, BitConverter.GetBytes(value));
        public static void SetValueByName(this ID2D1Properties properties, string name, uint value) => SetValueByName(properties, name, BitConverter.GetBytes(value));
        public static void SetValueByName(this ID2D1Properties properties, string name, int value) => SetValueByName(properties, name, BitConverter.GetBytes(value));
        public static void SetValueByName(this ID2D1Properties properties, string name, byte[] value, D2D1_PROPERTY_TYPE type = D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            if (name == null)
                throw new ArgumentNullException(nameof(name));

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            properties.SetValueByName(name, type, value, value.Length).ThrowOnError();
        }
    }
}
