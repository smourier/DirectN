// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(1522,1)
using System;
using System.Runtime.InteropServices;
using D2D1_TAG = System.UInt64;

namespace DirectN
{
    /// <summary>
    /// The device context represents a set of state and a command buffer that is used to render to a target bitmap.
    /// </summary>
    [ComImport, Guid("e8f7fe7a-191c-466d-ad95-975678bda998"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1DeviceContext : ID2D1RenderTarget
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1RenderTarget
        [PreserveSig]
        new HRESULT CreateBitmap(D2D_SIZE_U size, /* optional(void) */ IntPtr srcData, uint pitch, /* _In_ */ ref D2D1_BITMAP_PROPERTIES bitmapProperties, /* _COM_Outptr_ */ out ID2D1Bitmap bitmap);
        
        [PreserveSig]
        new HRESULT CreateBitmapFromWicBitmap(/* _In_ */ IWICBitmapSource wicBitmapSource, /* optional(D2D1_BITMAP_PROPERTIES) */ IntPtr bitmapProperties, /* _COM_Outptr_ */ out ID2D1Bitmap bitmap);
        
        [PreserveSig]
        new HRESULT CreateSharedBitmap(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _Inout_ */ [MarshalAs(UnmanagedType.IUnknown)] object data, /* optional(D2D1_BITMAP_PROPERTIES) */ IntPtr bitmapProperties, /* _COM_Outptr_ */ out ID2D1Bitmap bitmap);
        
        [PreserveSig]
        new HRESULT CreateBitmapBrush(/* _In_opt_ */ ID2D1Bitmap bitmap, /* optional(D2D1_BITMAP_BRUSH_PROPERTIES) */ IntPtr bitmapBrushProperties, /* optional(D2D1_BRUSH_PROPERTIES) */ IntPtr brushProperties, /* _COM_Outptr_ */ out ID2D1BitmapBrush bitmapBrush);
        
        [PreserveSig]
        new HRESULT CreateSolidColorBrush(/* _In_ */ ref _D3DCOLORVALUE color, /* optional(D2D1_BRUSH_PROPERTIES) */ IntPtr brushProperties, /* _COM_Outptr_ */ out ID2D1SolidColorBrush solidColorBrush);
        
        [PreserveSig]
        new HRESULT CreateGradientStopCollection(/* _In_reads_(gradientStopsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_GRADIENT_STOP[] gradientStops, /* _In_range_(>=,1) */ int gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, /* _COM_Outptr_ */ out ID2D1GradientStopCollection gradientStopCollection);
        
        [PreserveSig]
        new HRESULT CreateLinearGradientBrush(/* _In_ */ ref D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, /* optional(D2D1_BRUSH_PROPERTIES) */ IntPtr brushProperties, /* _In_ */ ID2D1GradientStopCollection gradientStopCollection, /* _COM_Outptr_ */ out ID2D1LinearGradientBrush linearGradientBrush);
        
        [PreserveSig]
        new HRESULT CreateRadialGradientBrush(/* _In_ */ ref D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, /* optional(D2D1_BRUSH_PROPERTIES) */ IntPtr brushProperties, /* _In_ */ ID2D1GradientStopCollection gradientStopCollection, /* _COM_Outptr_ */ out ID2D1RadialGradientBrush radialGradientBrush);
        
        [PreserveSig]
        new HRESULT CreateCompatibleRenderTarget(/* optional(D2D_SIZE_F) */ IntPtr desiredSize, /* optional(D2D_SIZE_U) */ IntPtr desiredPixelSize, /* optional(D2D1_PIXEL_FORMAT) */ IntPtr desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, /* _COM_Outptr_ */ out ID2D1BitmapRenderTarget bitmapRenderTarget);
        
        [PreserveSig]
        new HRESULT CreateLayer(/* optional(D2D_SIZE_F) */ IntPtr size, /* _COM_Outptr_ */ out ID2D1Layer layer);
        
        [PreserveSig]
        new HRESULT CreateMesh(/* _COM_Outptr_ */ out ID2D1Mesh mesh);
        
        [PreserveSig]
        new void DrawLine(D2D_POINT_2F point0, D2D_POINT_2F point1, /* _In_ */ ID2D1Brush brush, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle);
        
        [PreserveSig]
        new void DrawRectangle(/* _In_ */ ref D2D_RECT_F rect, /* _In_ */ ID2D1Brush brush, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle);
        
        [PreserveSig]
        new void FillRectangle(/* _In_ */ ref D2D_RECT_F rect, /* _In_ */ ID2D1Brush brush);
        
        [PreserveSig]
        new void DrawRoundedRectangle(/* _In_ */ ref D2D1_ROUNDED_RECT roundedRect, /* _In_ */ ID2D1Brush brush, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle);
        
        [PreserveSig]
        new void FillRoundedRectangle(/* _In_ */ ref D2D1_ROUNDED_RECT roundedRect, /* _In_ */ ID2D1Brush brush);
        
        [PreserveSig]
        new void DrawEllipse(/* _In_ */ ref D2D1_ELLIPSE ellipse, /* _In_ */ ID2D1Brush brush, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle);
        
        [PreserveSig]
        new void FillEllipse(/* _In_ */ ref D2D1_ELLIPSE ellipse, /* _In_ */ ID2D1Brush brush);
        
        [PreserveSig]
        new void DrawGeometry(/* _In_ */ ID2D1Geometry geometry, /* _In_ */ ID2D1Brush brush, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle);
        
        [PreserveSig]
        new void FillGeometry(/* _In_ */ ID2D1Geometry geometry, /* _In_ */ ID2D1Brush brush, /* _In_opt_ */ ID2D1Brush opacityBrush);
        
        [PreserveSig]
        new void FillMesh(/* _In_ */ ID2D1Mesh mesh, /* _In_ */ ID2D1Brush brush);
        
        [PreserveSig]
        new void FillOpacityMask(/* _In_ */ ID2D1Bitmap opacityMask, /* _In_ */ ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, /* optional(D2D_RECT_F) */ IntPtr destinationRectangle, /* optional(D2D_RECT_F) */ IntPtr sourceRectangle);
        
        [PreserveSig]
        new void DrawBitmap(/* _In_ */ ID2D1Bitmap bitmap, /* optional(D2D_RECT_F) */ IntPtr destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, /* optional(D2D_RECT_F) */ IntPtr sourceRectangle);
        
        [PreserveSig]
        new void DrawTextW(/* _In_reads_(stringLength) */ [MarshalAs(UnmanagedType.LPWStr)] string @string, uint stringLength, /* _In_ */ IDWriteTextFormat textFormat, /* _In_ */ ref D2D_RECT_F layoutRect, /* _In_ */ ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode);
        
        [PreserveSig]
        new void DrawTextLayout(D2D_POINT_2F origin, /* _In_ */ IDWriteTextLayout textLayout, /* _In_ */ ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options);
        
        [PreserveSig]
        new void DrawGlyphRun(D2D_POINT_2F baselineOrigin, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* _In_ */ ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
        
        [PreserveSig]
        new void SetTransform(/* _In_ */ ref D2D_MATRIX_3X2_F transform);
        
        [PreserveSig]
        new void GetTransform(/* _Out_ */ out D2D_MATRIX_3X2_F transform);
        
        [PreserveSig]
        new void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode);
        
        [PreserveSig]
        new D2D1_ANTIALIAS_MODE GetAntialiasMode();
        
        [PreserveSig]
        new void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);
        
        [PreserveSig]
        new D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode();
        
        [PreserveSig]
        new void SetTextRenderingParams(/* _In_opt_ */ IDWriteRenderingParams textRenderingParams);
        
        [PreserveSig]
        new void GetTextRenderingParams(/* _Outptr_result_maybenull_ */ out IDWriteRenderingParams textRenderingParams);
        
        [PreserveSig]
        new void SetTags(ulong tag1, ulong tag2);
        
        [PreserveSig]
        new void GetTags(/* optional(D2D1_TAG) */ IntPtr tag1, /* optional(D2D1_TAG) */ IntPtr tag2);
        
        [PreserveSig]
        new void PushLayer(/* _In_ */ ref D2D1_LAYER_PARAMETERS layerParameters, /* _In_opt_ */ ID2D1Layer layer);
        
        [PreserveSig]
        new void PopLayer();
        
        [PreserveSig]
        new HRESULT Flush(/* optional(D2D1_TAG) */ IntPtr tag1, /* optional(D2D1_TAG) */ IntPtr tag2);
        
        [PreserveSig]
        new void SaveDrawingState(/* _Inout_ */ ID2D1DrawingStateBlock drawingStateBlock);
        
        [PreserveSig]
        new void RestoreDrawingState(/* _In_ */ ID2D1DrawingStateBlock drawingStateBlock);
        
        [PreserveSig]
        new void PushAxisAlignedClip(/* _In_ */ ref D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode);
        
        [PreserveSig]
        new void PopAxisAlignedClip();
        
        [PreserveSig]
        new void Clear(/* optional(_D3DCOLORVALUE) */ IntPtr clearColor);
        
        [PreserveSig]
        new void BeginDraw();
        
        [PreserveSig]
        new HRESULT EndDraw(/* optional(D2D1_TAG) */ IntPtr tag1, /* optional(D2D1_TAG) */ IntPtr tag2);
        
        [PreserveSig]
        new void GetPixelFormat(out D2D1_PIXEL_FORMAT size);
        
        [PreserveSig]
        new void SetDpi(float dpiX, float dpiY);
        
        [PreserveSig]
        new void GetDpi(/* _Out_ */ out float dpiX, /* _Out_ */ out float dpiY);
        
        [PreserveSig]
        new void GetSize(out D2D_SIZE_F size);
        
        [PreserveSig]
        new void GetPixelSize(out D2D_SIZE_U size);
        
        [PreserveSig]
        new uint GetMaximumBitmapSize();
        
        [PreserveSig]
        new bool IsSupported(/* _In_ */ ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties);
        
        // ID2D1DeviceContext
        [PreserveSig]
        HRESULT CreateBitmap(D2D_SIZE_U size, /* optional(void) */ IntPtr sourceData, uint pitch, /* _In_ */ ref D2D1_BITMAP_PROPERTIES1 bitmapProperties, /* _COM_Outptr_ */ out ID2D1Bitmap1 bitmap);
        
        [PreserveSig]
        HRESULT CreateBitmapFromWicBitmap(/* _In_ */ IWICBitmapSource wicBitmapSource, /* optional(D2D1_BITMAP_PROPERTIES1) */ IntPtr bitmapProperties, /* _COM_Outptr_ */ out ID2D1Bitmap1 bitmap);
        
        [PreserveSig]
        HRESULT CreateColorContext(D2D1_COLOR_SPACE space, /* _In_reads_opt_(profileSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] profile, int profileSize, /* _COM_Outptr_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        HRESULT CreateColorContextFromFilename(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string filename, /* _COM_Outptr_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        HRESULT CreateColorContextFromWicColorContext(/* _In_ */ IWICColorContext wicColorContext, /* _COM_Outptr_ */ out ID2D1ColorContext colorContext);
        
        [PreserveSig]
        HRESULT CreateBitmapFromDxgiSurface(/* _In_ */ IDXGISurface surface, /* optional(D2D1_BITMAP_PROPERTIES1) */ IntPtr bitmapProperties, /* _COM_Outptr_ */ out ID2D1Bitmap1 bitmap);
        
        [PreserveSig]
        HRESULT CreateEffect(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid effectId, /* _COM_Outptr_ */ out ID2D1Effect effect);
        
        [PreserveSig]
        HRESULT CreateGradientStopCollection(/* _In_reads_(straightAlphaGradientStopsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_GRADIENT_STOP[] straightAlphaGradientStops, /* _In_range_(>=,1) */ int straightAlphaGradientStopsCount, D2D1_COLOR_SPACE preInterpolationSpace, D2D1_COLOR_SPACE postInterpolationSpace, D2D1_BUFFER_PRECISION bufferPrecision, D2D1_EXTEND_MODE extendMode, D2D1_COLOR_INTERPOLATION_MODE colorInterpolationMode, /* _COM_Outptr_ */ out ID2D1GradientStopCollection1 gradientStopCollection1);
        
        [PreserveSig]
        HRESULT CreateImageBrush(/* _In_opt_ */ ID2D1Image image, /* _In_ */ ref D2D1_IMAGE_BRUSH_PROPERTIES imageBrushProperties, /* optional(D2D1_BRUSH_PROPERTIES) */ IntPtr brushProperties, /* _COM_Outptr_ */ out ID2D1ImageBrush imageBrush);
        
        [PreserveSig]
        HRESULT CreateBitmapBrush(/* _In_opt_ */ ID2D1Bitmap bitmap, /* optional(D2D1_BITMAP_BRUSH_PROPERTIES1) */ IntPtr bitmapBrushProperties, /* optional(D2D1_BRUSH_PROPERTIES) */ IntPtr brushProperties, /* _COM_Outptr_ */ out ID2D1BitmapBrush1 bitmapBrush);
        
        [PreserveSig]
        HRESULT CreateCommandList(/* _COM_Outptr_ */ out ID2D1CommandList commandList);
        
        [PreserveSig]
        bool IsDxgiFormatSupported(DXGI_FORMAT format);
        
        [PreserveSig]
        bool IsBufferPrecisionSupported(D2D1_BUFFER_PRECISION bufferPrecision);
        
        [PreserveSig]
        HRESULT GetImageLocalBounds(/* _In_ */ ID2D1Image image, /* _Out_ */ out D2D_RECT_F localBounds);
        
        [PreserveSig]
        HRESULT GetImageWorldBounds(/* _In_ */ ID2D1Image image, /* _Out_ */ out D2D_RECT_F worldBounds);
        
        [PreserveSig]
        HRESULT GetGlyphRunWorldBounds(D2D_POINT_2F baselineOrigin, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, DWRITE_MEASURING_MODE measuringMode, /* _Out_ */ out D2D_RECT_F bounds);
        
        [PreserveSig]
        void GetDevice(/* _Outptr_ */ out ID2D1Device device);
        
        [PreserveSig]
        void SetTarget(/* _In_opt_ */ ID2D1Image image);
        
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
        void DrawGlyphRun(D2D_POINT_2F baselineOrigin, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* optional(DWRITE_GLYPH_RUN_DESCRIPTION) */ IntPtr glyphRunDescription, /* _In_ */ ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
        
        [PreserveSig]
        void DrawImage(/* _In_ */ ID2D1Image image, /* optional(D2D_POINT_2F) */ IntPtr targetOffset, /* optional(D2D_RECT_F) */ IntPtr imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode);
        
        [PreserveSig]
        void DrawGdiMetafile(/* _In_ */ ID2D1GdiMetafile gdiMetafile, /* optional(D2D_POINT_2F) */ IntPtr targetOffset);
        
        [PreserveSig]
        void DrawBitmap(/* _In_ */ ID2D1Bitmap bitmap, /* optional(D2D_RECT_F) */ IntPtr destinationRectangle, float opacity, D2D1_INTERPOLATION_MODE interpolationMode, /* optional(D2D_RECT_F) */ IntPtr sourceRectangle, /* optional(D2D_MATRIX_4X4_F) */ IntPtr perspectiveTransform);
        
        [PreserveSig]
        void PushLayer(/* _In_ */ ref D2D1_LAYER_PARAMETERS1 layerParameters, /* _In_opt_ */ ID2D1Layer layer);
        
        [PreserveSig]
        HRESULT InvalidateEffectInputRectangle(/* _In_ */ ID2D1Effect effect, uint input, /* _In_ */ ref D2D_RECT_F inputRectangle);
        
        [PreserveSig]
        HRESULT GetEffectInvalidRectangleCount(/* _In_ */ ID2D1Effect effect, /* _Out_ */ out uint rectangleCount);
        
        [PreserveSig]
        HRESULT GetEffectInvalidRectangles(/* _In_ */ ID2D1Effect effect, /* _Out_writes_(rectanglesCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D2D_RECT_F[] rectangles, int rectanglesCount);
        
        [PreserveSig]
        HRESULT GetEffectRequiredInputRectangles(/* _In_ */ ID2D1Effect renderEffect, /* optional(D2D_RECT_F) */ IntPtr renderImageRectangle, /* _In_reads_(inputCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D2D1_EFFECT_INPUT_DESCRIPTION[] inputDescriptions, /* _Out_writes_(inputCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D2D_RECT_F[] requiredInputRects, int inputCount);
        
        [PreserveSig]
        void FillOpacityMask(/* _In_ */ ID2D1Bitmap opacityMask, /* _In_ */ ID2D1Brush brush, /* optional(D2D_RECT_F) */ IntPtr destinationRectangle, /* optional(D2D_RECT_F) */ IntPtr sourceRectangle);
    }
}
