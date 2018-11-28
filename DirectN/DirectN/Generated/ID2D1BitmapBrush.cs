using System;
using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;

namespace DirectN
{
    [Guid("2cd906aa-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1BitmapBrush : ID2D1Brush
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

        // ID2D1BitmapBrush
        [PreserveSig]
        void SetExtendModeX(D2D1_EXTEND_MODE extendModeX);

        [PreserveSig]
        void SetExtendModeY(D2D1_EXTEND_MODE extendModeY);

        [PreserveSig]
        void SetInterpolationMode(D2D1_BITMAP_INTERPOLATION_MODE interpolationMode);

        [PreserveSig]
        void SetBitmap(ID2D1Bitmap bitmap);

        [PreserveSig]
        D2D1_EXTEND_MODE GetExtendModeX();

        [PreserveSig]
        D2D1_EXTEND_MODE GetExtendModeY();

        [PreserveSig]
        D2D1_BITMAP_INTERPOLATION_MODE GetInterpolationMode();

        [PreserveSig]
        void GetBitmap(out ID2D1Bitmap bitmap);
    }
}
