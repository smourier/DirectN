// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dwrite_3.h(1154,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The interface that represents an absolute reference to a font face. It contains font face type, appropriate file references and face identification data. Various font data such as metrics, names and glyph outlines is obtained from IDWriteFontFace.
    /// </summary>
    [Guid("d37d7598-09be-4222-a236-2081341cc1f2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFontFace3
    {
        [PreserveSig]
        HRESULT GetFontFaceReference(/* _COM_Outptr_ */ out IDWriteFontFaceReference fontFaceReference);
        
        [PreserveSig]
        void GetPanose(/* _Out_ */ out DWRITE_PANOSE panose);
        
        [PreserveSig]
        DWRITE_FONT_WEIGHT GetWeight();
        
        [PreserveSig]
        DWRITE_FONT_STRETCH GetStretch();
        
        [PreserveSig]
        DWRITE_FONT_STYLE GetStyle();
        
        [PreserveSig]
        HRESULT GetFamilyNames(/* _COM_Outptr_ */ out IDWriteLocalizedStrings names);
        
        [PreserveSig]
        HRESULT GetFaceNames(/* _COM_Outptr_ */ out IDWriteLocalizedStrings names);
        
        [PreserveSig]
        HRESULT GetInformationalStrings(DWRITE_INFORMATIONAL_STRING_ID informationalStringID, /* _COM_Outptr_result_maybenull_ */ out IDWriteLocalizedStrings informationalStrings, /* _Out_ */ out bool exists);
        
        [PreserveSig]
        bool HasCharacter(uint unicodeValue);
        
        [PreserveSig]
        HRESULT GetRecommendedRenderingMode(float fontEmSize, float dpiX, float dpiY, /* _In_opt_ */ ref DWRITE_MATRIX transform, bool isSideways, DWRITE_OUTLINE_THRESHOLD outlineThreshold, DWRITE_MEASURING_MODE measuringMode, /* _In_opt_ */ ref IDWriteRenderingParams renderingParams, /* _Out_ */ out DWRITE_RENDERING_MODE1 renderingMode, /* _Out_ */ out DWRITE_GRID_FIT_MODE gridFitMode);
        
        [PreserveSig]
        bool IsCharacterLocal(uint unicodeValue);
        
        [PreserveSig]
        bool IsGlyphLocal(ushort glyphId);
        
        [PreserveSig]
        HRESULT AreCharactersLocal(/* _In_reads_(characterCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] char[] characters, uint characterCount, bool enqueueIfNotLocal, /* _Out_ */ out bool isLocal);
        
        [PreserveSig]
        HRESULT AreGlyphsLocal(/* _In_reads_(glyphCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ushort[] glyphIndices, uint glyphCount, bool enqueueIfNotLocal, /* _Out_ */ out bool isLocal);
    }
}
