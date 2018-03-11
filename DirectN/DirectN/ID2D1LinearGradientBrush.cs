using System;
using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_POINT_2F = DirectN.D2D_POINT_2F;

namespace DirectN
{
    [Guid("2cd906ab-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1LinearGradientBrush : ID2D1Brush
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

        // ID2D1LinearGradientBrush
        [PreserveSig]
        void SetStartPoint(D2D1_POINT_2F startPoint);

        [PreserveSig]
        void SetEndPoint(D2D1_POINT_2F endPoint);

        [PreserveSig]
        D2D1_POINT_2F GetStartPoint();

        [PreserveSig]
        D2D1_POINT_2F GetEndPoint();

        [PreserveSig]
        void GetGradientStopCollection(out ID2D1GradientStopCollection gradientStopCollection);
    }
}
