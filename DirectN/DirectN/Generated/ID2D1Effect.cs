// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(1299,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The effect interface. Properties control how the effect is rendered. The effect is Drawn with the DrawImage call.
    /// </summary>
    [ComImport, Guid("28211a43-7d89-476f-8181-2d6159b220ad"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Effect : ID2D1Properties
    {
        // ID2D1Properties
        [PreserveSig]
        new uint GetPropertyCount();
        
        [PreserveSig]
        new HRESULT GetPropertyName(uint index, /* _Out_writes_(nameCount) */ [MarshalAs(UnmanagedType.LPWStr)] string name, uint nameCount);
        
        [PreserveSig]
        new uint GetPropertyNameLength(uint index);
        
        [PreserveSig]
        new D2D1_PROPERTY_TYPE GetType(uint index);
        
        [PreserveSig]
        new uint GetPropertyIndex(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name);
        
        [PreserveSig]
        new HRESULT SetValueByName(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, D2D1_PROPERTY_TYPE type, /* _In_reads_(dataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, int dataSize);
        
        [PreserveSig]
        new HRESULT SetValue(uint index, D2D1_PROPERTY_TYPE type, /* _In_reads_(dataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, int dataSize);
        
        [PreserveSig]
        new HRESULT GetValueByName(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string name, D2D1_PROPERTY_TYPE type, /* _Out_writes_(dataSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, int dataSize);
        
        [PreserveSig]
        new HRESULT GetValue(uint index, D2D1_PROPERTY_TYPE type, /* _Out_writes_(dataSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, int dataSize);
        
        [PreserveSig]
        new uint GetValueSize(uint index);
        
        [PreserveSig]
        new HRESULT GetSubProperties(uint index, /* _COM_Outptr_result_maybenull_ */ out ID2D1Properties subProperties);
        
        // ID2D1Effect
        [PreserveSig]
        void SetInput(uint index, /* _In_opt_ */ ID2D1Image input, bool invalidate);
        
        [PreserveSig]
        HRESULT SetInputCount(uint inputCount);
        
        [PreserveSig]
        void GetInput(uint index, /* _Outptr_result_maybenull_ */ out ID2D1Image input);
        
        [PreserveSig]
        uint GetInputCount();
        
        [PreserveSig]
        void GetOutput(/* _Outptr_ */ out ID2D1Image outputImage);
    }
}
