// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(10851,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6d66d782-1d4f-4db7-8c63-cb8c77f1ef5e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFByteStreamBuffering
    {
        [PreserveSig]
        HRESULT SetBufferingParams(/* [in] __RPC__in */ ref _MFBYTESTREAM_BUFFERING_PARAMS pParams);
        
        [PreserveSig]
        HRESULT EnableBuffering(/* [in] */ bool fEnable);
        
        [PreserveSig]
        HRESULT StopBuffering();
    }
}
