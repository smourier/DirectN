using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("28211a43-7d89-476f-8181-2d6159b220ad"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1Effect : ID2D1Properties
    {
        // ID2D1Properties
        [PreserveSig]
        new int GetPropertyCount();

        [PreserveSig]
        new HRESULT GetPropertyName(int index, [MarshalAs(UnmanagedType.LPWStr)] string name, int nameCount);

        [PreserveSig]
        new int GetPropertyNameLength(int index);

        [PreserveSig]
        new D2D1_PROPERTY_TYPE GetType(int index);

        [PreserveSig]
        new int GetPropertyIndex([MarshalAs(UnmanagedType.LPWStr)] string name);

        [PreserveSig]
        new HRESULT SetValueByName([MarshalAs(UnmanagedType.LPWStr)] string name, D2D1_PROPERTY_TYPE type, byte[] data, int dataSize);

        [PreserveSig]
        new HRESULT SetValue(int index, D2D1_PROPERTY_TYPE type, byte[] data, int dataSize);

        [PreserveSig]
        new HRESULT GetValueByName([MarshalAs(UnmanagedType.LPWStr)] string name, D2D1_PROPERTY_TYPE type, [In, Out] byte[] data, int dataSize);

        [PreserveSig]
        new HRESULT GetValue(int index, D2D1_PROPERTY_TYPE type, [In, Out] byte[] data, int dataSize);

        [PreserveSig]
        new int GetValueSize(int index);

        [PreserveSig]
        new HRESULT GetSubProperties(int index, out ID2D1Properties subProperties);

        // ID2D1Effect
        [PreserveSig]
        void SetInput(int index, ID2D1Image input, bool invalidate);

        [PreserveSig]
        HRESULT SetInputCount(int inputCount);

        [PreserveSig]
        void GetInput(int index, out ID2D1Image input);

        [PreserveSig]
        int GetInputCount();

        [PreserveSig]
        void GetOutput(out ID2D1Image outputImage);
    }
}
