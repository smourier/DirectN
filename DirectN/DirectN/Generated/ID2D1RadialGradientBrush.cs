using System;
using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;

namespace DirectN
{
    [Guid("2cd906ac-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1RadialGradientBrush : ID2D1Brush
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1Brush
        [PreserveSig]
        new void SetOpacity(float opacity);

        [PreserveSig]
        new void SetTransform(ref D2D1_MATRIX_3X2_F transform);

        [PreserveSig]
        new float GetOpacity();

        [PreserveSig]
        new void GetTransform(ref D2D1_MATRIX_3X2_F transform);

        // ID2D1RadialGradientBrush
        [PreserveSig]
        void SetCenter(D2D1_POINT_2F center);

        [PreserveSig]
        void SetGradientOriginOffset(D2D1_POINT_2F gradientOriginOffset);

        [PreserveSig]
        void SetRadiusX(float radiusX);

        [PreserveSig]
        void SetRadiusY(float radiusY);

        [PreserveSig]
        D2D1_POINT_2F GetCenter();

        [PreserveSig]
        D2D1_POINT_2F GetGradientOriginOffset();

        [PreserveSig]
        float GetRadiusX();

        [PreserveSig]
        float GetRadiusY();

        [PreserveSig]
        void GetGradientStopCollection(out ID2D1GradientStopCollection gradientStopCollection);
    }
}
