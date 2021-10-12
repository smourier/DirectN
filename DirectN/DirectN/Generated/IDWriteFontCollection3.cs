// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(3509,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a4d055a6-f9e3-4e25-93b7-9e309f3af8e9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontCollection3 : IDWriteFontCollection2
    {
        // IDWriteFontCollection
        [PreserveSig]
        new uint GetFontFamilyCount();
        
        [PreserveSig]
        new HRESULT GetFontFamily(uint index, /* _COM_Outptr_ */ out IDWriteFontFamily fontFamily);
        
        [PreserveSig]
        new HRESULT FindFamilyName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string familyName, /* _Out_ */ out uint index, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        new HRESULT GetFontFromFontFace(/* _In_ */ IDWriteFontFace fontFace, /* _COM_Outptr_ */ out IDWriteFont font);
        
        // IDWriteFontCollection1
        [PreserveSig]
        new HRESULT GetFontSet(/* _COM_Outptr_ */ out IDWriteFontSet fontSet);
        
        [PreserveSig]
        new HRESULT GetFontFamily(uint index, /* _COM_Outptr_ */ out IDWriteFontFamily1 fontFamily);
        
        // IDWriteFontCollection2
        [PreserveSig]
        new HRESULT GetFontFamily(uint index, /* _COM_Outptr_ */ out IDWriteFontFamily2 fontFamily);
        
        [PreserveSig]
        new HRESULT GetMatchingFonts(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string familyName, /* _In_reads_(fontAxisValueCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, int fontAxisValueCount, /* _COM_Outptr_ */ out IDWriteFontList2 fontList);
        
        [PreserveSig]
        new DWRITE_FONT_FAMILY_MODEL GetFontFamilyModel();
        
        [PreserveSig]
        new HRESULT GetFontSet(/* _COM_Outptr_ */ out IDWriteFontSet1 fontSet);
        
        // IDWriteFontCollection3
        [PreserveSig]
        IntPtr GetExpirationEvent();
    }
}
