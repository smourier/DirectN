// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1594,1)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("7836d248-68cc-4df6-b9e8-de991bf62eb7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1DeviceContext5 : ID2D1DeviceContext4
    {
        // ID2D1DeviceContext2
        [PreserveSig]
        new HRESULT CreateInk(/* _In_ */ ref D2D1_INK_POINT startPoint, /* _COM_Outptr_ */ out ID2D1Ink ink);
        
        [PreserveSig]
        new HRESULT CreateInkStyle(/* _In_opt_ */ ref D2D1_INK_STYLE_PROPERTIES inkStyleProperties, /* _COM_Outptr_ */ out ID2D1InkStyle inkStyle);
        
        [PreserveSig]
        new HRESULT CreateGradientMesh(/* _In_reads_(patchesCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_GRADIENT_MESH_PATCH[] patches, uint patchesCount, /* _COM_Outptr_ */ out ID2D1GradientMesh gradientMesh);
        
        [PreserveSig]
        new HRESULT CreateImageSourceFromWic(/* _In_ */ ref IWICBitmapSource wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions, D2D1_ALPHA_MODE alphaMode, /* _COM_Outptr_ */ out ID2D1ImageSourceFromWic imageSource);
        
        [PreserveSig]
        new HRESULT CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, /* _In_reads_(3) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] uint[] extents, /* _In_reads_(dataCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, uint dataCount, /* _In_reads_(2) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] uint[] strides, /* _COM_Outptr_ */ out ID2D1LookupTable3D lookupTable);
        
        [PreserveSig]
        new HRESULT CreateImageSourceFromDxgi(/* _In_reads_(surfaceCount) */ out IDXGISurface[] surfaces, uint surfaceCount, DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, /* _COM_Outptr_ */ out ID2D1ImageSource imageSource);
        
        [PreserveSig]
        new HRESULT GetGradientMeshWorldBounds(/* _In_ */ ID2D1GradientMesh gradientMesh, /* _Out_ */ out D2D_RECT_F pBounds);
        
        [PreserveSig]
        new void DrawInk(/* _In_ */ ID2D1Ink ink, /* _In_ */ ref ID2D1Brush brush, /* _In_opt_ */ ID2D1InkStyle inkStyle);
        
        [PreserveSig]
        new void DrawGradientMesh(/* _In_ */ ID2D1GradientMesh gradientMesh);
        
        [PreserveSig]
        new void DrawGdiMetafile(/* _In_ */ ref ID2D1GdiMetafile gdiMetafile, /* _In_opt_ */ ref D2D_RECT_F destinationRectangle, /* _In_opt_ */ ref D2D_RECT_F sourceRectangle);
        
        [PreserveSig]
        new HRESULT CreateTransformedImageSource(/* _In_ */ ID2D1ImageSource imageSource, /* _In_ */ ref D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES properties, /* _COM_Outptr_ */ out ID2D1TransformedImageSource transformedImageSource);
        
        // ID2D1DeviceContext3
        [PreserveSig]
        new HRESULT CreateSpriteBatch(/* _COM_Outptr_ */ out ID2D1SpriteBatch spriteBatch);
        
        [PreserveSig]
        new void DrawSpriteBatch(/* _In_ */ ID2D1SpriteBatch spriteBatch, uint startIndex, uint spriteCount, /* _In_ */ ref ID2D1Bitmap bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D1_SPRITE_OPTIONS spriteOptions);
        
        // ID2D1DeviceContext4
        [PreserveSig]
        new HRESULT CreateSvgGlyphStyle(/* _COM_Outptr_ */ out ID2D1SvgGlyphStyle svgGlyphStyle);
        
        [PreserveSig]
        new void DrawTextA(/* _In_reads_(stringLength) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] char[] @string, uint stringLength, /* _In_ */ ref IDWriteTextFormat textFormat, /* _In_ */ ref D2D_RECT_F layoutRect, /* _In_opt_ */ ref ID2D1Brush defaultFillBrush, /* _In_opt_ */ ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode);
        
        [PreserveSig]
        new void DrawTextLayout(D2D_POINT_2F origin, /* _In_ */ ref IDWriteTextLayout textLayout, /* _In_opt_ */ ref ID2D1Brush defaultFillBrush, /* _In_opt_ */ ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, D2D1_DRAW_TEXT_OPTIONS options);
        
        [PreserveSig]
        new void DrawColorBitmapGlyphRun(DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, D2D_POINT_2F baselineOrigin, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, D2D1_COLOR_BITMAP_GLYPH_SNAP_OPTION bitmapSnapOption);
        
        [PreserveSig]
        new void DrawSvgGlyphRun(D2D_POINT_2F baselineOrigin, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_opt_ */ ref ID2D1Brush defaultFillBrush, /* _In_opt_ */ ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, DWRITE_MEASURING_MODE measuringMode);
        
        [PreserveSig]
        new HRESULT GetColorBitmapGlyphImage(DWRITE_GLYPH_IMAGE_FORMATS glyphImageFormat, D2D_POINT_2F glyphOrigin, /* _In_ */ ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, bool isSideways, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float dpiX, float dpiY, /* _Out_ */ out D2D_MATRIX_3X2_F glyphTransform, /* _COM_Outptr_ */ out ID2D1Image glyphImage);
        
        [PreserveSig]
        new HRESULT GetSvgGlyphImage(D2D_POINT_2F glyphOrigin, /* _In_ */ ref IDWriteFontFace fontFace, float fontEmSize, ushort glyphIndex, bool isSideways, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, /* _In_opt_ */ ref ID2D1Brush defaultFillBrush, /* _In_opt_ */ ID2D1SvgGlyphStyle svgGlyphStyle, uint colorPaletteIndex, /* _Out_ */ out D2D_MATRIX_3X2_F glyphTransform, /* _COM_Outptr_ */ out ID2D1CommandList glyphImage);
        
        // ID2D1DeviceContext5
        [PreserveSig]
        HRESULT CreateSvgDocument(/* _In_opt_ */ ref IStream inputXmlStream, D2D_SIZE_F viewportSize, /* _COM_Outptr_ */ out ID2D1SvgDocument svgDocument);
        
        [PreserveSig]
        void DrawSvgDocument(/* _In_ */ ref ID2D1SvgDocument svgDocument);
        
        [PreserveSig]
        HRESULT CreateColorContextFromDxgiColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace, /* _COM_Outptr_ */ out ID2D1ColorContext1 colorContext);
        
        [PreserveSig]
        HRESULT CreateColorContextFromSimpleColorProfile(/* _In_ */ ref D2D1_SIMPLE_COLOR_PROFILE simpleProfile, /* _COM_Outptr_ */ out ID2D1ColorContext1 colorContext);
    }
}
