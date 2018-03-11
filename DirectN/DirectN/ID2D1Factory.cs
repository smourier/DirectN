using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using D2D1_RECT_F = DirectN.D2D_RECT_F;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;

namespace DirectN
{
    [Guid("06152247-6f50-465a-9245-118bfd3b6007"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1Factory
    {
        [PreserveSig]
        HRESULT ReloadSystemMetrics();

        [PreserveSig]
        void GetDesktopDpi(out float dpiX, out float dpiY);

        [PreserveSig]
        HRESULT CreateRectangleGeometry(ref D2D1_RECT_F rectangle, out ID2D1RectangleGeometry rectangleGeometry);

        [PreserveSig]
        HRESULT CreateRoundedRectangleGeometry(ref D2D1_ROUNDED_RECT roundedRectangle, out ID2D1RoundedRectangleGeometry roundedRectangleGeometry);

        [PreserveSig]
        HRESULT CreateEllipseGeometry(ref D2D1_ELLIPSE ellipse, out ID2D1EllipseGeometry ellipseGeometry);

        [PreserveSig]
        HRESULT CreateGeometryGroup(D2D1_FILL_MODE fillMode, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID2D1Geometry geometries, int geometriesCount, out ID2D1GeometryGroup geometryGroup);

        [PreserveSig]
        HRESULT CreateTransformedGeometry(ID2D1Geometry sourceGeometry, ref D2D1_MATRIX_3X2_F transform, out ID2D1TransformedGeometry transformedGeometry);

        [PreserveSig]
        HRESULT CreatePathGeometry(out ID2D1PathGeometry pathGeometry);

        [PreserveSig]
        HRESULT CreateStrokeStyle(ref D2D1_STROKE_STYLE_PROPERTIES strokeStyleProperties, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] dashes, int dashesCount, out ID2D1StrokeStyle strokeStyle);

        [PreserveSig]
        HRESULT CreateDrawingStateBlock(ref D2D1_DRAWING_STATE_DESCRIPTION drawingStateDescription, IDWriteRenderingParams textRenderingParams, out ID2D1DrawingStateBlock drawingStateBlock);

        [PreserveSig]
        HRESULT CreateWicBitmapRenderTarget(IWICBitmap target, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, out ID2D1RenderTarget renderTarget);

        [PreserveSig]
        HRESULT CreateHwndRenderTarget(ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, ref D2D1_HWND_RENDER_TARGET_PROPERTIES hwndRenderTargetProperties, out ID2D1HwndRenderTarget hwndRenderTarget);

        [PreserveSig]
        HRESULT CreateDxgiSurfaceRenderTarget(IDXGISurface dxgiSurface, ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, out ID2D1RenderTarget renderTarget);

        [PreserveSig]
        HRESULT CreateDCRenderTarget(ref D2D1_RENDER_TARGET_PROPERTIES renderTargetProperties, out ID2D1DCRenderTarget dcRenderTarget);
    }
}
