// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1229,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("18079135-4cf3-4868-bc8e-06067e6d242d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1CommandSink3 : ID2D1CommandSink2
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
        HRESULT DrawSpriteBatch(/* _In_ */ ID2D1SpriteBatch spriteBatch, uint startIndex, uint spriteCount, /* _In_ */ ref ID2D1Bitmap bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D1_SPRITE_OPTIONS spriteOptions);
    }
}
