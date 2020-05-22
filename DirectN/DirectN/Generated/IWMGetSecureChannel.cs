// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsecure.h(424,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("94bc0598-c3d2-11d3-bedf-00c04f612986"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMGetSecureChannel
    {
        [PreserveSig]
        HRESULT GetPeerSecureChannelInterface(/* [out] */ out IWMSecureChannel ppPeer);
    }
}
