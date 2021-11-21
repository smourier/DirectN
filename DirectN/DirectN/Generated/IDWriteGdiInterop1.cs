// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_3.h(1552,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The GDI interop interface provides interoperability with GDI.
    /// </summary>
    [ComImport, Guid("4556be70-3abd-4f70-90be-421780a6f515"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteGdiInterop1 : IDWriteGdiInterop
    {
        // IDWriteGdiInterop
        [PreserveSig]
        new HRESULT CreateFontFromLOGFONT(/* _In_ */ ref tagLOGFONTW logFont, /* _COM_Outptr_ */ out IDWriteFont font);
        
        [PreserveSig]
        new HRESULT ConvertFontToLOGFONT(/* _In_ */ IDWriteFont font, /* _Out_ */ out tagLOGFONTW logFont, /* _Out_ */ out bool isSystemFont);
        
        [PreserveSig]
        new HRESULT ConvertFontFaceToLOGFONT(/* _In_ */ IDWriteFontFace font, /* _Out_ */ out tagLOGFONTW logFont);
        
        [PreserveSig]
        new HRESULT CreateFontFaceFromHdc(IntPtr hdc, /* _COM_Outptr_ */ out IDWriteFontFace fontFace);
        
        [PreserveSig]
        new HRESULT CreateBitmapRenderTarget(/* optional(HDC__) */ IntPtr hdc, uint width, uint height, /* _COM_Outptr_ */ out IDWriteBitmapRenderTarget renderTarget);
        
        // IDWriteGdiInterop1
        [PreserveSig]
        HRESULT CreateFontFromLOGFONT(/* _In_ */ ref tagLOGFONTW logFont, /* _In_opt_ */ IDWriteFontCollection fontCollection, /* _COM_Outptr_ */ out IDWriteFont font);
        
        [PreserveSig]
        HRESULT GetFontSignature(/* _In_ */ IDWriteFontFace fontFace, /* _Out_ */ out tagFONTSIGNATURE fontSignature);
        
        [PreserveSig]
        HRESULT GetFontSignature(/* _In_ */ IDWriteFont font, /* _Out_ */ out tagFONTSIGNATURE fontSignature);
        
        [PreserveSig]
        HRESULT GetMatchingFontsByLOGFONT(/* _In_ */ ref tagLOGFONTW logFont, /* _In_ */ IDWriteFontSet fontSet, /* _COM_Outptr_ */ out IDWriteFontSet filteredSet);
    }
}
