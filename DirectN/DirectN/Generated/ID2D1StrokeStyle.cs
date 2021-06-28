// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1.h(1380,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Resource interface that holds pen style properties.
    /// </summary>
    [ComImport, Guid("2cd9069d-12e2-11dc-9fed-001143a055f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1StrokeStyle : ID2D1Resource
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
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
        uint GetDashesCount();
        
        [PreserveSig]
        void GetDashes(/* _Out_writes_(dashesCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] dashes, int dashesCount);
    }
}
