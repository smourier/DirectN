// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(11287,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("71ce469c-f34b-49ea-a56b-2d2a10e51149"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFByteStreamCacheControl2 : IMFByteStreamCacheControl
    {
        // IMFByteStreamCacheControl
        [PreserveSig]
        new HRESULT StopBackgroundTransfer();
        
        // IMFByteStreamCacheControl2
        [PreserveSig]
        HRESULT GetByteRanges(/* [out] __RPC__out */ out uint pcRanges, /* optional(__MIDL___MIDL_itf_mfidl_0000_0059_0001) */ out IntPtr ppRanges);
        
        [PreserveSig]
        HRESULT SetCacheLimit(/* [in] */ ulong qwBytes);
        
        [PreserveSig]
        HRESULT IsBackgroundTransferActive(/* [out] __RPC__out */ out bool pfActive);
    }
}
