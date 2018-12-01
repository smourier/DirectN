// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_2.h(673,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface that represents an absolute reference to a font face. It contains font face type, appropriate file references and face identification data. Various font data such as metrics, names and glyph outlines is obtained from IDWriteFontFace.
    /// </summary>
    [Guid("d8b768ff-64bc-4e66-982b-ec8e87f693f7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFace2
    {
        [PreserveSig]
        bool IsColorFont();
        
        [PreserveSig]
        uint GetColorPaletteCount();
        
        [PreserveSig]
        uint GetPaletteEntryCount();
        
        [PreserveSig]
        HRESULT GetPaletteEntries(uint colorPaletteIndex, uint firstEntryIndex, uint entryCount, /* _Out_writes_(entryCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] _D3DCOLORVALUE[] paletteEntries);
        
        [PreserveSig]
        HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, /* _In_opt_ */ ref DWRITE_MATRIX transform, bool isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, /* _In_opt_ */ ref IDWriteRenderingParams renderingParams, /* _Out_ */ out DWRITE_RENDERING_MODE renderingMode, /* _Out_ */ out DWRITE_GRID_FIT_MODE gridFitMode);
    }
}
