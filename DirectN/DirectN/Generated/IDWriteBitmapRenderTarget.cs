// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(4420,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Encapsulates a 32-bit device independent bitmap and device context, which can be used for rendering glyphs.
    /// </summary>
    [ComImport, Guid("5e5a32a3-8dff-4773-9ff6-0696eab77267"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteBitmapRenderTarget
    {
        [PreserveSig]
        HRESULT DrawGlyphRun(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_ */ IDWriteRenderingParams renderingParams, uint textColor, /* optional(tagRECT) */ IntPtr blackBoxRect);
        
        [PreserveSig]
        IntPtr GetMemoryDC();
        
        [PreserveSig]
        float GetPixelsPerDip();
        
        [PreserveSig]
        HRESULT SetPixelsPerDip(float pixelsPerDip);
        
        [PreserveSig]
        HRESULT GetCurrentTransform(/* _Out_ */ out DWRITE_MATRIX transform);
        
        [PreserveSig]
        HRESULT SetCurrentTransform(/* optional(DWRITE_MATRIX) */ IntPtr transform);
        
        [PreserveSig]
        HRESULT GetSize(/* _Out_ */ out tagSIZE size);
        
        [PreserveSig]
        HRESULT Resize(uint width, uint height);
    }
}
