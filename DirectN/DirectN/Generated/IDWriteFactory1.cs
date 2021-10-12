// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dwrite_1.h(1018,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The root factory interface for all DWrite objects.
    /// </summary>
    [ComImport, Guid("30572f99-dac6-41db-a16e-0486307e606a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDWriteFactory1 : IDWriteFactory
    {
        // IDWriteFactory
        [PreserveSig]
        new HRESULT GetSystemFontCollection(/* _COM_Outptr_ */ out IDWriteFontCollection fontCollection, bool checkForUpdates);
        
        [PreserveSig]
        new HRESULT CreateCustomFontCollection(/* _In_ */ IDWriteFontCollectionLoader collectionLoader, /* _In_reads_bytes_(collectionKeySize) */ IntPtr collectionKey, uint collectionKeySize, /* _COM_Outptr_ */ out IDWriteFontCollection fontCollection);
        
        [PreserveSig]
        new HRESULT RegisterFontCollectionLoader(/* _In_ */ IDWriteFontCollectionLoader fontCollectionLoader);
        
        [PreserveSig]
        new HRESULT UnregisterFontCollectionLoader(/* _In_ */ IDWriteFontCollectionLoader fontCollectionLoader);
        
        [PreserveSig]
        new HRESULT CreateFontFileReference(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string filePath, /* optional(FILETIME) */ IntPtr lastWriteTime, /* _COM_Outptr_ */ out IDWriteFontFile fontFile);
        
        [PreserveSig]
        new HRESULT CreateCustomFontFileReference(/* _In_reads_bytes_(fontFileReferenceKeySize) */ IntPtr fontFileReferenceKey, uint fontFileReferenceKeySize, /* _In_ */ IDWriteFontFileLoader fontFileLoader, /* _COM_Outptr_ */ out IDWriteFontFile fontFile);
        
        [PreserveSig]
        new HRESULT CreateFontFace(DWRITE_FONT_FACE_TYPE fontFaceType, int numberOfFiles, /* _In_reads_(numberOfFiles) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IDWriteFontFile[] fontFiles, uint faceIndex, DWRITE_FONT_SIMULATIONS fontFaceSimulationFlags, /* _COM_Outptr_ */ out IDWriteFontFace fontFace);
        
        [PreserveSig]
        new HRESULT CreateRenderingParams(/* _COM_Outptr_ */ out IDWriteRenderingParams renderingParams);
        
        [PreserveSig]
        new HRESULT CreateMonitorRenderingParams(IntPtr monitor, /* _COM_Outptr_ */ out IDWriteRenderingParams renderingParams);
        
        [PreserveSig]
        new HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, /* _COM_Outptr_ */ out IDWriteRenderingParams renderingParams);
        
        [PreserveSig]
        new HRESULT RegisterFontFileLoader(/* _In_ */ IDWriteFontFileLoader fontFileLoader);
        
        [PreserveSig]
        new HRESULT UnregisterFontFileLoader(/* _In_ */ IDWriteFontFileLoader fontFileLoader);
        
        [PreserveSig]
        new HRESULT CreateTextFormat(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string fontFamilyName, /* _In_opt_ */ IDWriteFontCollection fontCollection, DWRITE_FONT_WEIGHT fontWeight, DWRITE_FONT_STYLE fontStyle, DWRITE_FONT_STRETCH fontStretch, float fontSize, /* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, /* _COM_Outptr_ */ out IDWriteTextFormat textFormat);
        
        [PreserveSig]
        new HRESULT CreateTypography(/* _COM_Outptr_ */ out IDWriteTypography typography);
        
        [PreserveSig]
        new HRESULT GetGdiInterop(/* _COM_Outptr_ */ out IDWriteGdiInterop gdiInterop);
        
        [PreserveSig]
        new HRESULT CreateTextLayout(/* _In_reads_(stringLength) */ [MarshalAs(UnmanagedType.LPWStr)] string @string, uint stringLength, /* _In_ */ IDWriteTextFormat textFormat, float maxWidth, float maxHeight, /* _COM_Outptr_ */ out IDWriteTextLayout textLayout);
        
        [PreserveSig]
        new HRESULT CreateGdiCompatibleTextLayout(/* _In_reads_(stringLength) */ [MarshalAs(UnmanagedType.LPWStr)] string @string, uint stringLength, /* _In_ */ IDWriteTextFormat textFormat, float layoutWidth, float layoutHeight, float pixelsPerDip, /* optional(DWRITE_MATRIX) */ IntPtr transform, bool useGdiNatural, /* _COM_Outptr_ */ out IDWriteTextLayout textLayout);
        
        [PreserveSig]
        new HRESULT CreateEllipsisTrimmingSign(/* _In_ */ IDWriteTextFormat textFormat, /* _COM_Outptr_ */ out IDWriteInlineObject trimmingSign);
        
        [PreserveSig]
        new HRESULT CreateTextAnalyzer(/* _COM_Outptr_ */ out IDWriteTextAnalyzer textAnalyzer);
        
        [PreserveSig]
        new HRESULT CreateNumberSubstitution(/* _In_ */ DWRITE_NUMBER_SUBSTITUTION_METHOD substitutionMethod, /* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string localeName, /* _In_ */ bool ignoreUserOverride, /* _COM_Outptr_ */ out IDWriteNumberSubstitution numberSubstitution);
        
        [PreserveSig]
        new HRESULT CreateGlyphRunAnalysis(/* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, float pixelsPerDip, /* optional(DWRITE_MATRIX) */ IntPtr transform, DWRITE_RENDERING_MODE renderingMode, DWRITE_MEASURING_MODE measuringMode, float baselineOriginX, float baselineOriginY, /* _COM_Outptr_ */ out IDWriteGlyphRunAnalysis glyphRunAnalysis);
        
        // IDWriteFactory1
        [PreserveSig]
        HRESULT GetEudcFontCollection(/* _COM_Outptr_ */ out IDWriteFontCollection fontCollection, bool checkForUpdates);
        
        [PreserveSig]
        HRESULT CreateCustomRenderingParams(float gamma, float enhancedContrast, float enhancedContrastGrayscale, float clearTypeLevel, DWRITE_PIXEL_GEOMETRY pixelGeometry, DWRITE_RENDERING_MODE renderingMode, /* _COM_Outptr_ */ out IDWriteRenderingParams1 renderingParams);
    }
}
