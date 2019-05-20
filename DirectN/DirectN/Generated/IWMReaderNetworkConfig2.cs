// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(14567,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d979a853-042b-4050-8387-c939db22013f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderNetworkConfig2 : IWMReaderNetworkConfig
    {
        // IWMReaderNetworkConfig
        [PreserveSig]
        new HRESULT GetBufferingTime(/* [out] */ out ulong pcnsBufferingTime);
        
        [PreserveSig]
        new HRESULT SetBufferingTime(/* [in] */ ulong cnsBufferingTime);
        
        [PreserveSig]
        new HRESULT GetUDPPortRanges(/* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] _WMPortNumberRange[] pRangeArray, /* [out][in] */ ref uint pcRanges);
        
        [PreserveSig]
        new HRESULT SetUDPPortRanges(/* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] _WMPortNumberRange[] pRangeArray, /* [in] */ uint cRanges);
        
        [PreserveSig]
        new HRESULT GetProxySettings(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [out] */ out WMT_PROXY_SETTINGS pProxySetting);
        
        [PreserveSig]
        new HRESULT SetProxySettings(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [in] */ WMT_PROXY_SETTINGS ProxySetting);
        
        [PreserveSig]
        new HRESULT GetProxyHostName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszHostName, /* [out][in] */ ref uint pcchHostName);
        
        [PreserveSig]
        new HRESULT SetProxyHostName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszHostName);
        
        [PreserveSig]
        new HRESULT GetProxyPort(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [out] */ out uint pdwPort);
        
        [PreserveSig]
        new HRESULT SetProxyPort(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [in] */ uint dwPort);
        
        [PreserveSig]
        new HRESULT GetProxyExceptionList(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszExceptionList, /* [out][in] */ ref uint pcchExceptionList);
        
        [PreserveSig]
        new HRESULT SetProxyExceptionList(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszExceptionList);
        
        [PreserveSig]
        new HRESULT GetProxyBypassForLocal(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [out] */ out bool pfBypassForLocal);
        
        [PreserveSig]
        new HRESULT SetProxyBypassForLocal(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocol, /* [in] */ bool fBypassForLocal);
        
        [PreserveSig]
        new HRESULT GetForceRerunAutoProxyDetection(/* [out] */ out bool pfForceRerunDetection);
        
        [PreserveSig]
        new HRESULT SetForceRerunAutoProxyDetection(/* [in] */ bool fForceRerunDetection);
        
        [PreserveSig]
        new HRESULT GetEnableMulticast(/* [out] */ out bool pfEnableMulticast);
        
        [PreserveSig]
        new HRESULT SetEnableMulticast(/* [in] */ bool fEnableMulticast);
        
        [PreserveSig]
        new HRESULT GetEnableHTTP(/* [out] */ out bool pfEnableHTTP);
        
        [PreserveSig]
        new HRESULT SetEnableHTTP(/* [in] */ bool fEnableHTTP);
        
        [PreserveSig]
        new HRESULT GetEnableUDP(/* [out] */ out bool pfEnableUDP);
        
        [PreserveSig]
        new HRESULT SetEnableUDP(/* [in] */ bool fEnableUDP);
        
        [PreserveSig]
        new HRESULT GetEnableTCP(/* [out] */ out bool pfEnableTCP);
        
        [PreserveSig]
        new HRESULT SetEnableTCP(/* [in] */ bool fEnableTCP);
        
        [PreserveSig]
        new HRESULT ResetProtocolRollover();
        
        [PreserveSig]
        new HRESULT GetConnectionBandwidth(/* [out] */ out uint pdwConnectionBandwidth);
        
        [PreserveSig]
        new HRESULT SetConnectionBandwidth(/* [in] */ uint dwConnectionBandwidth);
        
        [PreserveSig]
        new HRESULT GetNumProtocolsSupported(/* [out] */ out uint pcProtocols);
        
        [PreserveSig]
        new HRESULT GetSupportedProtocolName(/* [in] */ uint dwProtocolNum, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProtocolName, /* [out][in] */ ref uint pcchProtocolName);
        
        [PreserveSig]
        new HRESULT AddLoggingUrl(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszUrl);
        
        [PreserveSig]
        new HRESULT GetLoggingUrl(/* [in] */ uint dwIndex, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszUrl, /* [out][in] */ ref uint pcchUrl);
        
        [PreserveSig]
        new HRESULT GetLoggingUrlCount(/* [out] */ out uint pdwUrlCount);
        
        [PreserveSig]
        new HRESULT ResetLoggingUrlList();
        
        // IWMReaderNetworkConfig2
        [PreserveSig]
        HRESULT GetEnableContentCaching(/* [out] */ out bool pfEnableContentCaching);
        
        [PreserveSig]
        HRESULT SetEnableContentCaching(/* [in] */ bool fEnableContentCaching);
        
        [PreserveSig]
        HRESULT GetEnableFastCache(/* [out] */ out bool pfEnableFastCache);
        
        [PreserveSig]
        HRESULT SetEnableFastCache(/* [in] */ bool fEnableFastCache);
        
        [PreserveSig]
        HRESULT GetAcceleratedStreamingDuration(/* [out] */ out ulong pcnsAccelDuration);
        
        [PreserveSig]
        HRESULT SetAcceleratedStreamingDuration(/* [in] */ ulong cnsAccelDuration);
        
        [PreserveSig]
        HRESULT GetAutoReconnectLimit(/* [out] */ out uint pdwAutoReconnectLimit);
        
        [PreserveSig]
        HRESULT SetAutoReconnectLimit(/* [in] */ uint dwAutoReconnectLimit);
        
        [PreserveSig]
        HRESULT GetEnableResends(/* [out] */ out bool pfEnableResends);
        
        [PreserveSig]
        HRESULT SetEnableResends(/* [in] */ bool fEnableResends);
        
        [PreserveSig]
        HRESULT GetEnableThinning(/* [out] */ out bool pfEnableThinning);
        
        [PreserveSig]
        HRESULT SetEnableThinning(/* [in] */ bool fEnableThinning);
        
        [PreserveSig]
        HRESULT GetMaxNetPacketSize(/* [out] */ out uint pdwMaxNetPacketSize);
    }
}
