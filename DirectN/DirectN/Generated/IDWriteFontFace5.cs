// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(2691,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("98eff3a5-b667-479a-b145-e2fa5b9fdc29"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFace5 : IDWriteFontFace4
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
        new HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, /* _In_opt_ */ ref DWRITE_MATRIX transform, bool isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, /* _In_opt_ */ ref IDWriteRenderingParams renderingParams, /* _Out_ */ out DWRITE_RENDERING_MODE1 renderingMode, /* _Out_ */ out DWRITE_GRID_FIT_MODE gridFitMode);
        
        [PreserveSig]
        new bool IsCharacterLocal(uint unicodeValue);
        
        [PreserveSig]
        new bool IsGlyphLocal(ushort glyphId);
        
        [PreserveSig]
        new HRESULT AreCharactersLocal(/* _In_reads_(characterCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] char[] characters, uint characterCount, bool enqueueIfNotLocal, /* _Out_ */ out bool isLocal);
        
        [PreserveSig]
        new HRESULT AreGlyphsLocal(/* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] glyphIndices, uint glyphCount, bool enqueueIfNotLocal, /* _Out_ */ out bool isLocal);
        
        // IDWriteFontFace4
        [PreserveSig]
        new DWRITE_GLYPH_IMAGE_FORMATS GetGlyphImageFormats();
        
        [PreserveSig]
        new HRESULT GetGlyphImageFormats(ushort glyphId, uint pixelsPerEmFirst, uint pixelsPerEmLast, /* _Out_ */ out DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormats);
        
        [PreserveSig]
        new HRESULT GetGlyphImageData(/* _In_ */ ushort glyphId, uint pixelsPerEm, DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, /* _Out_ */ out DWRITE_GLYPH_IMAGE_DATA glyphData, /* _Outptr_result_maybenull_ */ [MarshalAs(UnmanagedType.IUnknown)] out object glyphDataContext);
        
        [PreserveSig]
        new void ReleaseGlyphImageData(ref IntPtr glyphDataContext);
        
        // IDWriteFontFace5
        [PreserveSig]
        uint GetFontAxisValueCount();
        
        [PreserveSig]
        HRESULT GetFontAxisValues(/* _Out_writes_(fontAxisValueCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] DWRITE_FONT_AXIS_VALUE[] fontAxisValues, uint fontAxisValueCount);
        
        [PreserveSig]
        bool HasVariations();
        
        [PreserveSig]
        HRESULT GetFontResource(/* _COM_Outptr_ */ out IDWriteFontResource fontResource);
        
        [PreserveSig]
        bool Equals(ref IDWriteFontFace fontFace);
    }
}
