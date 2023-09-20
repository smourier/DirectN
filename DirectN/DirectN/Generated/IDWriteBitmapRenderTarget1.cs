// generated from <Windows SDK Path>\um\dwrite_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Encapsulates a 32-bit device independent bitmap and device context, which can be used for rendering glyphs.
    /// </summary>
    [ComImport, Guid("791e8298-3ef3-4230-9880-c9bdecc42064"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteBitmapRenderTarget1 : IDWriteBitmapRenderTarget
    {
        // IDWriteBitmapRenderTarget
        [PreserveSig]
        new HRESULT DrawGlyphRun(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_ */ IDWriteRenderingParams renderingParams, uint textColor, /* optional(tagRECT) */ IntPtr blackBoxRect);
        
        [PreserveSig]
        new IntPtr GetMemoryDC();
        
        [PreserveSig]
        new float GetPixelsPerDip();
        
        [PreserveSig]
        new HRESULT SetPixelsPerDip(float pixelsPerDip);
        
        [PreserveSig]
        new HRESULT GetCurrentTransform(/* _Out_ */ out DWRITE_MATRIX transform);
        
        [PreserveSig]
        new HRESULT SetCurrentTransform(/* optional(DWRITE_MATRIX) */ IntPtr transform);
        
        [PreserveSig]
        new HRESULT GetSize(/* _Out_ */ out tagSIZE size);
        
        [PreserveSig]
        new HRESULT Resize(uint width, uint height);
        
        // IDWriteBitmapRenderTarget1
        [PreserveSig]
        DWRITE_TEXT_ANTIALIAS_MODE GetTextAntialiasMode();
        
        [PreserveSig]
        HRESULT SetTextAntialiasMode(DWRITE_TEXT_ANTIALIAS_MODE antialiasMode);
    }
}
