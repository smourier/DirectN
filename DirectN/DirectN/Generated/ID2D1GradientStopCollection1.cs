// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d2d1_1.h(1443,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ae1572f4-5dd0-4777-998b-9279472ae63b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1GradientStopCollection1 : ID2D1GradientStopCollection
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1GradientStopCollection
        [PreserveSig]
        new uint GetGradientStopCount();
        
        [PreserveSig]
        new void GetGradientStops(/* _Out_writes_to_(gradientStopsCount, _Inexpressible_("Retrieved through GetGradientStopCount()") ) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_GRADIENT_STOP[] gradientStops, uint gradientStopsCount);
        
        [PreserveSig]
        new D2D1_GAMMA GetColorInterpolationGamma();
        
        [PreserveSig]
        new D2D1_EXTEND_MODE GetExtendMode();
        
        // ID2D1GradientStopCollection1
        [PreserveSig]
        void GetGradientStops1(/* _Out_writes_to_(gradientStopsCount, _Inexpressible_("Retrieved through GetGradientStopCount()") ) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D2D1_GRADIENT_STOP[] gradientStops, uint gradientStopsCount);
        
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
