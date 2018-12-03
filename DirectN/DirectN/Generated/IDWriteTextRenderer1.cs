// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_2.h(83,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The text renderer interface represents a set of application-defined callbacks that perform rendering of text, inline objects, and decorations such as underlines.
    /// </summary>
    [Guid("d3e0e934-22a0-427e-aae4-7d9574b59db1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextRenderer1 : IDWriteTextRenderer
    {
        // IDWritePixelSnapping
        [PreserveSig]
        new HRESULT IsPixelSnappingDisabled(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, /* _Out_ */ out bool isDisabled);
        
        [PreserveSig]
        new HRESULT GetCurrentTransform(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, /* _Out_ */ out DWRITE_MATRIX transform);
        
        [PreserveSig]
        new HRESULT GetPixelsPerDip(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, /* _Out_ */ out float pixelsPerDip);
        
        // IDWriteTextRenderer
        [PreserveSig]
        new HRESULT DrawGlyphRun(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_ */ ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        new HRESULT DrawUnderline(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, float baselineOriginX, float baselineOriginY, /* _In_ */ ref DWRITE_UNDERLINE underline, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        new HRESULT DrawStrikethrough(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, float baselineOriginX, float baselineOriginY, /* _In_ */ ref DWRITE_STRIKETHROUGH strikethrough, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        new HRESULT DrawInlineObject(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, float originX, float originY, /* _In_ */ IDWriteInlineObject inlineObject, bool isSideways, bool isRightToLeft, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        // IDWriteTextRenderer1
        [PreserveSig]
        HRESULT DrawGlyphRun(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, DWRITE_MEASURING_MODE measuringMode, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_ */ ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        HRESULT DrawUnderline(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, /* _In_ */ ref DWRITE_UNDERLINE underline, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        HRESULT DrawStrikethrough(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, /* _In_ */ ref DWRITE_STRIKETHROUGH strikethrough, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        HRESULT DrawInlineObject(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, float originX, float originY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, /* _In_ */ IDWriteInlineObject inlineObject, bool isSideways, bool isRightToLeft, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
    }
}
