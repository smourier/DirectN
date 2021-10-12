// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_2.h(83,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The text renderer interface represents a set of application-defined callbacks that perform rendering of text, inline objects, and decorations such as underlines.
    /// </summary>
    [ComImport, Guid("d3e0e934-22a0-427e-aae4-7d9574b59db1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextRenderer1 : IDWriteTextRenderer
    {
        // IDWritePixelSnapping
        [PreserveSig]
        new HRESULT IsPixelSnappingDisabled(/* optional(void) */ IntPtr clientDrawingContext, /* _Out_ */ out bool isDisabled);
        
        [PreserveSig]
        new HRESULT GetCurrentTransform(/* optional(void) */ IntPtr clientDrawingContext, /* _Out_ */ out DWRITE_MATRIX transform);
        
        [PreserveSig]
        new HRESULT GetPixelsPerDip(/* optional(void) */ IntPtr clientDrawingContext, /* _Out_ */ out float pixelsPerDip);
        
        // IDWriteTextRenderer
        [PreserveSig]
        new HRESULT DrawGlyphRun(/* optional(void) */ IntPtr clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_ */ ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        new HRESULT DrawUnderline(/* optional(void) */ IntPtr clientDrawingContext, float baselineOriginX, float baselineOriginY, /* _In_ */ ref DWRITE_UNDERLINE underline, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        new HRESULT DrawStrikethrough(/* optional(void) */ IntPtr clientDrawingContext, float baselineOriginX, float baselineOriginY, /* _In_ */ ref DWRITE_STRIKETHROUGH strikethrough, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        new HRESULT DrawInlineObject(/* optional(void) */ IntPtr clientDrawingContext, float originX, float originY, /* _In_ */ IDWriteInlineObject inlineObject, bool isSideways, bool isRightToLeft, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        // IDWriteTextRenderer1
    }
}
