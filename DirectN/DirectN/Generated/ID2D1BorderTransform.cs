// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d2d1effectauthor.h(807,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// An effect uses this interface to configure border generation.
    /// </summary>
    [ComImport, Guid("4998735c-3a19-473c-9781-656847e3a347"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1BorderTransform : ID2D1ConcreteTransform
    {
        // ID2D1TransformNode
        [PreserveSig]
        new uint GetInputCount();
        
        // ID2D1ConcreteTransform
        [PreserveSig]
        new HRESULT SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);
        
        [PreserveSig]
        new void SetCached(bool isCached);
        
        // ID2D1BorderTransform
        [PreserveSig]
        void SetExtendModeX(D2D1_EXTEND_MODE extendMode);
        
        [PreserveSig]
        void SetExtendModeY(D2D1_EXTEND_MODE extendMode);
        
        [PreserveSig]
        D2D1_EXTEND_MODE GetExtendModeX();
        
        [PreserveSig]
        D2D1_EXTEND_MODE GetExtendModeY();
    }
}
