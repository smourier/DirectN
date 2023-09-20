// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("73c66010-a299-41df-b1f0-ccf03b09c1c6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMClientConnections
    {
        [PreserveSig]
        HRESULT GetClientCount(/* [out] */ out uint pcClients);
        
        [PreserveSig]
        HRESULT GetClientProperties(/* [in] */ uint dwClientNum, /* [out] */ out _WMClientProperties pClientProperties);
    }
}
