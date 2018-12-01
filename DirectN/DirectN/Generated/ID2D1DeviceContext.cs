// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_1.h(1522,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The device context represents a set of state and a command buffer that is used to render to a target bitmap.
    /// </summary>
    [Guid("e8f7fe7a-191c-466d-ad95-975678bda998"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1DeviceContext
    {
        [PreserveSig]
        HRESULT CreateBitmap(D2D_SIZE_U size, /* _In_opt_ */ IntPtr sourceData, uint pitch, /* _In_ */ ref D2D1_BITMAP_PROPERTIES1 bitmapProperties, /* _COM_Outptr_ */ out ID2D1Bitmap1 bitmap);
        
        [PreserveSig]
        HRESULT CreateBitmapFromWicBitmap(/* _In_ */ ref IWICBitmapSource wicBitmapSource, /* _In_opt_ */ ref D2D1_BITMAP_PROPERTIES1 bitmapProperties, /* _COM_Outptr_ */ out ID2D1Bitmap1 bitmap);
        
        [PreserveSig]
        HRESULT CreateColorContext(D2D1_COLOR_SPACE space, /* _In_reads_opt_(profileSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] profile, uint profileSize, /* _COM_Outptr_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        HRESULT CreateColorContextFromFilename(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string filename, /* _COM_Outptr_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        HRESULT CreateColorContextFromWicColorContext(/* _In_ */ ref IWICColorContext wicColorContext, /* _COM_Outptr_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        HRESULT CreateBitmapFromDxgiSurface(/* _In_ */ ref IDXGISurface surface, /* _In_opt_ */ ref D2D1_BITMAP_PROPERTIES1 bitmapProperties, /* _COM_Outptr_ */ out ID2D1Bitmap1 bitmap);
        
        [PreserveSig]
        HRESULT CreateEffect(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid effectId, /* _COM_Outptr_ */ out ID2D1Effect effect);
        
        [PreserveSig]
        HRESULT CreateGradientStopCollection(/* _In_reads_(straightAlphaGradientStopsCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_GRADIENT_STOP[] straightAlphaGradientStops, /* _In_range_(>=,1) */ uint straightAlphaGradientStopsCount, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, /* _COM_Outptr_ */ out ID2D1GradientStopCollection1 gradientStopCollection1);
        
        [PreserveSig]
        HRESULT CreateImageBrush(/* _In_opt_ */ ref ID2D1Image image, /* _In_ */ ref D2D1_IMAGE_BRUSH_PROPERTIES imageBrushProperties, /* _In_opt_ */ ref D2D1_BRUSH_PROPERTIES brushProperties, /* _COM_Outptr_ */ out ID2D1ImageBrush imageBrush);
        
        [PreserveSig]
        HRESULT CreateBitmapBrush(/* _In_opt_ */ ref ID2D1Bitmap bitmap, /* _In_opt_ */ ref D2D1_BITMAP_BRUSH_PROPERTIES1 bitmapBrushProperties, /* _In_opt_ */ ref D2D1_BRUSH_PROPERTIES brushProperties, /* _COM_Outptr_ */ out ID2D1BitmapBrush1 bitmapBrush);
        
        [PreserveSig]
        HRESULT CreateCommandList(/* _COM_Outptr_ */ out ID2D1CommandList commandList);
        
        [PreserveSig]
        bool IsDxgiFormatSupported(DXGI_FORMAT format);
        
        [PreserveSig]
        bool IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision);
        
        [PreserveSig]
        HRESULT GetImageLocalBounds(/* _In_ */ ref ID2D1Image image, /* _Out_ */ out D2D_RECT_F localBounds);
        
        [PreserveSig]
        HRESULT GetImageWorldBounds(/* _In_ */ ref ID2D1Image image, /* _Out_ */ out D2D_RECT_F worldBounds);
        
        [PreserveSig]
        HRESULT GetGlyphRunWorldBounds(D2D_POINT_2F baselineOrigin, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, /* _Out_ */ out D2D_RECT_F bounds);
        
        [PreserveSig]
        void GetDevice(/* _Outptr_ */ out ID2D1Device device);
        
        [PreserveSig]
        void SetTarget(/* _In_opt_ */ ref ID2D1Image image);
        
        [PreserveSig]
        void GetTarget(/* _Outptr_result_maybenull_ */ out ID2D1Image image);
        
        [PreserveSig]
        void SetRenderingControls(/* _In_ */ ref D2D1_RENDERING_CONTROLS renderingControls);
        
        [PreserveSig]
        void GetRenderingControls(/* _Out_ */ out D2D1_RENDERING_CONTROLS renderingControls);
        
        [PreserveSig]
        void SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend);
        
        [PreserveSig]
        D2D1_PRIMITIVE_BLEND GetPrimitiveBlend();
        
        [PreserveSig]
        void SetUnitMode(D2D1_UNIT_MODE unitMode);
        
        [PreserveSig]
        D2D1_UNIT_MODE GetUnitMode();
        
        [PreserveSig]
        void DrawGlyphRun(D2D_POINT_2F baselineOrigin, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_opt_ */ ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, /* _In_ */ ref ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
        
        [PreserveSig]
        void DrawImage(/* _In_ */ ref ID2D1Image image, /* _In_opt_ */ ref D2D_POINT_2F targetOffset, /* _In_opt_ */ ref D2D_RECT_F imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode);
        
        [PreserveSig]
        void DrawGdiMetafile(/* _In_ */ ID2D1GdiMetafile gdiMetafile, /* _In_opt_ */ ref D2D_POINT_2F targetOffset);
        
        [PreserveSig]
        void DrawBitmap(/* _In_ */ ref ID2D1Bitmap bitmap, /* _In_opt_ */ ref D2D_RECT_F destinationRectangle, float opacity, D2D1_INTERPOLATION_MODE interpolationMode, /* _In_opt_ */ ref D2D_RECT_F sourceRectangle, /* _In_opt_ */ ref D2D_MATRIX_4X4_F perspectiveTransform);
        
        [PreserveSig]
        void PushLayer(/* _In_ */ ref D2D1_LAYER_PARAMETERS1 layerParameters, /* _In_opt_ */ ref ID2D1Layer layer);
        
        [PreserveSig]
        HRESULT InvalidateEffectInputRectangle(/* _In_ */ ID2D1Effect effect, uint input, /* _In_ */ ref D2D_RECT_F inputRectangle);
        
        [PreserveSig]
        HRESULT GetEffectInvalidRectangleCount(/* _In_ */ ID2D1Effect effect, /* _Out_ */ out uint rectangleCount);
        
        [PreserveSig]
        HRESULT GetEffectInvalidRectangles(/* _In_ */ ID2D1Effect effect, /* _Out_writes_(rectanglesCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D2D_RECT_F[] rectangles, uint rectanglesCount);
        
        [PreserveSig]
        HRESULT GetEffectRequiredInputRectangles(/* _In_ */ ID2D1Effect renderEffect, /* _In_opt_ */ ref D2D_RECT_F renderImageRectangle, /* _In_reads_(inputCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D2D1_EFFECT_INPUT_DESCRIPTION[] inputDescriptions, /* _Out_writes_(inputCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D2D_RECT_F[] requiredInputRects, uint inputCount);
        
        [PreserveSig]
        void FillOpacityMask(/* _In_ */ ref ID2D1Bitmap opacityMask, /* _In_ */ ref ID2D1Brush brush, /* _In_opt_ */ ref D2D_RECT_F destinationRectangle, /* _In_opt_ */ ref D2D_RECT_F sourceRectangle);
    }
}
