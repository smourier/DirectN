// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6d66d782-1d4f-4db7-8c63-cb8c77f1ef5e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
