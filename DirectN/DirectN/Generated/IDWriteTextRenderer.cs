// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite.h(3633,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ef8a8135-5cc6-45fe-8825-c5a0724eb819"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteTextRenderer : IDWritePixelSnapping
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
        HRESULT DrawGlyphRun(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_ */ ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        HRESULT DrawUnderline(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, float baselineOriginX, float baselineOriginY, /* _In_ */ ref DWRITE_UNDERLINE underline, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        HRESULT DrawStrikethrough(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, float baselineOriginX, float baselineOriginY, /* _In_ */ ref DWRITE_STRIKETHROUGH strikethrough, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
        
        [PreserveSig]
        HRESULT DrawInlineObject(/* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingContext, float originX, float originY, /* _In_ */ IDWriteInlineObject inlineObject, bool isSideways, bool isRightToLeft, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect);
    }
}
