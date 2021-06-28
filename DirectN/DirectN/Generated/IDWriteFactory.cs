// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dwrite.h(4700,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The root factory interface for all DWrite objects.
    /// </summary>
    [ComImport, Guid("b859ee5a-d838-4b5b-a2e8-1adc7d93db48"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFactory
    {
        [PreserveSig]
        HRESULT GetSystemFontCollection(/* _COM_Outptr_ */ out IDWriteFontCollection fontCollection, bool checkForUpdates);
        
        [PreserveSig]
        HRESULT CreateCustomFontCollection(/* _In_ */ IDWriteFontCollectionLoader collectionLoader, /* _In_reads_bytes_(collectionKeySize) */ IntPtr collectionKey, uint collectionKeySize, /* _COM_Outptr_ */ out IDWriteFontCollection fontCollection);
        
        [PreserveSig]
        HRESULT RegisterFontCollectionLoader(/* _In_ */ IDWriteFontCollectionLoader fontCollectionLoader);
        
        [PreserveSig]
        HRESULT UnregisterFontCollectionLoader(/* _In_ */ IDWriteFontCollectionLoader fontCollectionLoader);
        
        [PreserveSig]
        HRESULT CreateFontFileReference(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string filePath, /* optional(FILETIME) */ IntPtr lastWriteTime, /* _COM_Outptr_ */ out IDWriteFontFile fontFile);
        
        [PreserveSig]
        HRESULT CreateCustomFontFileReference(/* _In_reads_bytes_(fontFileReferenceKeySize) */ IntPtr fontFileReferenceKey, uint fontFileReferenceKeySize, /* _In_ */ IDWriteFontFileLoader fontFileLoader, /* _COM_Outptr_ */ out IDWriteFontFile fontFile);
        
        [PreserveSig]
        HRESULT CreateFontFace(DWRITE_FONT_FACE_TYPE fontFaceType, int numberOfFiles, /* _In_reads_(numberOfFiles) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IDWriteFontFile[] fontFiles, uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, /* _COM_Outptr_ */ out IDWriteFontFace fontFace);
        
        [PreserveSig]
        HRESULT CreateRenderingParams(/* _COM_Outptr_ */ out IDWriteRenderingParams renderingParams);
        
        [PreserveSig]
        HRESULT CreateMonitorRenderingParams(IntPtr monitor, /* _COM_Outptr_ */ out IDWriteRenderingParams renderingParams);
        
        [PreserveSig]
        HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, /* _COM_Outptr_ */ out IDWriteRenderingParams renderingParams);
        
        [PreserveSig]
        HRESULT RegisterFontFileLoader(/* _In_ */ IDWriteFontFileLoader fontFileLoader);
        
        [PreserveSig]
        HRESULT UnregisterFontFileLoader(/* _In_ */ IDWriteFontFileLoader fontFileLoader);
        
        [PreserveSig]
        HRESULT CreateTextFormat(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName, /* _In_opt_ */ IDWriteFontCollection fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, float fontSize, /* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, /* _COM_Outptr_ */ out IDWriteTextFormat textFormat);
        
        [PreserveSig]
        HRESULT CreateTypography(/* _COM_Outptr_ */ out IDWriteTypography typography);
        
        [PreserveSig]
        HRESULT GetGdiInterop(/* _COM_Outptr_ */ out IDWriteGdiInterop gdiInterop);
        
        [PreserveSig]
        HRESULT CreateTextLayout(/* _In_reads_(stringLength) */ [MarshalAs(UnmanagedType.LPWStr)] string @string, uint stringLength, /* _In_ */ IDWriteTextFormat textFormat, float maxWidth, float maxHeight, /* _COM_Outptr_ */ out IDWriteTextLayout textLayout);
        
        [PreserveSig]
        HRESULT CreateGdiCompatibleTextLayout(/* _In_reads_(stringLength) */ [MarshalAs(UnmanagedType.LPWStr)] string @string, uint stringLength, /* _In_ */ IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, /* optional(DWRITE_MATRIX) */ IntPtr transform, bool useGdiNatural, /* _COM_Outptr_ */ out IDWriteTextLayout textLayout);
        
        [PreserveSig]
        HRESULT CreateEllipsisTrimmingSign(/* _In_ */ IDWriteTextFormat textFormat, /* _COM_Outptr_ */ out IDWriteInlineObject trimmingSign);
        
        [PreserveSig]
        HRESULT CreateTextAnalyzer(/* _COM_Outptr_ */ out IDWriteTextAnalyzer textAnalyzer);
        
        [PreserveSig]
        HRESULT CreateNumberSubstitution(/* _In_ */ DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, /* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, /* _In_ */ bool ignoreUserOverride, /* _COM_Outptr_ */ out IDWriteNumberSubstitution numberSubstitution);
        
        [PreserveSig]
        HRESULT CreateGlyphRunAnalysis(/* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, float pixelsPerDip, /* optional(DWRITE_MATRIX) */ IntPtr transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, float baselineOriginX, float baselineOriginY, /* _COM_Outptr_ */ out IDWriteGlyphRunAnalysis glyphRunAnalysis);
    }
}
