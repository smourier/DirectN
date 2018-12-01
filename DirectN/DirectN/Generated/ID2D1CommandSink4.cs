// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1545,1)
using System;
using System.Runtime.InteropServices;
using D2D1_RECT_F = DirectN.D2D_RECT_F;

namespace DirectN
{
    [Guid("c78a6519-40d6-4218-b2de-beeeb744bb3e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1CommandSink4 : ID2D1CommandSink3
    {
        // ID2D1CommandSink2
        [PreserveSig]
        new HRESULT DrawInk(/* _In_ */ ID2D1Ink ink, /* _In_ */ ref ID2D1Brush brush, /* _In_opt_ */ ID2D1InkStyle inkStyle);
        
        [PreserveSig]
        new HRESULT DrawGradientMesh(/* _In_ */ ID2D1GradientMesh gradientMesh);
        
        [PreserveSig]
        new HRESULT DrawGdiMetafile(/* _In_ */ ref ID2D1GdiMetafile gdiMetafile, /* optional(D2D1_RECT_F) */ IntPtr destinationRectangle, /* optional(D2D1_RECT_F) */ IntPtr sourceRectangle);
        
        // ID2D1CommandSink3
        [PreserveSig]
        new HRESULT DrawSpriteBatch(/* _In_ */ ID2D1SpriteBatch spriteBatch, uint startIndex, uint spriteCount, /* _In_ */ ref ID2D1Bitmap bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D1_SPRITE_OPTIONS spriteOptions);
        
        // ID2D1CommandSink4
        [PreserveSig]
        HRESULT SetPrimitiveBlend2(D2D1_PRIMITIVE_BLEND primitiveBlend);
    }
}
