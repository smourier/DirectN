using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ef8a8135-5cc6-45fe-8825-c5a0724eb819"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDWriteTextRenderer : IDWritePixelSnapping
    {
        // IDWritePixelSnapping
        [PreserveSig]
        new HRESULT IsPixelSnappingDisabled(IntPtr clientDrawingContext, out bool isDisabled);

        [PreserveSig]
        new HRESULT GetCurrentTransform(IntPtr clientDrawingContext, out DWRITE_MATRIX transform);

        [PreserveSig]
        new HRESULT GetPixelsPerDip(IntPtr clientDrawingContext, out float pixelsPerDip);

        // IDWriteTextRenderer 
        [PreserveSig]
        HRESULT DrawGlyphRun(
            IntPtr clientDrawingContext,
            float baselineOriginX,
            float baselineOriginY,
            DWRITE_MEASURING_MODE measuringMode,
            ref DWRITE_GLYPH_RUN glyphRun,
            ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription,
            [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect
        );

        [PreserveSig]
        HRESULT DrawUnderline(
            IntPtr clientDrawingContext,
            float baselineOriginX,
            float baselineOriginY,
            ref DWRITE_UNDERLINE underline,
            [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect
        );

        [PreserveSig]
        HRESULT DrawStrikethrough(
            int clientDrawingContext,
            float baselineOriginX,
            float baselineOriginY,
            ref DWRITE_STRIKETHROUGH strikethrough,
            [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect
        );

        [PreserveSig]
        HRESULT DrawInlineObject(
            IntPtr clientDrawingContext,
            float originX,
            float originY,
            IDWriteInlineObject inlineObject,
            bool isSideways,
            bool isRightToLeft,
            [MarshalAs(UnmanagedType.IUnknown)] object clientDrawingEffect
        );
    }
}
