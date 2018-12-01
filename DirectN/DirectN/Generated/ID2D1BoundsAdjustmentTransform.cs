// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d2d1effectauthor.h(845,1)
using System;
using System.Runtime.InteropServices;
using D2D1_RECT_L = DirectN.tagRECT;

namespace DirectN
{
    [Guid("90f732e2-5092-4606-a819-8651970baccd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1BoundsAdjustmentTransform : ID2D1TransformNode
    {
        // ID2D1TransformNode
        [PreserveSig]
        new uint GetInputCount();
        
        // ID2D1BoundsAdjustmentTransform
        [PreserveSig]
        void SetOutputBounds(/* _In_ */ ref D2D1_RECT_L outputBounds);
        
        [PreserveSig]
        void GetOutputBounds(/* _Out_ */ out D2D1_RECT_L outputBounds);
    }
}
