// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_2.h(253,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The format of text used for text layout.  <remarks> This object may not be thread-safe and it may carry the state of text format change. </remarks>
    /// </summary>
    [Guid("5f174b49-0d8b-4cfb-8bca-f1cce9d06c67"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextFormat1
    {
        [PreserveSig]
        HRESULT SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation);
        
        [PreserveSig]
        DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation();
        
        [PreserveSig]
        HRESULT SetLastLineWrapping(bool isLastLineWrappingEnabled);
        
        [PreserveSig]
        bool GetLastLineWrapping();
        
        [PreserveSig]
        HRESULT SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment);
        
        [PreserveSig]
        DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment();
        
        [PreserveSig]
        HRESULT SetFontFallback(IDWriteFontFallback fontFallback);
        
        [PreserveSig]
        HRESULT GetFontFallback(/* __out */ out IDWriteFontFallback fontFallback);
    }
}
