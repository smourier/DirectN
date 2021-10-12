// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite.h(4540,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The GDI interop interface provides interoperability with GDI.
    /// </summary>
    [ComImport, Guid("1edd9491-9853-4299-898f-6432983b6f3a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteGdiInterop
    {
        [PreserveSig]
        HRESULT CreateFontFromLOGFONT(/* _In_ */ ref tagLOGFONTW logFont, /* _COM_Outptr_ */ out IDWriteFont font);
        
        [PreserveSig]
        HRESULT ConvertFontToLOGFONT(/* _In_ */ IDWriteFont font, /* _Out_ */ out tagLOGFONTW logFont, /* _Out_ */ out bool isSystemFont);
        
        [PreserveSig]
        HRESULT ConvertFontFaceToLOGFONT(/* _In_ */ IDWriteFontFace font, /* _Out_ */ out tagLOGFONTW logFont);
        
        [PreserveSig]
        HRESULT CreateFontFaceFromHdc(IntPtr hdc, /* _COM_Outptr_ */ out IDWriteFontFace fontFace);
        
        [PreserveSig]
        HRESULT CreateBitmapRenderTarget(/* optional(HDC__) */ IntPtr hdc, uint width, uint height, /* _COM_Outptr_ */ out IDWriteBitmapRenderTarget renderTarget);
    }
}
