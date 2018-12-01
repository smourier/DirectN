// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_2.h(83,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The text renderer interface represents a set of application-defined callbacks that perform rendering of text, inline objects, and decorations such as underlines.
    /// </summary>
    [Guid("d3e0e934-22a0-427e-aae4-7d9574b59db1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextRenderer1
    {
        [PreserveSig]
        HRESULT DrawGlyphRun(/* _In_opt_ */ IntPtr clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, DWRITE_MEASURING_MODE measuringMode, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_ */ ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        HRESULT DrawUnderline(/* _In_opt_ */ IntPtr clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, /* _In_ */ ref DWRITE_UNDERLINE underline, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        HRESULT DrawStrikethrough(/* _In_opt_ */ IntPtr clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, /* _In_ */ ref DWRITE_STRIKETHROUGH strikethrough, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        HRESULT DrawInlineObject(/* _In_opt_ */ IntPtr clientDrawingContext, float originX, float originY, DWRITE_GLYPH_ORIENTATION_ANGLE orientationAngle, /* _In_ */ ref IDWriteInlineObject inlineObject, bool isSideways, bool isRightToLeft, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
    }
}
