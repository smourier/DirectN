// generated from <Windows SDK Path>\um\d2d1effectauthor.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// Base interface for built-in transforms on which precision and caching may be controlled.
    /// </summary>
    [ComImport, Guid("1a799d8a-69f7-4e4c-9fed-437ccc6684cc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1ConcreteTransform : ID2D1TransformNode
    {
        // ID2D1TransformNode
        [PreserveSig]
        new uint GetInputCount();
        
        // ID2D1ConcreteTransform
        [PreserveSig]
        HRESULT SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);
        
        [PreserveSig]
        void SetCached(bool isCached);
    }
}
