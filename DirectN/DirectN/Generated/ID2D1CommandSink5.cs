// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1704,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7047dd26-b1e7-44a7-959a-8349e2144fa8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1CommandSink5 : ID2D1CommandSink4
    {
        // ID2D1CommandSink2
        [PreserveSig]
        new HRESULT DrawInk(/* _In_ */ ID2D1Ink ink, /* _In_ */ ref ID2D1Brush brush, /* _In_opt_ */ ID2D1InkStyle inkStyle);
        
        [PreserveSig]
        new HRESULT DrawGradientMesh(/* _In_ */ ID2D1GradientMesh gradientMesh);
        
        [PreserveSig]
        new HRESULT DrawGdiMetafile(/* _In_ */ ref ID2D1GdiMetafile gdiMetafile, /* _In_opt_ */ ref D2D_RECT_F destinationRectangle, /* _In_opt_ */ ref D2D_RECT_F sourceRectangle);
        
        // ID2D1CommandSink3
        [PreserveSig]
        new HRESULT DrawSpriteBatch(/* _In_ */ ID2D1SpriteBatch spriteBatch, uint startIndex, uint spriteCount, /* _In_ */ ref ID2D1Bitmap bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D1_SPRITE_OPTIONS spriteOptions);
        
        // ID2D1CommandSink4
        [PreserveSig]
        new HRESULT SetPrimitiveBlend2(D2D1_PRIMITIVE_BLEND primitiveBlend);
        
        // ID2D1CommandSink5
        [PreserveSig]
        HRESULT BlendImage(/* _In_ */ ref ID2D1Image image, D2D1_BLEND_MODE blendMode, /* _In_opt_ */ ref D2D_POINT_2F targetOffset, /* _In_opt_ */ ref D2D_RECT_F imageRectangle, D2D1_INTERPOLATION_MODE interpolationMode);
    }
}
