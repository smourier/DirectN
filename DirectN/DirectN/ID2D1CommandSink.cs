using System;
using System.Runtime.InteropServices;
using D2D1_RECT_F = DirectN.D2D_RECT_F;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_COLOR_F = DirectN.D3DCOLORVALUE;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;
using D2D1_TAG = System.UInt64;
using D2D1_MATRIX_4X4_F = DirectN.D2D_MATRIX_4X4_F;

namespace DirectN
{
    [Guid("54d7898a-a061-40a7-bec7-e465bcba2c4f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1CommandSink
    {
        [PreserveSig]
        HRESULT BeginDraw();

        [PreserveSig]
        HRESULT EndDraw();

        [PreserveSig]
        HRESULT SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode);

        [PreserveSig]
        HRESULT SetTags(D2D1_TAG tag1, D2D1_TAG tag2);

        [PreserveSig]
        HRESULT SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);

        [PreserveSig]
        HRESULT SetTextRenderingParams(IDWriteRenderingParams textRenderingParams);

        [PreserveSig]
        HRESULT SetTransform(ref D2D1_MATRIX_3X2_F transform);

        [PreserveSig]
        HRESULT SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend);

        [PreserveSig]
        HRESULT SetUnitMode(D2D1_UNIT_MODE unitMode);

        [PreserveSig]
        HRESULT Clear(ref D2D1_COLOR_F color);

        [PreserveSig]
        HRESULT DrawGlyphRun(D2D1_POINT_2F baselineOrigin, ref DWRITE_GLYPH_RUN glyphRun, ref DWRITE_GLYPH_RUN_DESCRIPTION glyphRunDescription, ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode);

        [PreserveSig]
        HRESULT DrawLine(D2D1_POINT_2F point0, D2D1_POINT_2F point1, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);

        [PreserveSig]
        HRESULT DrawGeometry(ID2D1Geometry geometry, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);

        [PreserveSig]
        HRESULT DrawRectangle(ref D2D1_RECT_F rect, ID2D1Brush brush, float strokeWidth, ID2D1StrokeStyle strokeStyle);

        [PreserveSig]
        HRESULT DrawBitmap(ID2D1Bitmap bitmap, ref D2D1_RECT_F destinationRectangle, float opacity, D2D1_INTERPOLATION_MODE interpolationMode, ref D2D1_RECT_F sourceRectangle, ref D2D1_MATRIX_4X4_F perspectiveTransform);

        [PreserveSig]
        HRESULT DrawImage(ID2D1Image image, ref D2D1_POINT_2F targetOffset, ref D2D1_RECT_F imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode);

        [PreserveSig]
        HRESULT DrawGdiMetafile(ID2D1GdiMetafile gdiMetafile, ref D2D1_POINT_2F targetOffset);

        [PreserveSig]
        HRESULT FillMesh(ID2D1Mesh mesh, ID2D1Brush brush);

        [PreserveSig]
        HRESULT FillOpacityMask(ID2D1Bitmap opacityMask, ID2D1Brush brush, ref D2D1_RECT_F destinationRectangle, ref D2D1_RECT_F sourceRectangle);

        [PreserveSig]
        HRESULT FillGeometry(ID2D1Geometry geometry, ID2D1Brush brush, ID2D1Brush opacityBrush);

        [PreserveSig]
        HRESULT FillRectangle(ref D2D1_RECT_F rect, ID2D1Brush brush);

        [PreserveSig]
        HRESULT PushAxisAlignedClip(ref D2D1_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode);

        [PreserveSig]
        HRESULT PushLayer(ref D2D1_LAYER_PARAMETERS1 layerParameters1, ID2D1Layer layer);

        [PreserveSig]
        HRESULT PopAxisAlignedClip();

        [PreserveSig]
        HRESULT PopLayer();
    }
}
