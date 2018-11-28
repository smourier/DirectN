using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2cd9069d-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID2D1StrokeStyle : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(out ID2D1Factory factory);

        // ID2D1StrokeStyle 
        [PreserveSig]
        D2D1_CAP_STYLE GetStartCap();

        [PreserveSig]
        D2D1_CAP_STYLE GetEndCap();

        [PreserveSig]
        D2D1_CAP_STYLE GetDashCap();

        [PreserveSig]
        float GetMiterLimit();

        [PreserveSig]
        D2D1_LINE_JOIN GetLineJoin();

        [PreserveSig]
        float GetDashOffset();

        [PreserveSig]
        D2D1_DASH_STYLE GetDashStyle();

        [PreserveSig]
        int GetDashesCount();

        [PreserveSig]
        void GetDashes([In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] dashes, int dashesCount);
    }
}
