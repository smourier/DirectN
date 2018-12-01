// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_2.h(335,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The text layout interface represents a block of text after it has been fully analyzed and formatted.
    /// </summary>
    [Guid("1093c18f-8d5e-43f0-b064-0917311b525e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextLayout2
    {
        [PreserveSig]
        HRESULT GetMetrics(/* _Out_ */ out DWRITE_TEXT_METRICS1 textMetrics);
        
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
