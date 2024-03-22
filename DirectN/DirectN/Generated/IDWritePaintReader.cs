// generated from <Windows SDK Path>\um\dwrite_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Interface used to read color glyph data for a specific font. A color glyph is represented as a visual tree of paint elements.
    /// </summary>
    [ComImport, Guid("8128e912-3b97-42a5-ab6c-24aad3a86e54"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWritePaintReader
    {
        [PreserveSig]
        HRESULT SetCurrentGlyph(uint glyphIndex, /* _Out_writes_bytes_(structSize) */ IntPtr paintElement, uint structSize, /* _Out_ */ out D2D_RECT_F clipBox, /* optional(DWRITE_PAINT_ATTRIBUTES) */ IntPtr glyphAttributes);
        
        [PreserveSig]
        HRESULT SetTextColor(ref _D3DCOLORVALUE textColor);
        
        [PreserveSig]
        HRESULT SetColorPaletteIndex(uint colorPaletteIndex);
        
        [PreserveSig]
        HRESULT SetCustomColorPalette(/* _In_reads_(paletteEntryCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _D3DCOLORVALUE[] paletteEntries, int paletteEntryCount);
        
        [PreserveSig]
        HRESULT MoveToFirstChild(/* _Out_writes_bytes_(structSize) */ IntPtr paintElement, uint structSize);
        
        [PreserveSig]
        HRESULT MoveToNextSibling(/* _Out_writes_bytes_(structSize) */ IntPtr paintElement, uint structSize);
        
        [PreserveSig]
        HRESULT MoveToParent();
        
        [PreserveSig]
        HRESULT GetGradientStops(uint firstGradientStopIndex, int gradientStopCount, /* _Out_writes_(gradientStopCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_GRADIENT_STOP[] gradientStops);
        
        [PreserveSig]
        HRESULT GetGradientStopColors(uint firstGradientStopIndex, int gradientStopCount, /* _Out_writes_(gradientStopCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_PAINT_COLOR[] gradientStopColors);
    }
}
