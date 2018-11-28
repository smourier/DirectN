using System;
using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;
using D2D1_RECT_F = DirectN.D2D_RECT_F;

namespace DirectN
{
    [Guid("fe9e984d-3f95-407c-b5db-cb94d4e8f87c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1ImageBrush : ID2D1Brush
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

        // ID2D1ImageBrush
        [PreserveSig]
        void SetImage(ID2D1Image image);

        [PreserveSig]
        void SetExtendModeX(D2D1_EXTEND_MODE extendModeX);

        [PreserveSig]
        void SetExtendModeY(D2D1_EXTEND_MODE extendModeY);

        [PreserveSig]
        void SetInterpolationMode(D2D1_INTERPOLATION_MODE interpolationMode);

        [PreserveSig]
        void SetSourceRectangle(ref D2D1_RECT_F sourceRectangle);

        [PreserveSig]
        void GetImage(out ID2D1Image image);

        [PreserveSig]
        D2D1_EXTEND_MODE GetExtendModeX();

        [PreserveSig]
        D2D1_EXTEND_MODE GetExtendModeY();

        [PreserveSig]
        D2D1_INTERPOLATION_MODE GetInterpolationMode();

        [PreserveSig]
        void GetSourceRectangle(out D2D1_RECT_F sourceRectangle);
    }
}
