// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(10193,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("96406be7-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMWriterNetworkSink : IWMWriterSink
    {
        // IWMWriterSink
        [PreserveSig]
        new HRESULT OnHeader(/* [in] */ INSSBuffer pHeader);
        
        [PreserveSig]
        new HRESULT IsRealTime(/* [out] */ out bool pfRealTime);
        
        [PreserveSig]
        new HRESULT AllocateDataUnit(/* [in] */ uint cbDataUnit, /* [out] */ out INSSBuffer ppDataUnit);
        
        [PreserveSig]
        new HRESULT OnDataUnit(/* [in] */ INSSBuffer pDataUnit);
        
        [PreserveSig]
        new HRESULT OnEndWriting();
        
        // IWMWriterNetworkSink
        [PreserveSig]
        HRESULT SetMaximumClients(/* [in] */ uint dwMaxClients);
        
        [PreserveSig]
        HRESULT GetMaximumClients(/* [out] */ out uint pdwMaxClients);
        
        [PreserveSig]
        HRESULT SetNetworkProtocol(/* [in] */ WMT_NET_PROTOCOL protocol);
        
        [PreserveSig]
        HRESULT GetNetworkProtocol(/* [out] */ out WMT_NET_PROTOCOL pProtocol);
        
        [PreserveSig]
        HRESULT GetHostURL(/* [out] */ [MarshalAs(UnmanagedType.LPWStr)] out string pwszURL, /* [out][in] */ ref uint pcchURL);
        
        [PreserveSig]
        HRESULT Open(/* [out][in] */ ref uint pdwPortNum);
        
        [PreserveSig]
        HRESULT Disconnect();
        
        [PreserveSig]
        HRESULT Close();
    }
}
