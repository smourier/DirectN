// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(1901,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface that represents an absolute reference to a font face. It contains font face type, appropriate file references and face identification data. Various font data such as metrics, names and glyph outlines is obtained from IDWriteFontFace.
    /// </summary>
    [Guid("27f2a904-4eb8-441d-9678-0563f53e3e2f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFace4 : IDWriteFontFace3
    {
        // IDWriteFontFace3
        [PreserveSig]
        new HRESULT GetFontFaceReference(/* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        new void GetPanose(/* _Out_ */ out DWRITE_PANOSE panose);
        
        [PreserveSig]
        new DWRITE_FONT_WEIGHT GetWeight();
        
        [PreserveSig]
        new DWRITE_FONT_STRETCH GetStretch();
        
        [PreserveSig]
        new DWRITE_FONT_STYLE GetStyle();
        
        [PreserveSig]
        new HRESULT GetFamilyNames(/* _COM_Outptr_ */ out IDWriteLocalizedStrings names);
        
        [PreserveSig]
        new HRESULT GetFaceNames(/* _COM_Outptr_ */ out IDWriteLocalizedStrings names);
        
        [PreserveSig]
        new HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, /* _COM_Outptr_result_maybenull_ */ out IDWriteLocalizedStrings informationalStrings, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        new bool HasCharacter(uint unicodeValue);
        
        [PreserveSig]
        new HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, /* optional(DWRITE_MATRIX) */ IntPtr transform, bool isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, /* optional(IDWriteRenderingParams) */ IntPtr renderingParams, /* _Out_ */ out DWRITE_RENDERING_MODE1 renderingMode, /* _Out_ */ out DWRITE_GRID_FIT_MODE gridFitMode);
        
        [PreserveSig]
        new bool IsCharacterLocal(uint unicodeValue);
        
        [PreserveSig]
        new bool IsGlyphLocal(ushort glyphId);
        
        [PreserveSig]
        new HRESULT AreCharactersLocal(/* _In_reads_(characterCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] char[] characters, uint characterCount, bool enqueueIfNotLocal, /* _Out_ */ out bool isLocal);
        
        [PreserveSig]
        new HRESULT AreGlyphsLocal(/* _In_reads_(glyphCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] glyphIndices, uint glyphCount, bool enqueueIfNotLocal, /* _Out_ */ out bool isLocal);
        
        // IDWriteFontFace4
        [PreserveSig]
        DWRITE_GLYPH_IMAGE_FORMATS GetGlyphImageFormats();
        
        [PreserveSig]
        HRESULT GetGlyphImageFormats(ushort glyphId, uint pixelsPerEmFirst, uint pixelsPerEmLast, /* _Out_ */ out DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormats);
        
        [PreserveSig]
        HRESULT GetGlyphImageData(/* _In_ */ ushort glyphId, uint pixelsPerEm, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, /* _Out_ */ out DWRITE_GLYPH_IMAGE_DATA glyphData, /* _Outptr_result_maybenull_ */ [MarshalAs(UnmanagedType.IUnknown)] out object glyphDataContext);
        
        [PreserveSig]
        void ReleaseGlyphImageData([MarshalAs(UnmanagedType.IUnknown)] object glyphDataContext);
    }
}
