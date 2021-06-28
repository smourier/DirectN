// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(1455,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The IDWriteFontCollection encapsulates a collection of font families.
    /// </summary>
    [ComImport, Guid("a84cee02-3eea-4eee-a827-87c1a02a0fcc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontCollection
    {
        [PreserveSig]
        uint GetFontFamilyCount();
        
        [PreserveSig]
        HRESULT GetFontFamily(uint index, /* _COM_Outptr_ */ out IDWriteFontFamily fontFamily);
        
        [PreserveSig]
        HRESULT FindFamilyName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string familyName, /* _Out_ */ out uint index, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        HRESULT GetFontFromFontFace(/* _In_ */ IDWriteFontFace fontFace, /* _COM_Outptr_ */ out IDWriteFont font);
    }
}
