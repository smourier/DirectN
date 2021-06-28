// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effectauthor.h(791,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// An effect uses this interface to configure a blending operation.
    /// </summary>
    [ComImport, Guid("63ac0b32-ba44-450f-8806-7f4ca1ff2f1b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1BlendTransform : ID2D1ConcreteTransform
    {
        // ID2D1TransformNode
        [PreserveSig]
        new uint GetInputCount();
        
        // ID2D1ConcreteTransform
        [PreserveSig]
        new HRESULT SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);
        
        [PreserveSig]
        new void SetCached(bool isCached);
        
        // ID2D1BlendTransform
        [PreserveSig]
        void SetDescription(/* _In_ */ ref D2D1_BLEND_DESCRIPTION description);
        
        [PreserveSig]
        void GetDescription(/* _Out_ */ out D2D1_BLEND_DESCRIPTION description);
    }
}
