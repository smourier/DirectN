// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(10469,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4091571e-4701-4593-bb3d-d5f5f0c74246"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMClientConnections2 : IWMClientConnections
    {
        // IWMClientConnections
        [PreserveSig]
        new HRESULT GetClientCount(/* [out] */ out uint pcClients);
        
        [PreserveSig]
        new HRESULT GetClientProperties(/* [in] */ uint dwClientNum, /* [out] */ out _WMClientProperties pClientProperties);
        
        // IWMClientConnections2
        [PreserveSig]
        HRESULT GetClientInfo(/* [in] */ uint dwClientNum, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszNetworkAddress, /* [out][in] */ ref uint pcchNetworkAddress, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszPort, /* [out][in] */ ref uint pcchPort, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszDNSName, /* [out][in] */ ref uint pcchDNSName);
    }
}
