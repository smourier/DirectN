using System;
using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;
using D2D1_RECT_F = DirectN.D2D_RECT_F;
using D2D1_SIZE_F = DirectN.D2D_SIZE_F;
using D2D1_SIZE_U = DirectN.D2D_SIZE_U;
using D2D1_TAG = System.UInt64;
using D2D1_COLOR_F = DirectN.D3DCOLORVALUE;

namespace DirectN
{
    [Guid("e0db51c3-6f77-4bae-b3d5-e47509b35838"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1DCRenderTarget : ID2D1RenderTarget
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1RenderTarget
        [PreserveSig]
        new HRESULT CreateBitmap(D2D1_SIZE_U size, IntPtr srcData, int pitch, ref D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap);

        [PreserveSig]
        new HRESULT CreateBitmapFromWicBitmap(IWICBitmapSource wicBitmapSource, ref D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap);

        [PreserveSig]
        new HRESULT CreateSharedBitmap([MarshalAs(UnmanagedType.LPStruct)] Guid riid, IntPtr data, ref D2D1_BITMAP_PROPERTIES bitmapProperties, out ID2D1Bitmap bitmap);

        [PreserveSig]
        new HRESULT CreateBitmapBrush(ID2D1Bitmap bitmap, ref D2D1_BITMAP_BRUSH_PROPERTIES bitmapBrushProperties, ref D2D1_BRUSH_PROPERTIES brushProperties, out ID2D1BitmapBrush bitmapBrush);

        [PreserveSig]
        new HRESULT CreateSolidColorBrush(ref D2D1_COLOR_F color, ref D2D1_BRUSH_PROPERTIES brushProperties, out ID2D1SolidColorBrush solidColorBrush);

        [PreserveSig]
        new HRESULT CreateGradientStopCollection(D2D1_GRADIENT_STOP[] gradientStops, int gradientStopsCount, D2D1_GAMMA colorInterpolationGamma, D2D1_EXTEND_MODE extendMode, out ID2D1GradientStopCollection gradientStopCollection);

        [PreserveSig]
        new HRESULT CreateLinearGradientBrush(ref D2D1_LINEAR_GRADIENT_BRUSH_PROPERTIES linearGradientBrushProperties, ref D2D1_BRUSH_PROPERTIES brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1LinearGradientBrush linearGradientBrush);

        [PreserveSig]
        new HRESULT CreateRadialGradientBrush(ref D2D1_RADIAL_GRADIENT_BRUSH_PROPERTIES radialGradientBrushProperties, ref D2D1_BRUSH_PROPERTIES brushProperties, ID2D1GradientStopCollection gradientStopCollection, out ID2D1RadialGradientBrush radialGradientBrush);

        [PreserveSig]
        new HRESULT CreateCompatibleRenderTarget(ref D2D1_SIZE_F desiredSize, ref D2D1_SIZE_U desiredPixelSize, ref D2D1_PIXEL_FORMAT desiredFormat, D2D1_COMPATIBLE_RENDER_TARGET_OPTIONS options, out ID2D1BitmapRenderTarget bitmapRenderTarget);

        [PreserveSig]
        new HRESULT CreateLayer(ref D2D1_SIZE_F size, out ID2D1Layer layer);

        [PreserveSig]
        new HRESULT CreateMesh(out ID2D1Mesh mesh);

        [PreserveSig]
        new void DrawLine(D2D1_POINT_2F point0, D2D1_POINT_2F point1, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);

        [PreserveSig]
        new void DrawRectangle(ref D2D1_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);

        [PreserveSig]
        new void FillRectangle(ref D2D1_RECT_F rect, ID2D1Brush brush);

        [PreserveSig]
        new void DrawRoundedRectangle(ref D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);

        [PreserveSig]
        new void FillRoundedRectangle(ref D2D1_ROUNDED_RECT roundedRect, ID2D1Brush brush);

        [PreserveSig]
        new void DrawEllipse(ref D2D1_ELLIPSE ellipse, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);

        [PreserveSig]
        new void FillEllipse(ref D2D1_ELLIPSE ellipse, ID2D1Brush brush);

        [PreserveSig]
        new void DrawGeometry(ID2D1Geometry geometry, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);

        [PreserveSig]
        new void FillGeometry(ID2D1Geometry geometry, ID2D1Brush brush, ID2D1Brush opacityBrush);

        [PreserveSig]
        new void FillMesh(ID2D1Mesh mesh, ID2D1Brush brush);

        [PreserveSig]
        new void FillOpacityMask(ID2D1Bitmap opacityMask, ID2D1Brush brush, D2D1_OPACITY_MASK_CONTENT content, ref D2D1_RECT_F destinationRectangle, ref D2D1_RECT_F sourceRectangle);

        [PreserveSig]
        new void DrawBitmap(ID2D1Bitmap bitmap, ref D2D1_RECT_F destinationRectangle, float opacity, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, ref D2D1_RECT_F sourceRectangle);

        [PreserveSig]
        new void DrawText([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] char[] @string, int stringLength, IDWriteTextFormat textFormat, ref D2D1_RECT_F layoutRect, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options, DWRITE_MEASURING_MODE measuringMode);

        [PreserveSig]
        new void DrawTextLayout(D2D1_POINT_2F origin, IDWriteTextLayout textLayout, ID2D1Brush defaultFillBrush, D2D1_DRAW_TEXT_OPTIONS options);

        [PreserveSig]
        new void DrawGlyphRun(D2D1_POINT_2F baselineOrigin, ref DWRITE_GLYPH_RUN glyphRun, ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode);

        [PreserveSig]
        new void SetTransform(ref D2D1_MATRIX_3X2_F transform);

        [PreserveSig]
        new void GetTransform(ref D2D1_MATRIX_3X2_F transform);

        [PreserveSig]
        new void SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode);

        [PreserveSig]
        new D2D1_ANTIALIAS_MODE GetAntialiasMode();

        [PreserveSig]
        new void SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);

        [PreserveSig]
        new D2D1_TEXT_ANTIALIAS_MODE GetTextAntialiasMode();

        [PreserveSig]
        new void SetTextRenderingParams(IDWriteRenderingParams textRenderingParams);

        [PreserveSig]
        new void GetTextRenderingParams(IDWriteRenderingParams textRenderingParams);

        [PreserveSig]
        new void SetTags(D2D1_TAG tag1, D2D1_TAG tag2);

        [PreserveSig]
        new void GetTags(out D2D1_TAG tag1, out D2D1_TAG tag2);

        [PreserveSig]
        new void PushLayer(ref D2D1_LAYER_PARAMETERS layerParameters, ID2D1Layer layer);

        [PreserveSig]
        new void PopLayer();

        [PreserveSig]
        new HRESULT Flush(out D2D1_TAG tag1, out D2D1_TAG tag2);

        [PreserveSig]
        new void SaveDrawingState(ID2D1DrawingStateBlock drawingStateBlock);

        [PreserveSig]
        new void RestoreDrawingState(ID2D1DrawingStateBlock drawingStateBlock);

        [PreserveSig]
        new void PushAxisAlignedClip(ref D2D1_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode);

        [PreserveSig]
        new void PopAxisAlignedClip();

        [PreserveSig]
        new void Clear(ref D2D1_COLOR_F clearColor);

        [PreserveSig]
        new void BeginDraw();

        [PreserveSig]
        new HRESULT EndDraw(out D2D1_TAG tag1, out D2D1_TAG tag2);

        [PreserveSig]
        new D2D1_PIXEL_FORMAT GetPixelFormat();

        [PreserveSig]
        new void SetDpi(float dpiX, float dpiY);

        [PreserveSig]
        new void GetDpi(out float dpiX, out float dpiY);

        [PreserveSig]
        new D2D1_SIZE_F GetSize();

        [PreserveSig]
        new D2D1_SIZE_U GetPixelSize();

        [PreserveSig]
        new int GetMaximumBitmapSize();

        [PreserveSig]
        new bool IsSupported(ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties);

        // ID2D1DCRenderTarget
        [PreserveSig]
        HRESULT BindDC(IntPtr hDC, ref RECT pSubRect);
    }
}
