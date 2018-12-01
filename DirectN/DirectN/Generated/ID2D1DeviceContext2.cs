// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_3.h(793,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// This interface performs all the same functions as the ID2D1DeviceContext1 interface, plus it enables functionality such as ink rendering, gradient mesh rendering, and improved image loading.
    /// </summary>
    [Guid("394ea6a3-0c34-4321-950b-6ca20f0be6c7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1DeviceContext2
    {
        [PreserveSig]
        HRESULT CreateInk(/* _In_ */ ref D2D1_INK_POINT startPoint, /* _COM_Outptr_ */ out ID2D1Ink ink);
        
        [PreserveSig]
        HRESULT CreateInkStyle(/* _In_opt_ */ ref D2D1_INK_STYLE_PROPERTIES inkStyleProperties, /* _COM_Outptr_ */ out ID2D1InkStyle inkStyle);
        
        [PreserveSig]
        HRESULT CreateGradientMesh(/* _In_reads_(patchesCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_GRADIENT_MESH_PATCH[] patches, uint patchesCount, /* _COM_Outptr_ */ out ID2D1GradientMesh gradientMesh);
        
        [PreserveSig]
        HRESULT CreateImageSourceFromWic(/* _In_ */ ref IWICBitmapSource wicBitmapSource, D2D1_IMAGE_SOURCE_LOADING_OPTIONS loadingOptions, D2D1_ALPHA_MODE alphaMode, /* _COM_Outptr_ */ out ID2D1ImageSourceFromWic imageSource);
        
        [PreserveSig]
        HRESULT CreateLookupTable3D(D2D1_BUFFER_PRECISION precision, /* _In_reads_(3) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] uint[] extents, /* _In_reads_(dataCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] data, uint dataCount, /* _In_reads_(2) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] uint[] strides, /* _COM_Outptr_ */ out ID2D1LookupTable3D lookupTable);
        
        [PreserveSig]
        HRESULT CreateImageSourceFromDxgi(/* _In_reads_(surfaceCount) */ out IDXGISurface[] surfaces, uint surfaceCount, DXGI_COLOR_SPACE_TYPE colorSpace, D2D1_IMAGE_SOURCE_FROM_DXGI_OPTIONS options, /* _COM_Outptr_ */ out ID2D1ImageSource imageSource);
        
        [PreserveSig]
        HRESULT GetGradientMeshWorldBounds(/* _In_ */ ID2D1GradientMesh gradientMesh, /* _Out_ */ out D2D_RECT_F pBounds);
        
        [PreserveSig]
        void DrawInk(/* _In_ */ ID2D1Ink ink, /* _In_ */ ref ID2D1Brush brush, /* _In_opt_ */ ID2D1InkStyle inkStyle);
        
        [PreserveSig]
        void DrawGradientMesh(/* _In_ */ ID2D1GradientMesh gradientMesh);
        
        [PreserveSig]
        void DrawGdiMetafile(/* _In_ */ ref ID2D1GdiMetafile gdiMetafile, /* _In_opt_ */ ref D2D_RECT_F destinationRectangle, /* _In_opt_ */ ref D2D_RECT_F sourceRectangle);
        
        [PreserveSig]
        HRESULT CreateTransformedImageSource(/* _In_ */ ID2D1ImageSource imageSource, /* _In_ */ ref D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES properties, /* _COM_Outptr_ */ out ID2D1TransformedImageSource transformedImageSource);
    }
}
