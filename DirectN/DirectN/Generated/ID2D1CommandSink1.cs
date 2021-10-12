// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1_2.h(150,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This interface performs all the same functions as the existing ID2D1CommandSink interface. It also enables access to the new primitive blend modes, MIN and ADD, through its SetPrimitiveBlend1 method.
    /// </summary>
    [ComImport, Guid("9eb767fd-4269-4467-b8c2-eb30cb305743"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1CommandSink1 : ID2D1CommandSink
    {
        // ID2D1CommandSink
        [PreserveSig]
        new HRESULT BeginDraw();
        
        [PreserveSig]
        new HRESULT EndDraw();
        
        [PreserveSig]
        new HRESULT SetAntialiasMode(D2D1_ANTIALIAS_MODE antialiasMode);
        
        [PreserveSig]
        new HRESULT SetTags(ulong tag1, ulong tag2);
        
        [PreserveSig]
        new HRESULT SetTextAntialiasMode(D2D1_TEXT_ANTIALIAS_MODE textAntialiasMode);
        
        [PreserveSig]
        new HRESULT SetTextRenderingParams(/* _In_opt_ */ IDWriteRenderingParams textRenderingParams);
        
        [PreserveSig]
        new HRESULT SetTransform(/* _In_ */ ref D2D_MATRIX_3X2_F transform);
        
        [PreserveSig]
        new HRESULT SetPrimitiveBlend(D2D1_PRIMITIVE_BLEND primitiveBlend);
        
        [PreserveSig]
        new HRESULT SetUnitMode(D2D1_UNIT_MODE unitMode);
        
        [PreserveSig]
        new HRESULT Clear(/* optional(_D3DCOLORVALUE) */ IntPtr color);
        
        [PreserveSig]
        new HRESULT DrawGlyphRun(D2D_POINT_2F baselineOrigin, /* _In_ */ ref DWRITE_GLYPH_RUN glyphRun, /* optional(DWRITE_GLYPH_RUN_DESCRIPTION) */ IntPtr glyphRunDescription, /* _In_ */ ID2D1Brush foregroundBrush, DWRITE_MEASURING_MODE measuringMode);
        
        [PreserveSig]
        new HRESULT DrawLine(D2D_POINT_2F point0, D2D_POINT_2F point1, /* _In_ */ ID2D1Brush brush, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle);
        
        [PreserveSig]
        new HRESULT DrawGeometry(/* _In_ */ ID2D1Geometry geometry, /* _In_ */ ID2D1Brush brush, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle);
        
        [PreserveSig]
        new HRESULT DrawRectangle(/* _In_ */ ref D2D_RECT_F rect, /* _In_ */ ID2D1Brush brush, float strokeWidth, /* _In_opt_ */ ID2D1StrokeStyle strokeStyle);
        
        [PreserveSig]
        new HRESULT DrawBitmap(/* _In_ */ ID2D1Bitmap bitmap, /* optional(D2D_RECT_F) */ IntPtr destinationRectangle, float opacity, D2D1_INTERPOLATION_MODE interpolationMode, /* optional(D2D_RECT_F) */ IntPtr sourceRectangle, /* optional(D2D_MATRIX_4X4_F) */ IntPtr perspectiveTransform);
        
        [PreserveSig]
        new HRESULT DrawImage(/* _In_ */ ID2D1Image image, /* optional(D2D_POINT_2F) */ IntPtr targetOffset, /* optional(D2D_RECT_F) */ IntPtr imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode, D2D1_COMPOSITE_MODE compositeMode);
        
        [PreserveSig]
        new HRESULT DrawGdiMetafile(/* _In_ */ ID2D1GdiMetafile gdiMetafile, /* optional(D2D_POINT_2F) */ IntPtr targetOffset);
        
        [PreserveSig]
        new HRESULT FillMesh(/* _In_ */ ID2D1Mesh mesh, /* _In_ */ ID2D1Brush brush);
        
        [PreserveSig]
        new HRESULT FillOpacityMask(/* _In_ */ ID2D1Bitmap opacityMask, /* _In_ */ ID2D1Brush brush, /* optional(D2D_RECT_F) */ IntPtr destinationRectangle, /* optional(D2D_RECT_F) */ IntPtr sourceRectangle);
        
        [PreserveSig]
        new HRESULT FillGeometry(/* _In_ */ ID2D1Geometry geometry, /* _In_ */ ID2D1Brush brush, /* _In_opt_ */ ID2D1Brush opacityBrush);
        
        [PreserveSig]
        new HRESULT FillRectangle(/* _In_ */ ref D2D_RECT_F rect, /* _In_ */ ID2D1Brush brush);
        
        [PreserveSig]
        new HRESULT PushAxisAlignedClip(/* _In_ */ ref D2D_RECT_F clipRect, D2D1_ANTIALIAS_MODE antialiasMode);
        
        [PreserveSig]
        new HRESULT PushLayer(/* _In_ */ ref D2D1_LAYER_PARAMETERS1 layerParameters1, /* _In_opt_ */ ID2D1Layer layer);
        
        [PreserveSig]
        new HRESULT PopAxisAlignedClip();
        
        [PreserveSig]
        new HRESULT PopLayer();
        
        // ID2D1CommandSink1
        [PreserveSig]
        HRESULT SetPrimitiveBlend1(D2D1_PRIMITIVE_BLEND primitiveBlend);
    }
}
