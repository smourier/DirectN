// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfcontentdecryptionmodule.h(263,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3f96ee40-ad81-4096-8470-59a4b770f89a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFContentDecryptionModuleSessionCallbacks
    {
        [PreserveSig]
        HRESULT KeyMessage(/* [in] */ MF_MEDIAKEYSESSION_MESSAGETYPE messageType, /* [size_is][in] __RPC__in_ecount_full(messageSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] message, /* [in] */ int messageSize, /* [optional][in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string destinationURL);
        
        [PreserveSig]
        HRESULT KeyStatusChanged();
    }
}
