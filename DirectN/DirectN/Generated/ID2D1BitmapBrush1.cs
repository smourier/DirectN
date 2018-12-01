// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_1.h(939,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A bitmap brush allows a bitmap to be used to fill a geometry. Interpolation mode is specified with D2D1_INTERPOLATION_MODE
    /// </summary>
    [Guid("41343a53-e41a-49a2-91cd-21793bbb62e5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1BitmapBrush1
    {
        [PreserveSig]
        void SetInterpolationMode1(D2D1_INTERPOLATION_MODE interpolationMode);
        
        [PreserveSig]
        D2D1_INTERPOLATION_MODE GetInterpolationMode1();
    }
}
