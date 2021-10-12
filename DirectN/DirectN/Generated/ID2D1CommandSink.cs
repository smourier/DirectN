// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_1.h(713,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Caller-supplied implementation of an interface to receive the recorded command list.
    /// </summary>
    [ComImport, Guid("54d7898a-a061-40a7-bec7-e465bcba2c4f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1CommandSink
    {
        [PreserveSig]
        HRESULT BeginDraw();
        
        [PreserveSig]
        HRESULT EndDraw();
        
        [PreserveSig]
        HRESULT SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode);
        
        [PreserveSig]
        HRESULT SetTags(ulong tag1, ulong tag2);
        
        [PreserveSig]
        HRESULT SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);
        
        [PreserveSig]
        HRESULT SetTextRenderingParams(/* _In_opt_ */ IDWriteRenderingParams textRenderingParams);
        
        [PreserveSig]
        HRESULT SetTransform(/* _In_ */ ref D2D_MATRIX_3X2_F transform);
        
        [PreserveSig]
        HRESULT SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend);
        
        [PreserveSig]
        HRESULT SetUnitMode(D2D1_UNIT_MODE unitMode);
        
        [PreserveSig]
        HRESULT Clear(/* optional(_D3DCOLORVALUE) */ IntPtr color);
        
        [PreserveSig]
        HRESULT DrawGlyphRun(D2D_POINT_2F baselineOrigin, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* optional(DWRITE_GLYPH_RUN_DESCRIPTION) */ IntPtr glyphRunDescription, /* _In_ */ ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
        
        [PreserveSig]
        HRESULT DrawLine(D2D_POINT_2F point0, D2D_POINT_2F point1, /* _In_ */ ID2D1Brush brush, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle);
        
        [PreserveSig]
        HRESULT DrawGeometry(/* _In_ */ ID2D1Geometry geometry, /* _In_ */ ID2D1Brush brush, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle);
        
        [PreserveSig]
        HRESULT DrawRectangle(/* _In_ */ ref D2D_RECT_F rect, /* _In_ */ ID2D1Brush brush, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle);
        
        [PreserveSig]
        HRESULT DrawBitmap(/* _In_ */ ID2D1Bitmap bitmap, /* optional(D2D_RECT_F) */ IntPtr destinationRectangle, float opacity, D2D1_INTERPOLATION_MODE interpolationMode, /* optional(D2D_RECT_F) */ IntPtr sourceRectangle, /* optional(D2D_MATRIX_4X4_F) */ IntPtr perspectiveTransform);
        
        [PreserveSig]
        HRESULT DrawImage(/* _In_ */ ID2D1Image image, /* optional(D2D_POINT_2F) */ IntPtr targetOffset, /* optional(D2D_RECT_F) */ IntPtr imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode);
        
        [PreserveSig]
        HRESULT DrawGdiMetafile(/* _In_ */ ID2D1GdiMetafile gdiMetafile, /* optional(D2D_POINT_2F) */ IntPtr targetOffset);
        
        [PreserveSig]
        HRESULT FillMesh(/* _In_ */ ID2D1Mesh mesh, /* _In_ */ ID2D1Brush brush);
        
        [PreserveSig]
        HRESULT FillOpacityMask(/* _In_ */ ID2D1Bitmap opacityMask, /* _In_ */ ID2D1Brush brush, /* optional(D2D_RECT_F) */ IntPtr destinationRectangle, /* optional(D2D_RECT_F) */ IntPtr sourceRectangle);
        
        [PreserveSig]
        HRESULT FillGeometry(/* _In_ */ ID2D1Geometry geometry, /* _In_ */ ID2D1Brush brush, /* _In_opt_ */ ID2D1Brush opacityBrush);
        
        [PreserveSig]
        HRESULT FillRectangle(/* _In_ */ ref D2D_RECT_F rect, /* _In_ */ ID2D1Brush brush);
        
        [PreserveSig]
        HRESULT PushAxisAlignedClip(/* _In_ */ ref D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode);
        
        [PreserveSig]
        HRESULT PushLayer(/* _In_ */ ref D2D1_LAYER_PARAMETERS1 layerParameters1, /* _In_opt_ */ ID2D1Layer layer);
        
        [PreserveSig]
        HRESULT PopAxisAlignedClip();
        
        [PreserveSig]
        HRESULT PopLayer();
    }
}
