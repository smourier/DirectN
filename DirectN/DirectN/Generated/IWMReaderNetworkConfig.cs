// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(14135,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("96406bec-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderNetworkConfig
    {
        [PreserveSig]
        HRESULT GetBufferingTime(/* [out] */ out ulong pcnsBufferingTime);
        
        [PreserveSig]
        HRESULT SetBufferingTime(/* [in] */ ulong cnsBufferingTime);
        
        [PreserveSig]
        HRESULT GetUDPPortRanges(/* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] _WMPortNumberRange[] pRangeArray, /* [out][in] */ ref uint pcRanges);
        
        [PreserveSig]
        HRESULT SetUDPPortRanges(/* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] _WMPortNumberRange[] pRangeArray, /* [in] */ uint cRanges);
        
        [PreserveSig]
        HRESULT GetProxySettings(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [out] */ out WMT_PROXY_SETTINGS pProxySetting);
        
        [PreserveSig]
        HRESULT SetProxySettings(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [in] */ WMT_PROXY_SETTINGS ProxySetting);
        
        [PreserveSig]
        HRESULT GetProxyHostName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszHostName, /* [out][in] */ ref uint pcchHostName);
        
        [PreserveSig]
        HRESULT SetProxyHostName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszHostName);
        
        [PreserveSig]
        HRESULT GetProxyPort(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [out] */ out uint pdwPort);
        
        [PreserveSig]
        HRESULT SetProxyPort(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [in] */ uint dwPort);
        
        [PreserveSig]
        HRESULT GetProxyExceptionList(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszExceptionList, /* [out][in] */ ref uint pcchExceptionList);
        
        [PreserveSig]
        HRESULT SetProxyExceptionList(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszExceptionList);
        
        [PreserveSig]
        HRESULT GetProxyBypassForLocal(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [out] */ out bool pfBypassForLocal);
        
        [PreserveSig]
        HRESULT SetProxyBypassForLocal(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [in] */ bool fBypassForLocal);
        
        [PreserveSig]
        HRESULT GetForceRerunAutoProxyDetection(/* [out] */ out bool pfForceRerunDetection);
        
        [PreserveSig]
        HRESULT SetForceRerunAutoProxyDetection(/* [in] */ bool fForceRerunDetection);
        
        [PreserveSig]
        HRESULT GetEnableMulticast(/* [out] */ out bool pfEnableMulticast);
        
        [PreserveSig]
        HRESULT SetEnableMulticast(/* [in] */ bool fEnableMulticast);
        
        [PreserveSig]
        HRESULT GetEnableHTTP(/* [out] */ out bool pfEnableHTTP);
        
        [PreserveSig]
        HRESULT SetEnableHTTP(/* [in] */ bool fEnableHTTP);
        
        [PreserveSig]
        HRESULT GetEnableUDP(/* [out] */ out bool pfEnableUDP);
        
        [PreserveSig]
        HRESULT SetEnableUDP(/* [in] */ bool fEnableUDP);
        
        [PreserveSig]
        HRESULT GetEnableTCP(/* [out] */ out bool pfEnableTCP);
        
        [PreserveSig]
        HRESULT SetEnableTCP(/* [in] */ bool fEnableTCP);
        
        [PreserveSig]
        HRESULT ResetProtocolRollover();
        
        [PreserveSig]
        HRESULT GetConnectionBandwidth(/* [out] */ out uint pdwConnectionBandwidth);
        
        [PreserveSig]
        HRESULT SetConnectionBandwidth(/* [in] */ uint dwConnectionBandwidth);
        
        [PreserveSig]
        HRESULT GetNumProtocolsSupported(/* [out] */ out uint pcProtocols);
        
        [PreserveSig]
        HRESULT GetSupportedProtocolName(/* [in] */ uint dwProtocolNum, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocolName, /* [out][in] */ ref uint pcchProtocolName);
        
        [PreserveSig]
        HRESULT AddLoggingUrl(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszUrl);
        
        [PreserveSig]
        HRESULT GetLoggingUrl(/* [in] */ uint dwIndex, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, /* [out][in] */ ref uint pcchUrl);
        
        [PreserveSig]
        HRESULT GetLoggingUrlCount(/* [out] */ out uint pdwUrlCount);
        
        [PreserveSig]
        HRESULT ResetLoggingUrlList();
    }
}
