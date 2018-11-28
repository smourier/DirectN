using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_RECT_F = DirectN.D2D_RECT_F;

namespace DirectN
{
    [Guid("06152247-6f50-465a-9245-118bfd3b6007"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1Factory1 : ID2D1Factory
    {
        // ID2D1Factory
        [PreserveSig]
        new HRESULT ReloadSystemMetrics();

        [PreserveSig]
        new void GetDesktopDpi(out float dpiX, out float dpiY);

        [PreserveSig]
        new HRESULT CreateRectangleGeometry(ref D2D1_RECT_F rectangle, out ID2D1RectangleGeometry rectangleGeometry);

        [PreserveSig]
        new HRESULT CreateRoundedRectangleGeometry(ref D2D1_ROUNDED_RECT roundedRectangle, out ID2D1RoundedRectangleGeometry roundedRectangleGeometry);

        [PreserveSig]
        new HRESULT CreateEllipseGeometry(ref D2D1_ELLIPSE ellipse, out ID2D1EllipseGeometry ellipseGeometry);

        [PreserveSig]
        new HRESULT CreateGeometryGroup(D2D1_FILL_MODE fillMode, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID2D1Geometry geometries, int geometriesCount, out ID2D1GeometryGroup geometryGroup);

        [PreserveSig]
        new HRESULT CreateTransformedGeometry(ID2D1Geometry sourceGeometry, ref D2D1_MATRIX_3X2_F transform, out ID2D1TransformedGeometry transformedGeometry);

        [PreserveSig]
        new HRESULT CreatePathGeometry(out ID2D1PathGeometry pathGeometry);

        [PreserveSig]
        new HRESULT CreateStrokeStyle(ref D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] dashes, int dashesCount, out ID2D1StrokeStyle strokeStyle);

        [PreserveSig]
        new HRESULT CreateDrawingStateBlock(ref D2D1_DRAWING_STATE_DESCRIPTION drawingStateDescription, IDWriteRenderingParams textRenderingParams, out ID2D1DrawingStateBlock drawingStateBlock);

        [PreserveSig]
        new HRESULT CreateWicBitmapRenderTarget(IWICBitmap target, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, out ID2D1RenderTarget renderTarget);

        [PreserveSig]
        new HRESULT CreateHwndRenderTarget(ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, ref D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties, out ID2D1HwndRenderTarget hwndRenderTarget);

        [PreserveSig]
        new HRESULT CreateDxgiSurfaceRenderTarget(IDXGISurface dxgiSurface, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, out ID2D1RenderTarget renderTarget);

        [PreserveSig]
        new HRESULT CreateDCRenderTarget(ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, out ID2D1DCRenderTarget dcRenderTarget);

        [PreserveSig]
        HRESULT CreateDevice(IDXGIDevice dxgiDevice, out ID2D1Device d2dDevice);

        [PreserveSig]
        HRESULT CreateStrokeStyle(
            ref D2D1_STROKE_STYLE_PROPERTIES1 strokeStyleProperties,
            float[] dashes,
            int dashesCount,
            out ID2D1StrokeStyle1 strokeStyle
            );

        [PreserveSig]
        HRESULT CreatePathGeometry(out ID2D1PathGeometry1 pathGeometry);

        [PreserveSig]
        HRESULT CreateDrawingStateBlock(
            ref D2D1_DRAWING_STATE_DESCRIPTION1 drawingStateDescription,
            IDWriteRenderingParams textRenderingParams,
            out ID2D1DrawingStateBlock1 drawingStateBlock
            );

        [PreserveSig]
        HRESULT CreateGdiMetafile(IStream metafileStream, out ID2D1GdiMetafile metafile);

        [PreserveSig]
        HRESULT RegisterEffectFromStream(
            [MarshalAs(UnmanagedType.LPStruct)] Guid classId,
            IStream propertyXml,
            D2D1_PROPERTY_BINDING[] bindings,
            int bindingsCount,
            PD2D1_EFFECT_FACTORY effectFactory
            );

        [PreserveSig]
        HRESULT RegisterEffectFromString(
            [MarshalAs(UnmanagedType.LPStruct)] Guid classId,
            [MarshalAs(UnmanagedType.LPWStr)] string propertyXml,
            D2D1_PROPERTY_BINDING[] bindings,
            int bindingsCount,
            PD2D1_EFFECT_FACTORY effectFactory
            );

        [PreserveSig]
        HRESULT UnregisterEffect([MarshalAs(UnmanagedType.LPStruct)] Guid classId);

        [PreserveSig]
        HRESULT GetRegisteredEffects([In, Out] Guid[] effects, int effectsCount, out int effectsReturned, out int effectsRegistered);
    }
}
