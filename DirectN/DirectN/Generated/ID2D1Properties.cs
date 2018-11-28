using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("483473d7-cd46-4f9d-9d3a-3112aa80159d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1Properties
    {
        [PreserveSig]
        int GetPropertyCount();

        [PreserveSig]
        HRESULT GetPropertyName(int index, [MarshalAs(UnmanagedType.LPWStr)] string name, int nameCount);

        [PreserveSig]
        int GetPropertyNameLength(int index);

        [PreserveSig]
        D2D1_PROPERTY_TYPE GetType(int index);

        [PreserveSig]
        int GetPropertyIndex([MarshalAs(UnmanagedType.LPWStr)] string name);

        [PreserveSig]
        HRESULT SetValueByName([MarshalAs(UnmanagedType.LPWStr)] string name, D2D1_PROPERTY_TYPE type, byte[] data, int dataSize);

        [PreserveSig]
        HRESULT SetValue(int index, D2D1_PROPERTY_TYPE type, byte[] data, int dataSize);

        [PreserveSig]
        HRESULT GetValueByName([MarshalAs(UnmanagedType.LPWStr)] string name, D2D1_PROPERTY_TYPE type, [In, Out] byte[] data, int dataSize);

        [PreserveSig]
        HRESULT GetValue(int index, D2D1_PROPERTY_TYPE type, [In, Out] byte[] data, int dataSize);

        [PreserveSig]
        int GetValueSize(int index);

        [PreserveSig]
        HRESULT GetSubProperties(int index, out ID2D1Properties subProperties);
    }
}
