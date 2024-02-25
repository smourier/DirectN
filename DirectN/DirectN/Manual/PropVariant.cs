using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Explicit)]
    public sealed class PropVariant : IDisposable
    {
#pragma warning disable IDE0044 // Add readonly modifier
        [FieldOffset(0)]
        private PropertyType _vt;

        [FieldOffset(8)]
        private IntPtr _ptr;

        [FieldOffset(8)]
        private int _int32;

        [FieldOffset(8)]
        private uint _uint32;

        [FieldOffset(8)]
        private byte _byte;

        [FieldOffset(8)]
        private sbyte _sbyte;

        [FieldOffset(8)]
        private short _int16;

        [FieldOffset(8)]
        private ushort _uint16;

        [FieldOffset(8)]
        private long _int64;

        [FieldOffset(8)]
        private ulong _uint64;

        [FieldOffset(8)]
        private double _double;

        [FieldOffset(8)]
        private float _single;

        [FieldOffset(8)]
        private short _boolean;

        [FieldOffset(8)]
        private System.Runtime.InteropServices.ComTypes.FILETIME _filetime;

        [FieldOffset(8)]
        private PROPARRAY _ca;

        [FieldOffset(0)]
        private decimal _decimal;
#pragma warning restore IDE0044 // Add readonly modifier

        [StructLayout(LayoutKind.Sequential)]
        private struct PROPARRAY
        {
            public int cElems;
            public IntPtr pElems;
        }

        public PropVariant()
        {
            // it's a VT_EMPTY
        }

        public PropVariant(object value, PropertyType? type = null)
        {
            if (value == null)
            {
                _vt = PropertyType.VT_NULL;
                return;
            }

            if (Marshal.IsComObject(value))
            {
                _ptr = Marshal.GetIUnknownForObject(value);
                _vt = PropertyType.VT_UNKNOWN;
                return;
            }

            if (value is PropVariant pv)
            {
                value = pv.Value;
            }

            if (value is char[] chars)
            {
                value = new string(chars);
            }

            if (value is char[][])
            {
                var charray = value as char[][];
                var strings = new string[charray.GetLength(0)];
                for (var i = 0; i < charray.Length; i++)
                {
                    strings[i] = new string(charray[i]);
                }
                value = strings;
            }

            if (value is Array array)
            {
                ConstructArray(array, type);
                return;
            }

            if (!(value is string) && value is IEnumerable enumerable)
            {
                ConstructEnumerable(enumerable, type);
                return;
            }

            var valueType = value.GetType();
            var tc = Type.GetTypeCode(valueType);
            switch (tc)
            {
                case TypeCode.Boolean:
                    _boolean = (bool)value ? (short)(-1) : (short)0;
                    break;

                case TypeCode.Byte:
                    _byte = (byte)value;
                    break;

                case TypeCode.Char:
                    chars = new[] { (char)value };
                    _ptr = MarshalString(new string(chars), FromType(typeof(string), type));
                    break;

                case TypeCode.DateTime:
                    if (type == PropertyType.VT_FILETIME)
                    {
                        var ft = Conversions.ToPositiveFileTime((DateTime)value);
                        InitPropVariantFromFileTime(ref ft, this);
                    }
                    else
                    {
                        var dt = (DateTime)value;
                        _double = dt.ToOADate();
                    }
                    break;

                case TypeCode.Empty:
                case TypeCode.DBNull:
                    break;

                case TypeCode.Decimal:
                    _decimal = (decimal)value;
                    break;

                case TypeCode.Double:
                    _double = (double)value;
                    break;

                case TypeCode.Int16:
                    _int16 = (short)value;
                    break;

                case TypeCode.Int32:
                    _int32 = (int)value;
                    break;

                case TypeCode.Int64:
                    _int64 = (long)value;
                    break;

                case TypeCode.SByte:
                    _sbyte = (sbyte)value;
                    break;

                case TypeCode.Single:
                    _single = (float)value;
                    break;

                case TypeCode.String:
                    _ptr = MarshalString((string)value, FromType(typeof(string), type));
                    break;

                case TypeCode.UInt16:
                    _uint16 = (ushort)value;
                    break;

                case TypeCode.UInt32:
                    _uint32 = (uint)value;
                    break;

                case TypeCode.UInt64:
                    _uint64 = (ulong)value;
                    break;

                //case TypeCode.Object:
                default:
                    if (value is Guid guid)
                    {
                        _ptr = Marshal.AllocCoTaskMem(16);
                        Marshal.Copy(guid.ToByteArray(), 0, _ptr, 16);
                        break;
                    }

                    if (value is DateTimeOffset dto)
                    {
                        if (type == PropertyType.VT_FILETIME)
                        {
                            var ft = Conversions.ToPositiveFileTime(dto.DateTime);
                            InitPropVariantFromFileTime(ref ft, this);
                        }
                        else
                        {
                            _double = dto.DateTime.ToOADate();
                        }
                        valueType = typeof(DateTime);
                        break;
                    }

                    if (value is System.Runtime.InteropServices.ComTypes.FILETIME filetime)
                    {
                        _filetime = filetime;
                        break;
                    }
                    throw new ArgumentException("Value of type '" + value.GetType().FullName + "' is not supported.", nameof(value));
            }

            _vt = FromType(valueType, type);
        }

        public PropertyType VarType { get => _vt; set => _vt = value; }
        public object Value
        {
            get
            {
                switch (_vt)
                {
                    case PropertyType.VT_EMPTY:
                    case PropertyType.VT_NULL: // DbNull
                        return null;

                    case PropertyType.VT_I1:
                        return _sbyte;

                    case PropertyType.VT_UI1:
                        return _byte;

                    case PropertyType.VT_I2:
                        return _int16;

                    case PropertyType.VT_UI2:
                        return _uint16;

                    case PropertyType.VT_I4:
                    case PropertyType.VT_INT:
                        return _int32;

                    case PropertyType.VT_UI4:
                    case PropertyType.VT_UINT:
                        return _uint32;

                    case PropertyType.VT_I8:
                        return _int64;

                    case PropertyType.VT_UI8:
                        return _uint64;

                    case PropertyType.VT_R4:
                        return _single;

                    case PropertyType.VT_R8:
                        return _double;

                    case PropertyType.VT_BOOL:
                        return _int32 != 0;

                    case PropertyType.VT_ERROR:
                        return _int64;

                    case PropertyType.VT_CY:
                        return _decimal;

                    case PropertyType.VT_DATE:
                        return DateTime.FromOADate(_double);

                    case PropertyType.VT_FILETIME:
                        return DateTime.FromFileTime(_int64);

                    case PropertyType.VT_BSTR:
                        return Marshal.PtrToStringBSTR(_ptr);

                    case PropertyType.VT_BLOB:
                        var blob = new byte[_ca.cElems];
                        Marshal.Copy(_ca.pElems, blob, 0, _int32);
                        return blob;

                    case PropertyType.VT_CLSID:
                        var guid = new byte[16];
                        Marshal.Copy(_ptr, guid, 0, guid.Length);
                        return new Guid(guid);

                    case PropertyType.VT_LPSTR:
                        return Marshal.PtrToStringAnsi(_ptr);

                    case PropertyType.VT_LPWSTR:
                        return Marshal.PtrToStringUni(_ptr);

                    case PropertyType.VT_UNKNOWN:
                    case PropertyType.VT_DISPATCH:
                        return Marshal.GetObjectForIUnknown(_ptr);

                    case PropertyType.VT_DECIMAL:
                        return _decimal;

                    default:
                        if ((_vt & PropertyType.VT_VECTOR) == PropertyType.VT_VECTOR)
                        {
                            var et = _vt & ~PropertyType.VT_VECTOR;
                            if (TryGetVectorValue(et, out var vector))
                                return vector;
                        }

                        var hr = PropVariantToVariant(this, out var obj);
                        if (hr.IsSuccess)
                            return obj;

                        throw new NotSupportedException("Value of property type " + _vt + " is not supported.");
                }
            }
        }

        public IntPtr Serialize(out int size, bool throwOnError = true)
        {
            StgSerializePropVariant(this, out var ptr, out size).ThrowOnError(throwOnError);
            return ptr;
        }

        public byte[] Serialize(bool throwOnError = true)
        {
            var hr = StgSerializePropVariant(this, out IntPtr ptr, out int size);
            if (hr.IsError && !throwOnError)
                return null;

            hr.ThrowOnError(throwOnError);
            var bytes = new byte[size];
            Marshal.Copy(ptr, bytes, 0, bytes.Length);
            Marshal.FreeCoTaskMem(ptr);
            return bytes;
        }

        public object ToVariant(bool throwOnError = true)
        {
            PropVariantToVariant(this, out var obj).ThrowOnError(throwOnError);
            return obj;
        }

        public PropVariant ChangeType(PropertyType type, bool throwOnError = true)
        {
            var pv = new PropVariant();
            PropVariantChangeType(pv, this, 0, type).ThrowOnError(throwOnError);
            return pv;
        }

        public void CopyFrom(PropVariant source, bool throwOnError = true)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (source == this)
                return;

            PropVariantCopy(this, source).ThrowOnError(throwOnError);
        }

        public PropVariant Copy(bool throwOnError = true)
        {
            var pv = new PropVariant();
            var hr = PropVariantCopy(pv, this);
            hr.ThrowOnError(throwOnError);
            return hr.IsError ? null : pv;
        }

        public IntPtr ToWinRTPropertyValuePointer(bool throwOnError = true) => ToWinRTPropertyValuePointer(IID_IPropertyValue, throwOnError);
        public IntPtr ToWinRTPropertyValuePointer(Guid iid, bool throwOnError = true)
        {
            PropVariantToWinRTPropertyValue(this, iid, out IntPtr ptr).ThrowOnError(throwOnError);
            return ptr;
        }

        public object ToWinRTPropertyValue(bool throwOnError = true) => ToWinRTPropertyValue(IID_IPropertyValue, throwOnError);
        public object ToWinRTPropertyValue(Guid iid, bool throwOnError = true)
        {
            PropVariantToWinRTPropertyValue(this, iid, out object obj).ThrowOnError(throwOnError);
            return obj;
        }

        public override string ToString()
        {
            var value = Value;
            if (value == null)
                return "<null>";

            if (value is string svalue)
                return "[" + VarType + "] `" + svalue + "`";

            if (value is Guid guid)
                return "[" + VarType + "] " + guid.ToName();

            if (!(value is byte[]) && value is IEnumerable enumerable)
                return "[" + VarType + "] " + string.Join(", ", enumerable.OfType<object>());

            if (value is byte[] bytes)
                return "[" + VarType + "] bytes[" + bytes.Length + "]";

            return "[" + VarType + "] " + value;
        }

        ~PropVariant() => Dispose();
        public void Dispose()
        {
            _ = PropVariantClear(this);
            GC.SuppressFinalize(this);
        }

        private void ConstructEnumerable(IEnumerable enumerable, PropertyType? type = null)
        {
            var et = GetElementType(enumerable);
            if (et == null)
                throw new ArgumentException("Enumerable type '" + enumerable.GetType().FullName + "' is not supported.", nameof(enumerable));

            var count = GetCount(enumerable);
            var array = Array.CreateInstance(et, count);
            var i = 0;
            foreach (var obj in enumerable)
            {
                array.SetValue(obj, i++);
            }
            ConstructArray(array, type);
        }

        private void ConstructBlob(byte[] bytes)
        {
            _ca.cElems = bytes.Length;
            _ca.pElems = Marshal.AllocCoTaskMem(bytes.Length);
            Marshal.Copy(bytes, 0, _ca.pElems, bytes.Length);
            _vt = PropertyType.VT_BLOB;
        }

        private void ConstructArray(Array array, PropertyType? type = null)
        {
            // special case for bools which are shorts...
            if (array is bool[] bools)
            {
                var shorts = new short[bools.Length];
                for (var i = 0; i < bools.Length; i++)
                {
                    shorts[i] = bools[i] ? ((short)(-1)) : ((short)0);
                }
                ConstructVector(shorts, typeof(short), PropertyType.VT_BOOL);
                return;
            }

            var et = array.GetType().GetElementType();
            if (type == PropertyType.VT_BLOB)
            {
                if (!(array is byte[] bytes))
                    throw new ArgumentException("Property type " + type + " is only supported for arrays of bytes.", nameof(type));

                ConstructBlob(bytes);
                return;
            }

            ConstructVector(array, et, FromType(et, type));
        }

        private void ConstructVector(Array array, Type type, PropertyType vt)
        {
            _vt = vt | PropertyType.VT_VECTOR;
            if (array.Length > 0)
            {
                int size;
                if (type == typeof(string))
                {
                    size = IntPtr.Size;
                }
                else if (type == typeof(object))
                {
                    size = Marshal.SizeOf<PropVariant>(); // same size as VARIANT
                }
                else
                {
                    size = Marshal.SizeOf(type);
                }

                var elementSize = size;
                size *= array.Length;
                var ptr = Marshal.AllocCoTaskMem(size);
                _ca.cElems = array.Length;
                _ca.pElems = ptr;

                if (type == typeof(string))
                {
                    for (var i = 0; i < array.Length; i++)
                    {
                        var str = MarshalString((string)array.GetValue(i), vt);
                        Marshal.WriteIntPtr(ptr, elementSize * i, str);
                    }
                }
                else if (type == typeof(object))
                {
                    for (var i = 0; i < array.Length; i++)
                    {
                        var variant = array.GetValue(i);
                        Marshal.GetNativeVariantForObject<object>(variant, ptr + elementSize * i);
                    }
                }
                else
                {
                    CopyMemory(ptr, Marshal.UnsafeAddrOfPinnedArrayElement(array, 0), (IntPtr)size);
                }
            }
        }

        private bool TryGetVectorValue(PropertyType vt, out object value)
        {
            value = null;
            var ret = false;
            int size;
            switch (vt)
            {
                case PropertyType.VT_LPSTR:
                case PropertyType.VT_LPWSTR:
                    var strings = new string[_ca.cElems];
                    for (var i = 0; i < strings.Length; i++)
                    {
                        var str = Marshal.ReadIntPtr(_ca.pElems, IntPtr.Size * i);
                        strings[i] = vt == PropertyType.VT_LPSTR ? Marshal.PtrToStringAnsi(str) : Marshal.PtrToStringUni(str);
                    }
                    value = strings;
                    ret = true;
                    break;

                case PropertyType.VT_BOOL:
                    var shorts = new short[_ca.cElems];
                    size = _ca.cElems * Marshal.SizeOf(typeof(short));
                    CopyMemory(Marshal.UnsafeAddrOfPinnedArrayElement(shorts, 0), _ca.pElems, (IntPtr)size);
                    var bools = new bool[shorts.Length];
                    for (var i = 0; i < shorts.Length; i++)
                    {
                        bools[i] = shorts[i] != 0;
                    }
                    value = bools;
                    ret = true;
                    break;

                case PropertyType.VT_I1:
                case PropertyType.VT_UI1:
                case PropertyType.VT_I2:
                case PropertyType.VT_UI2:
                case PropertyType.VT_I4:
                case PropertyType.VT_INT:
                case PropertyType.VT_UI4:
                case PropertyType.VT_UINT:
                case PropertyType.VT_I8:
                case PropertyType.VT_UI8:
                case PropertyType.VT_R4:
                case PropertyType.VT_R8:
                case PropertyType.VT_ERROR:
                case PropertyType.VT_CY:
                case PropertyType.VT_DATE:
                case PropertyType.VT_FILETIME:
                case PropertyType.VT_CLSID:
                case PropertyType.VT_UNKNOWN:
                case PropertyType.VT_DISPATCH:
                    var et = FromType(vt);
                    var values = Array.CreateInstance(et, _ca.cElems);
                    size = _ca.cElems * Marshal.SizeOf(et);
                    CopyMemory(Marshal.UnsafeAddrOfPinnedArrayElement(values, 0), _ca.pElems, (IntPtr)size);
                    value = values;
                    ret = true;
                    break;
            }
            return ret;
        }

        public static PropVariant Deserialize(byte[] bytes, bool throwOnError = true)
        {
            if (bytes == null)
                throw new ArgumentNullException(nameof(bytes));

            var pv = new PropVariant();
            var hr = StgDeserializePropVariant(bytes, bytes.Length, pv);
            if (hr.IsError)
            {
                pv.Dispose();
                hr.ThrowOnError(throwOnError);
                return null;
            }

            return pv;
        }

        public static PropVariant Deserialize(IntPtr ptr, int size, bool throwOnError = true)
        {
            if (ptr == IntPtr.Zero)
                throw new ArgumentNullException(nameof(ptr));

            var pv = new PropVariant();
            var hr = StgDeserializePropVariant(ptr, size, pv);
            if (hr.IsError)
            {
                pv.Dispose();
                hr.ThrowOnError(throwOnError);
                return null;
            }

            return pv;
        }

        public static PropVariant FromVariant(object value, bool throwOnError = true)
        {
            if (value == null)
                return null;

            var pv = new PropVariant(); // empty
            VariantToPropVariant(value, pv).ThrowOnError(throwOnError);
            return pv;
        }

        public static PropVariant FromWinRTPropertyValue(IntPtr propertyValue, bool throwOnError = true)
        {
            if (propertyValue == IntPtr.Zero)
                return null;

            var pv = new PropVariant();
            var hr = WinRTPropertyValueToPropVariant(propertyValue, pv);
            hr.ThrowOnError(throwOnError);
            return hr.IsError ? null : pv;
        }

        private static void Using(object resource, Action action)
        {
            try
            {
                action();
            }
            finally
            {
                (resource as IDisposable)?.Dispose();
            }
        }

        private static int GetCount(IEnumerable enumerable)
        {
            if (enumerable is ICollection col)
                return col.Count;

            var count = 0;
            var e = enumerable.GetEnumerator();
            Using(e, () =>
            {
                while (e.MoveNext())
                {
                    count++;
                }
            });
            return count;
        }

        private static Type GetElementType(Type collectionType)
        {
            foreach (var iface in collectionType.GetInterfaces())
            {
                if (!iface.IsGenericType)
                    continue;

                if (iface.GetGenericTypeDefinition() == typeof(IEnumerable<>))
                    return iface.GetGenericArguments()[0];

                if (iface.GetGenericTypeDefinition() == typeof(ICollection<>))
                    return iface.GetGenericArguments()[0];

                if (iface.GetGenericTypeDefinition() == typeof(IList<>))
                    return iface.GetGenericArguments()[0];
            }
            return null;
        }

        private static Type GetElementType(IEnumerable enumerable)
        {
            var et = GetElementType(enumerable.GetType());
            if (et != null)
                return et;

            foreach (var obj in enumerable)
            {
                return obj.GetType();
            }
            return null;
        }

        private static Type FromType(PropertyType type)
        {
            switch (type)
            {
                case PropertyType.VT_I1:
                    return typeof(sbyte);

                case PropertyType.VT_UI1:
                    return typeof(byte);

                case PropertyType.VT_I2:
                    return typeof(short);

                case PropertyType.VT_UI2:
                    return typeof(ushort);

                case PropertyType.VT_UI4:
                case PropertyType.VT_UINT:
                    return typeof(uint);

                case PropertyType.VT_I8:
                    return typeof(long);

                case PropertyType.VT_UI8:
                    return typeof(ulong);

                case PropertyType.VT_R4:
                    return typeof(float);

                case PropertyType.VT_R8:
                    return typeof(double);

                case PropertyType.VT_BOOL:
                    return typeof(bool);

                case PropertyType.VT_I4:
                case PropertyType.VT_INT:
                case PropertyType.VT_ERROR:
                    return typeof(int);

                case PropertyType.VT_DATE:
                    return typeof(DateTime);

                case PropertyType.VT_FILETIME:
                    return typeof(System.Runtime.InteropServices.ComTypes.FILETIME);

                case PropertyType.VT_BLOB:
                    return typeof(byte[]);

                case PropertyType.VT_CLSID:
                    return typeof(Guid);

                case PropertyType.VT_BSTR:
                case PropertyType.VT_LPSTR:
                case PropertyType.VT_LPWSTR:
                    return typeof(string);

                case PropertyType.VT_UNKNOWN:
                case PropertyType.VT_DISPATCH:
                    return typeof(object);

                case PropertyType.VT_CY:
                case PropertyType.VT_DECIMAL:
                    return typeof(decimal);

                default:
                    throw new ArgumentException("Property type " + type + " is not supported.", nameof(type));
            }
        }

        private static IntPtr MarshalString(string str, PropertyType vt)
        {
            switch (vt)
            {
                case PropertyType.VT_LPWSTR:
                    return Marshal.StringToCoTaskMemUni(str);

                case PropertyType.VT_BSTR:
                    return Marshal.StringToBSTR(str);

                case PropertyType.VT_LPSTR:
                    return Marshal.StringToCoTaskMemAnsi(str);

                default:
                    throw new NotSupportedException("A string can only be of property type VT_LPWSTR, VT_LPSTR or VT_BSTR.");
            }
        }

        private static PropertyType FromType(Type type, PropertyType? vt)
        {
            if (type == null)
                return PropertyType.VT_NULL;

            var tc = Type.GetTypeCode(type);
            switch (tc)
            {
                case TypeCode.Boolean:
                    return PropertyType.VT_BOOL;

                case TypeCode.Byte:
                    return PropertyType.VT_UI1;

                case TypeCode.Char:
                    return PropertyType.VT_LPWSTR;

                case TypeCode.DateTime:
                    if (vt == PropertyType.VT_FILETIME)
                        return PropertyType.VT_FILETIME;

                    return PropertyType.VT_DATE;

                case TypeCode.DBNull:
                    return PropertyType.VT_NULL;

                case TypeCode.Decimal:
                    return PropertyType.VT_DECIMAL;

                case TypeCode.Double:
                    return PropertyType.VT_R8;

                case TypeCode.Empty:
                    return PropertyType.VT_EMPTY;

                case TypeCode.Int16:
                    return PropertyType.VT_I2;

                case TypeCode.Int32:
                    return PropertyType.VT_I4;

                case TypeCode.Int64:
                    return PropertyType.VT_I8;

                case TypeCode.SByte:
                    return PropertyType.VT_I1;

                case TypeCode.Single:
                    return PropertyType.VT_R4;

                case TypeCode.String:
                    if (!vt.HasValue)
                        return PropertyType.VT_LPWSTR;

                    if (vt != PropertyType.VT_LPSTR && vt != PropertyType.VT_BSTR && vt != PropertyType.VT_LPWSTR)
                        throw new ArgumentException("Property type " + vt + " is not supported for string.", nameof(type));

                    return vt.Value;

                case TypeCode.UInt16:
                    return PropertyType.VT_UI2;

                case TypeCode.UInt32:
                    return PropertyType.VT_UI4;

                case TypeCode.UInt64:
                    return PropertyType.VT_UI8;

                // case TypeCode.Object:
                default:
                    if (type == typeof(Guid))
                        return PropertyType.VT_CLSID;

                    if (type == typeof(System.Runtime.InteropServices.ComTypes.FILETIME))
                        return PropertyType.VT_FILETIME;

                    if (type == typeof(byte))
                    {
                        if (!vt.HasValue)
                            return PropertyType.VT_UI1 | PropertyType.VT_VECTOR;

                        if (vt != PropertyType.VT_BLOB && vt != (PropertyType.VT_UI1 | PropertyType.VT_VECTOR))
                            throw new ArgumentException("Property type " + vt + " is not supported for array of bytes.", nameof(type));

                        return vt.Value;
                    }

                    if (type == typeof(object))
                        return PropertyType.VT_VARIANT;

                    throw new ArgumentException("Value of type '" + type.FullName + "' is not supported.", nameof(type));
            }
        }

        private static readonly Guid IID_IPropertyValue = new Guid("4bd682dd-7554-40e9-9a9b-82654ede7e62");

        [DllImport("propsys", ExactSpelling = true)]
        private extern static HRESULT PropVariantToWinRTPropertyValue(PropVariant propvar, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, out IntPtr ppv);

        [DllImport("propsys", ExactSpelling = true)]
        private extern static HRESULT PropVariantToWinRTPropertyValue(PropVariant propvar, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppv);

        [DllImport("propsys", ExactSpelling = true)]
        private extern static HRESULT WinRTPropertyValueToPropVariant(IntPtr punkPropertyValue, [Out] PropVariant ppropvar);

        [DllImport("propsys", ExactSpelling = true)]
        private extern static HRESULT StgDeserializePropVariant(IntPtr ppProp, int cbMax, [Out] PropVariant ppropvar);

        [DllImport("propsys", ExactSpelling = true)]
        private extern static HRESULT StgDeserializePropVariant([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] ppProp, int cbMax, [Out] PropVariant ppropvar);

        [DllImport("propsys", ExactSpelling = true)]
        private extern static HRESULT StgSerializePropVariant(PropVariant ppropvar, out IntPtr ppProp, out int pcb);

        [DllImport("ole32", ExactSpelling = true)]
        private extern static HRESULT PropVariantClear([In, Out] PropVariant pvar);

        [DllImport("ole32", ExactSpelling = true)]
        private extern static HRESULT PropVariantCopy([In, Out] PropVariant pvarDest, PropVariant pvarSrc);

        [DllImport("propsys", ExactSpelling = true)]
        private static extern HRESULT InitPropVariantFromFileTime(ref long pftIn, [Out] PropVariant ppropvar);

        [DllImport("propsys", ExactSpelling = true)]
        private static extern HRESULT PropVariantToVariant(PropVariant pPropVar, out object pVar);

        [DllImport("propsys", ExactSpelling = true)]
        private static extern HRESULT VariantToPropVariant(object pVar, [Out] PropVariant pv);

        [DllImport("propsys", ExactSpelling = true)]
        private static extern HRESULT PropVariantChangeType([Out] PropVariant ppropvarDest, PropVariant propvarSrc, int flags, PropertyType vt);

        [DllImport("kernel32", ExactSpelling = true, EntryPoint = "RtlMoveMemory")]
        internal static extern void CopyMemory(IntPtr destination, IntPtr source, IntPtr length);
    }
}
