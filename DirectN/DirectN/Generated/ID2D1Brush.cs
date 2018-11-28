using System;
using System.Runtime.InteropServices;
using D2D1_MATRIX_3X2_F = DirectN.D2D_MATRIX_3X2_F;

namespace DirectN
{
    [Guid("2cd906a8-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1Brush : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1Brush
        [PreserveSig]
        void SetOpacity(float opacity);

        [PreserveSig]
        void SetTransform(ref D2D1_MATRIX_3X2_F transform);

        [PreserveSig]
        float GetOpacity();

        [PreserveSig]
        void GetTransform(ref D2D1_MATRIX_3X2_F transform);
    }
}
