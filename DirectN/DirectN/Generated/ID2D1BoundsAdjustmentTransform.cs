// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effectauthor.h(845,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// An effect uses this interface to alter the image rectangle of its input.
    /// </summary>
    [ComImport, Guid("90f732e2-5092-4606-a819-8651970baccd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1BoundsAdjustmentTransform : ID2D1TransformNode
    {
        // ID2D1TransformNode
        [PreserveSig]
        new uint GetInputCount();
        
        // ID2D1BoundsAdjustmentTransform
        [PreserveSig]
        void SetOutputBounds(/* _In_ */ ref tagRECT outputBounds);
        
        [PreserveSig]
        void GetOutputBounds(/* _Out_ */ out tagRECT outputBounds);
    }
}
