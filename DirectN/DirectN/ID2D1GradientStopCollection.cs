using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2cd906a7-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1GradientStopCollection : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1GradientStopCollection
        [PreserveSig]
        int GetGradientStopCount();

        [PreserveSig]
        void GetGradientStops(IntPtr /*D2D1_GRADIENT_STOP*/ gradientStops, int gradientStopsCount);

        [PreserveSig]
        D2D1_GAMMA GetColorInterpolationGamma();

        [PreserveSig]
        D2D1_EXTEND_MODE GetExtendMode();
    }
}
