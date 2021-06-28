// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite_3.h(791,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("53585141-d9f8-4095-8321-d73cf6bd116c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontCollection1 : IDWriteFontCollection
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
        HRESULT GetFontSet(/* _COM_Outptr_ */ out IDWriteFontSet fontSet);
        
        [PreserveSig]
        HRESULT GetFontFamily(uint index, /* _COM_Outptr_ */ out IDWriteFontFamily1 fontFamily);
    }
}
