// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(1552,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The GDI interop interface provides interoperability with GDI.
    /// </summary>
    [Guid("4556be70-3abd-4f70-90be-421780a6f515"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteGdiInterop1
    {
        [PreserveSig]
        HRESULT CreateFontFromLOGFONT(/* _In_ */ ref tagLOGFONTW logFont, /* _In_opt_ */ ref IDWriteFontCollection fontCollection, /* _COM_Outptr_ */ out IDWriteFont font);
        
        [PreserveSig]
        HRESULT GetFontSignature(/* _In_ */ ref IDWriteFont font, /* _Out_ */ out tagFONTSIGNATURE fontSignature);
        
        [PreserveSig]
        HRESULT GetFontSignature(/* _In_ */ ref IDWriteFontFace fontFace, /* _Out_ */ out tagFONTSIGNATURE fontSignature);
        
        [PreserveSig]
        HRESULT GetMatchingFontsByLOGFONT(/* _In_ */ ref tagLOGFONTA logFont, /* _In_ */ IDWriteFontSet fontSet, /* _COM_Outptr_ */ out IDWriteFontSet filteredSet);
    }
}
