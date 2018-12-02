// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(1552,1)
using System;
using System.Runtime.InteropServices;
using FONTSIGNATURE = DirectN.tagFONTSIGNATURE;
using LOGFONT = DirectN.tagLOGFONTW;
using LOGFONTW = DirectN.tagLOGFONTW;

namespace DirectN
{
    /// <summary>
    /// The GDI interop interface provides interoperability with GDI.
    /// </summary>
    [Guid("4556be70-3abd-4f70-90be-421780a6f515"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteGdiInterop1 : IDWriteGdiInterop
    {
        // IDWriteGdiInterop
        [PreserveSig]
        new HRESULT CreateFontFromLOGFONT(/* _In_ */ ref LOGFONTW logFont, /* _COM_Outptr_ */ out IDWriteFont font);
        
        [PreserveSig]
        new HRESULT ConvertFontToLOGFONT(/* _In_ */ IDWriteFont font, /* _Out_ */ out LOGFONTW logFont, /* _Out_ */ out bool isSystemFont);
        
        [PreserveSig]
        new HRESULT ConvertFontFaceToLOGFONT(/* _In_ */ IDWriteFontFace font, /* _Out_ */ out LOGFONTW logFont);
        
        [PreserveSig]
        new HRESULT CreateFontFaceFromHdc(ref IntPtr hdc, /* _COM_Outptr_ */ out IDWriteFontFace fontFace);
        
        [PreserveSig]
        new HRESULT CreateBitmapRenderTarget(/* optional(HDC) */ IntPtr hdc, uint width, uint height, /* _COM_Outptr_ */ out IDWriteBitmapRenderTarget renderTarget);
        
        // IDWriteGdiInterop1
        [PreserveSig]
        HRESULT CreateFontFromLOGFONT(/* _In_ */ ref LOGFONTW logFont, /* _In_opt_ */ IDWriteFontCollection fontCollection, /* _COM_Outptr_ */ out IDWriteFont font);
        
        [PreserveSig]
        HRESULT GetFontSignature(/* _In_ */ IDWriteFont font, /* _Out_ */ out FONTSIGNATURE fontSignature);
        
        [PreserveSig]
        HRESULT GetFontSignature(/* _In_ */ IDWriteFontFace fontFace, /* _Out_ */ out FONTSIGNATURE fontSignature);
        
        [PreserveSig]
        HRESULT GetMatchingFontsByLOGFONT(/* _In_ */ ref LOGFONT logFont, /* _In_ */ IDWriteFontSet fontSet, /* _COM_Outptr_ */ out IDWriteFontSet filteredSet);
    }
}
