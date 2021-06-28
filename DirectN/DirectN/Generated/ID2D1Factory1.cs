// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_1.h(2223,1)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using PD2D1_EFFECT_FACTORY = System.IntPtr;

namespace DirectN
{
    /// <summary>
    /// Creates Direct2D resources.
    /// </summary>
    [ComImport, Guid("bb12d362-daee-4b9a-aa1d-14ba401cfa1f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1Factory1 : ID2D1Factory
    {
        // ID2D1Factory
        [PreserveSig]
        new HRESULT ReloadSystemMetrics();
        
        [PreserveSig]
        new void GetDesktopDpi(/* _Out_ */ out float dpiX, /* _Out_ */ out float dpiY);
        
        [PreserveSig]
        new HRESULT CreateRectangleGeometry(/* _In_ */ ref D2D_RECT_F rectangle, /* _COM_Outptr_ */ out ID2D1RectangleGeometry rectangleGeometry);
        
        [PreserveSig]
        new HRESULT CreateRoundedRectangleGeometry(/* _In_ */ ref D2D1_ROUNDED_RECT roundedRectangle, /* _COM_Outptr_ */ out ID2D1RoundedRectangleGeometry roundedRectangleGeometry);
        
        [PreserveSig]
        new HRESULT CreateEllipseGeometry(/* _In_ */ ref D2D1_ELLIPSE ellipse, /* _COM_Outptr_ */ out ID2D1EllipseGeometry ellipseGeometry);
        
        [PreserveSig]
        new HRESULT CreateGeometryGroup(D2D1_FILL_MODE fillMode, /* _In_reads_(geometriesCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID2D1Geometry[] geometries, int geometriesCount, /* _COM_Outptr_ */ out ID2D1GeometryGroup geometryGroup);
        
        [PreserveSig]
        new HRESULT CreateTransformedGeometry(/* _In_ */ ID2D1Geometry sourceGeometry, /* _In_ */ ref D2D_MATRIX_3X2_F transform, /* _COM_Outptr_ */ out ID2D1TransformedGeometry transformedGeometry);
        
        [PreserveSig]
        new HRESULT CreatePathGeometry(/* _COM_Outptr_ */ out ID2D1PathGeometry pathGeometry);
        
        [PreserveSig]
        new HRESULT CreateStrokeStyle(/* _In_ */ ref D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties, /* _In_reads_opt_(dashesCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] dashes, int dashesCount, /* _COM_Outptr_ */ out ID2D1StrokeStyle strokeStyle);
        
        [PreserveSig]
        new HRESULT CreateDrawingStateBlock(/* optional(D2D1_DRAWING_STATE_DESCRIPTION) */ IntPtr drawingStateDescription, /* _In_opt_ */ IDWriteRenderingParams textRenderingParams, /* _COM_Outptr_ */ out ID2D1DrawingStateBlock drawingStateBlock);
        
        [PreserveSig]
        new HRESULT CreateWicBitmapRenderTarget(/* _In_ */ IWICBitmap target, /* _In_ */ ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, /* _COM_Outptr_ */ out ID2D1RenderTarget renderTarget);
        
        [PreserveSig]
        new HRESULT CreateHwndRenderTarget(/* _In_ */ ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, /* _In_ */ ref D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties, /* _COM_Outptr_ */ out ID2D1HwndRenderTarget hwndRenderTarget);
        
        [PreserveSig]
        new HRESULT CreateDxgiSurfaceRenderTarget(/* _In_ */ IDXGISurface dxgiSurface, /* _In_ */ ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, /* _COM_Outptr_ */ out ID2D1RenderTarget renderTarget);
        
        [PreserveSig]
        new HRESULT CreateDCRenderTarget(/* _In_ */ ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, /* _COM_Outptr_ */ out ID2D1DCRenderTarget dcRenderTarget);
        
        // ID2D1Factory1
        [PreserveSig]
        HRESULT CreateDevice(/* _In_ */ IDXGIDevice dxgiDevice, /* _COM_Outptr_ */ out ID2D1Device d2dDevice);
        
        [PreserveSig]
        HRESULT CreateStrokeStyle(/* _In_ */ ref D2D1_STROKE_STYLE_PROPERTIES1 strokeStyleProperties, /* _In_reads_opt_(dashesCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] dashes, int dashesCount, /* _COM_Outptr_ */ out ID2D1StrokeStyle1 strokeStyle);
        
        [PreserveSig]
        HRESULT CreatePathGeometry(/* _COM_Outptr_ */ out ID2D1PathGeometry1 pathGeometry);
        
        [PreserveSig]
        HRESULT CreateDrawingStateBlock(/* optional(D2D1_DRAWING_STATE_DESCRIPTION1) */ IntPtr drawingStateDescription, /* _In_opt_ */ IDWriteRenderingParams textRenderingParams, /* _COM_Outptr_ */ out ID2D1DrawingStateBlock1 drawingStateBlock);
        
        [PreserveSig]
        HRESULT CreateGdiMetafile(/* _In_ */ IStream metafileStream, /* _COM_Outptr_ */ out ID2D1GdiMetafile metafile);
        
        [PreserveSig]
        HRESULT RegisterEffectFromStream(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid classId, /* _In_ */ IStream propertyXml, /* _In_reads_opt_(bindingsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D2D1_PROPERTY_BINDING[] bindings, int bindingsCount, /* _In_ */ PD2D1_EFFECT_FACTORY effectFactory);
        
        [PreserveSig]
        HRESULT RegisterEffectFromString(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid classId, /* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string propertyXml, /* _In_reads_opt_(bindingsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D2D1_PROPERTY_BINDING[] bindings, int bindingsCount, /* _In_ */ PD2D1_EFFECT_FACTORY effectFactory);
        
        [PreserveSig]
        HRESULT UnregisterEffect(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid classId);
        
        [PreserveSig]
        HRESULT GetRegisteredEffects(/* _Out_writes_to_opt_(effectsCount, *effectsReturned) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] Guid[] effects, int effectsCount, /* optional(UINT32) */ IntPtr effectsReturned, /* optional(UINT32) */ IntPtr effectsRegistered);
        
        [PreserveSig]
        HRESULT GetEffectProperties(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid effectId, /* _COM_Outptr_ */ out ID2D1Properties properties);
    }
}
