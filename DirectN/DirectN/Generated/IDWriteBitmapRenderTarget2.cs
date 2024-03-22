// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Encapsulates a bitmap which can be used for rendering glyphs.
    /// </summary>
    [ComImport, Guid("c553a742-fc01-44da-a66e-b8b9ed6c3995"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteBitmapRenderTarget2 : IDWriteBitmapRenderTarget1
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
        new DWRITE_TEXT_ANTIALIAS_MODE GetTextAntialiasMode();
        
        [PreserveSig]
        new HRESULT SetTextAntialiasMode(DWRITE_TEXT_ANTIALIAS_MODE antialiasMode);
        
        // IDWriteBitmapRenderTarget2
        [PreserveSig]
        HRESULT GetBitmapData(/* _Out_ */ out DWRITE_BITMAP_DATA_BGRA32 bitmapData);
    }
}
