using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ae1572f4-5dd0-4777-998b-9279472ae63b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1GradientStopCollection1 : ID2D1GradientStopCollection
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1GradientStopCollection
        [PreserveSig]
        new int GetGradientStopCount();

        [PreserveSig]
        new void GetGradientStops(D2D1_GRADIENT_STOP[] gradientStops, int gradientStopsCount);

        [PreserveSig]
        new D2D1_GAMMA GetColorInterpolationGamma();

        [PreserveSig]
        new D2D1_EXTEND_MODE GetExtendMode();

        // ID2D1GradientStopCollection1
        [PreserveSig]
        void GetGradientStops1(D2D1_GRADIENT_STOP[] gradientStops, int gradientStopsCount);

        [PreserveSig]
        D2D1_COLOR_SPACE GetPreInterpolationSpace();

        [PreserveSig]
        D2D1_COLOR_SPACE GetPostInterpolationSpace();

        [PreserveSig]
        D2D1_BUFFER_PRECISION GetBufferPrecision();

        [PreserveSig]
        D2D1_COLOR_INTERPOLATION_MODE GetColorInterpolationMode();
    }
}
