using System;
using System.Collections.Generic;
using System.Text;

namespace DirectN
{
    public static class ID2D1PropertiesExtensions
    {
        public static IReadOnlyList<D2D1Property> GetProperties(this IComObject<ID2D1Properties> properties) => GetProperties(properties?.Object);
        public static IReadOnlyList<D2D1Property> GetProperties(this ID2D1Properties properties)
        {
            if (properties == null)
                return new D2D1Property[0];

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

        public static void SetValue(this ID2D1Properties properties, int index, object value)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            if (value is null)
            {
                SetValue(properties, index, null);
                return;
            }

            if (value is bool bv)
            {
                SetValue(properties, index, bv);
                return;
            }

            if (value is Guid gv)
            {
                SetValue(properties, index, gv);
                return;
            }

            if (value is float fv)
            {
                SetValue(properties, index, fv);
                return;
            }

            if (value is uint uiv)
            {
                SetValue(properties, index, uiv);
                return;
            }

            if (value is int iv)
            {
                SetValue(properties, index, iv);
                return;
            }

            if (value is byte[] byv)
            {
                SetValue(properties, index, byv);
                return;
            }

            if (value is string sv)
            {
                SetValue(properties, index, sv);
                return;
            }

            if (value is ValueType vt)
            {
                using (var mem = new ComMemory(vt))
                {
                    SetValue(properties, index, mem.ToArray());
                    return;
                }
            }
            throw new NotSupportedException("Value of type '" + value.GetType().FullName + "' is not supported.");
        }

        public static void SetValue(this ID2D1Properties properties, int index, string value)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            var bytes = value != null ? Encoding.Unicode.GetBytes(value) : null;
            properties.SetValue((uint)index, D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UNKNOWN, bytes, (bytes?.Length).GetValueOrDefault()).ThrowOnError();
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

            properties.SetValueByName(name, type, value, value.Length).ThrowOnError();
        }
    }
}
