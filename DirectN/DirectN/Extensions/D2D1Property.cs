using System;
using System.Collections.Generic;
using System.Text;

namespace DirectN
{
    public sealed class D2D1Property
    {
        internal D2D1Property()
        {
        }

        public string Name { get; internal set; }
        public D2D1_PROPERTY_TYPE Type { get; internal set; }
        public byte[] ValueBytes { get; internal set; }
        public IReadOnlyList<D2D1Property> SubProperties { get; internal set; }
        public object Value => GetValue(Type, ValueBytes, false);

        public static object GetValue(D2D1_PROPERTY_TYPE type, byte[] data, bool throwOnError = true)
        {
            if (data == null)
            {
                if (throwOnError)
                    throw new ArgumentNullException(nameof(data));
                
                return null;
            }

            switch (type)
            {
                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_BOOL:
                    return BitConverter.ToInt32(data, 0) != 0;

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_CLSID:
                    return new Guid(data);

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_ENUM:
                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_INT32:
                    return BitConverter.ToInt32(data, 0);

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_UINT32:
                    return BitConverter.ToUInt32(data, 0);

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_FLOAT:
                    return BitConverter.ToSingle(data, 0);

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_STRING:
                    // buffer contains a terminating zero
                    return Encoding.Unicode.GetString(data, 0, data.Length - 2);

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR2:
                    return data.ToStructure<D2D_VECTOR_2F>();

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR3:
                    return data.ToStructure<D2D_VECTOR_3F>();

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_VECTOR4:
                    return data.ToStructure<D2D_VECTOR_4F>();

                case D2D1_PROPERTY_TYPE.D2D1_PROPERTY_TYPE_MATRIX_3X2:
                    return data.ToStructure<D2D_MATRIX_3X2_F>();

                default:
                    if (throwOnError)
                        throw new NotSupportedException("Value of type '" + type + "' is not supported.");

                    return null;
            }
        }

        public override string ToString() => Type + " " + Name + " = " + Value;
    }
}
