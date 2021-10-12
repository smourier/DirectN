// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d2d1effectauthor.h(459,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    /// <summary>
    /// A transform uses this interface to specify how to render a particular pass in D2D.
    /// </summary>
    [ComImport, Guid("519ae1bd-d19a-420d-b849-364f594776b7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID2D1RenderInfo
    {
        [PreserveSig]
        HRESULT SetInputDescription(uint inputIndex, D2D1_INPUT_DESCRIPTION inputDescription);
        
        [PreserveSig]
        HRESULT SetOutputBuffer(D2D1_BUFFER_PRECISION bufferPrecision, D2D1_CHANNEL_DEPTH channelDepth);
        
        [PreserveSig]
        void SetCached(bool isCached);
        
        [PreserveSig]
        void SetInstructionCountHint(uint instructionCount);
    }
}
