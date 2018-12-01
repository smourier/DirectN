// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(1148,1)
using System;
using System.Runtime.InteropServices;
using D2D1_RECT_F = DirectN.D2D_RECT_F;

namespace DirectN
{
    [Guid("235a7496-8351-414c-bcd4-6672ab2d8e00"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1DeviceContext3 : ID2D1DeviceContext2
    {
        // ID2D1DeviceContext2
        [PreserveSig]
        new HRESULT CreateInk(/* _In_ */ ref D2D1_INK_POINT startPoint, /* _COM_Outptr_ */ out ID2D1Ink ink);
        
        [PreserveSig]
        new HRESULT CreateInkStyle(/* optional(D2D1_INK_STYLE_PROPERTIES) */ IntPtr inkStyleProperties, /* _COM_Outptr_ */ out ID2D1InkStyle inkStyle);
        
        [PreserveSig]
        new HRESULT CreateGradientMesh(/* _In_reads_(patchesCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_GRADIENT_MESH_PATCH[] patches, uint patchesCount, /* _COM_Outptr_ */ out ID2D1GradientMesh gradientMesh);
        
        [PreserveSig]
        new HRESULT CreateImageSourceFromWic(/* _In_ */ ref IWICBitmapSource wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions, D2D1_ALPHA_MODE alphaMode, /* _COM_Outptr_ */ out ID2D1ImageSourceFromWic imageSource);
        
        [PreserveSig]
        new HRESULT CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, /* _In_reads_(3) */ [MarshalAs(UnmanagedType.LPArray)] uint[] extents, /* _In_reads_(dataCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, uint dataCount, /* _In_reads_(2) */ [MarshalAs(UnmanagedType.LPArray)] uint[] strides, /* _COM_Outptr_ */ out ID2D1LookupTable3D lookupTable);
        
        [PreserveSig]
        new HRESULT CreateImageSourceFromDxgi(/* _In_reads_(surfaceCount) */ out IntPtr surfaces, uint surfaceCount, DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, /* _COM_Outptr_ */ out ID2D1ImageSource imageSource);
        
        [PreserveSig]
        new HRESULT GetGradientMeshWorldBounds(/* _In_ */ ID2D1GradientMesh gradientMesh, /* _Out_ */ out D2D1_RECT_F pBounds);
        
        [PreserveSig]
        new void DrawInk(/* _In_ */ ID2D1Ink ink, /* _In_ */ ref ID2D1Brush brush, /* _In_opt_ */ ID2D1InkStyle inkStyle);
        
        [PreserveSig]
        new void DrawGradientMesh(/* _In_ */ ID2D1GradientMesh gradientMesh);
        
        [PreserveSig]
        new void DrawGdiMetafile(/* _In_ */ ref ID2D1GdiMetafile gdiMetafile, /* optional(D2D1_RECT_F) */ IntPtr destinationRectangle, /* optional(D2D1_RECT_F) */ IntPtr sourceRectangle);
        
        [PreserveSig]
        new HRESULT CreateTransformedImageSource(/* _In_ */ ID2D1ImageSource imageSource, /* _In_ */ ref D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES properties, /* _COM_Outptr_ */ out ID2D1TransformedImageSource transformedImageSource);
        
        // ID2D1DeviceContext3
        [PreserveSig]
        HRESULT CreateSpriteBatch(/* _COM_Outptr_ */ out ID2D1SpriteBatch spriteBatch);
        
        [PreserveSig]
        void DrawSpriteBatch(/* _In_ */ ID2D1SpriteBatch spriteBatch, uint startIndex, uint spriteCount, /* _In_ */ ref ID2D1Bitmap bitmap, D2D1_BITMAP_INTERPOLATION_MODE interpolationMode, D2D1_SPRITE_OPTIONS spriteOptions);
    }
}
