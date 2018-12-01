// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1_1.h(970,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// The ID2D1PathGeometry1 interface adds functionality to ID2D1PathGeometry. In particular, it provides the path geometry-specific ComputePointAndSegmentAtLength method.
    /// </summary>
    [Guid("62baa2d2-ab54-41b7-b872-787e0106a421"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1PathGeometry1
    {
        [PreserveSig]
        HRESULT ComputePointAndSegmentAtLength(float length, uint startSegment, /* _In_opt_ */ ref D2D_MATRIX_3X2_F worldTransform, float flatteningTolerance, /* _Out_ */ out D2D1_POINT_DESCRIPTION pointDescription);
    }
}
