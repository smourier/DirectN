// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(3279,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("514039c6-4617-4064-bf8b-92ea83e506e0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontCollection2 : IDWriteFontCollection1
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
        HRESULT GetFontFamily(uint index, /* _COM_Outptr_ */ out IDWriteFontFamily2 fontFamily);
        
        [PreserveSig]
        HRESULT GetMatchingFonts(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string familyName, /* _In_reads_(fontAxisValueCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, int fontAxisValueCount, /* _COM_Outptr_ */ out IDWriteFontList2 fontList);
        
        [PreserveSig]
        DWRITE_FONT_FAMILY_MODEL GetFontFamilyModel();
        
        [PreserveSig]
        HRESULT GetFontSet(/* _COM_Outptr_ */ out IDWriteFontSet1 fontSet);
    }
}
