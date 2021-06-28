// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1_1.h(957,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Extends a stroke style to allow nominal width strokes.
    /// </summary>
    [ComImport, Guid("10a72a66-e91c-43f4-993f-ddf4b82b0b4a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1StrokeStyle1 : ID2D1StrokeStyle
    {
        // ID2D1Resource
        [PreserveSig]
        new void GetFactory(/* _Outptr_ */ out ID2D1Factory factory);
        
        // ID2D1StrokeStyle
        [PreserveSig]
        new D2D1_CAP_STYLE GetStartCap();
        
        [PreserveSig]
        new D2D1_CAP_STYLE GetEndCap();
        
        [PreserveSig]
        new D2D1_CAP_STYLE GetDashCap();
        
        [PreserveSig]
        new float GetMiterLimit();
        
        [PreserveSig]
        new D2D1_LINE_JOIN GetLineJoin();
        
        [PreserveSig]
        new float GetDashOffset();
        
        [PreserveSig]
        new D2D1_DASH_STYLE GetDashStyle();
        
        [PreserveSig]
        new uint GetDashesCount();
        
        [PreserveSig]
        new void GetDashes(/* _Out_writes_(dashesCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] float[] dashes, int dashesCount);
        
        // ID2D1StrokeStyle1
        [PreserveSig]
        D2D1_STROKE_TRANSFORM_TYPE GetStrokeTransformType();
    }
}
