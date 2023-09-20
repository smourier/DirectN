// generated from <Windows SDK Path>\um\wmsecure.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("94bc0598-c3d2-11d3-bedf-00c04f612986"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMGetSecureChannel
    {
        [PreserveSig]
        HRESULT GetPeerSecureChannelInterface(/* [out] */ out IWMSecureChannel ppPeer);
    }
}
