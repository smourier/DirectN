// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(1158,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Represents an collection of gradient stops that can then be the source resource for either a linear or radial gradient brush.
    /// </summary>
    [ComImport, Guid("2cd906a7-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GradientStopCollection : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1GradientStopCollection
        [PreserveSig]
        uint GetGradientStopCount();
        
        [PreserveSig]
        void GetGradientStops(/* _Out_writes_to_(gradientStopsCount, _Inexpressible_("Retrieved through GetGradientStopCount()") ) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_GRADIENT_STOP[] gradientStops, int gradientStopsCount);
        
        [PreserveSig]
        D2D1_GAMMA GetColorInterpolationGamma();
        
        [PreserveSig]
        D2D1_EXTEND_MODE GetExtendMode();
    }
}
