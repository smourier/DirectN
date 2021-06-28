// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(3341,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The root factory interface for all of D2D's objects.
    /// </summary>
    [ComImport, Guid("06152247-6f50-465a-9245-118bfd3b6007"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Factory
    {
        [PreserveSig]
        HRESULT ReloadSystemMetrics();
        
        [PreserveSig]
        void GetDesktopDpi(/* _Out_ */ out float dpiX, /* _Out_ */ out float dpiY);
        
        [PreserveSig]
        HRESULT CreateRectangleGeometry(/* _In_ */ ref D2D_RECT_F rectangle, /* _COM_Outptr_ */ out ID2D1RectangleGeometry rectangleGeometry);
        
        [PreserveSig]
        HRESULT CreateRoundedRectangleGeometry(/* _In_ */ ref D2D1_ROUNDED_RECT roundedRectangle, /* _COM_Outptr_ */ out ID2D1RoundedRectangleGeometry roundedRectangleGeometry);
        
        [PreserveSig]
        HRESULT CreateEllipseGeometry(/* _In_ */ ref D2D1_ELLIPSE ellipse, /* _COM_Outptr_ */ out ID2D1EllipseGeometry ellipseGeometry);
        
        [PreserveSig]
        HRESULT CreateGeometryGroup(D2D1_FILL_MODE fillMode, /* _In_reads_(geometriesCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID2D1Geometry[] geometries, int geometriesCount, /* _COM_Outptr_ */ out ID2D1GeometryGroup geometryGroup);
        
        [PreserveSig]
        HRESULT CreateTransformedGeometry(/* _In_ */ ID2D1Geometry sourceGeometry, /* _In_ */ ref D2D_MATRIX_3X2_F transform, /* _COM_Outptr_ */ out ID2D1TransformedGeometry transformedGeometry);
        
        [PreserveSig]
        HRESULT CreatePathGeometry(/* _COM_Outptr_ */ out ID2D1PathGeometry pathGeometry);
        
        [PreserveSig]
        HRESULT CreateStrokeStyle(/* _In_ */ ref D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties, /* _In_reads_opt_(dashesCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] dashes, int dashesCount, /* _COM_Outptr_ */ out ID2D1StrokeStyle strokeStyle);
        
        [PreserveSig]
        HRESULT CreateDrawingStateBlock(/* optional(D2D1_DRAWING_STATE_DESCRIPTION) */ IntPtr drawingStateDescription, /* _In_opt_ */ IDWriteRenderingParams textRenderingParams, /* _COM_Outptr_ */ out ID2D1DrawingStateBlock drawingStateBlock);
        
        [PreserveSig]
        HRESULT CreateWicBitmapRenderTarget(/* _In_ */ IWICBitmap target, /* _In_ */ ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, /* _COM_Outptr_ */ out ID2D1RenderTarget renderTarget);
        
        [PreserveSig]
        HRESULT CreateHwndRenderTarget(/* _In_ */ ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, /* _In_ */ ref D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties, /* _COM_Outptr_ */ out ID2D1HwndRenderTarget hwndRenderTarget);
        
        [PreserveSig]
        HRESULT CreateDxgiSurfaceRenderTarget(/* _In_ */ IDXGISurface dxgiSurface, /* _In_ */ ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, /* _COM_Outptr_ */ out ID2D1RenderTarget renderTarget);
        
        [PreserveSig]
        HRESULT CreateDCRenderTarget(/* _In_ */ ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, /* _COM_Outptr_ */ out ID2D1DCRenderTarget dcRenderTarget);
    }
}
