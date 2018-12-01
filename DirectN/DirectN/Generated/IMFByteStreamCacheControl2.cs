// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(11142,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("71ce469c-f34b-49ea-a56b-2d2a10e51149"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFByteStreamCacheControl2 : IMFByteStreamCacheControl
    {
        // IMFByteStreamCacheControl
        [PreserveSig]
        new HRESULT StopBackgroundTransfer();
        
        // IMFByteStreamCacheControl2
        [PreserveSig]
        HRESULT GetByteRanges(/* [out] __RPC__out */ out uint pcRanges, /* [size_is][size_is][out] __RPC__deref_out_ecount_full_opt(*pcRanges) */ out __MIDL___MIDL_itf_mfidl_0000_0058_0001[] ppRanges);
        
        [PreserveSig]
        HRESULT SetCacheLimit(/* [in] */ ulong qwBytes);
        
        [PreserveSig]
        HRESULT IsBackgroundTransferActive(/* [out] __RPC__out */ out bool pfActive);
    }
}
