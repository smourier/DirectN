// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmp.h(3423,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ec21b779-edef-462d-bba4-ad9dde2b29a7"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPNetwork
    {
        [PreserveSig]
        HRESULT get_bandWidth(/* [retval][out] */ out long plBandwidth);
        
        [PreserveSig]
        HRESULT get_recoveredPackets(/* [retval][out] */ out long plRecoveredPackets);
        
        [PreserveSig]
        HRESULT get_sourceProtocol(/* [retval][out] */ out IntPtr pbstrSourceProtocol);
        
        [PreserveSig]
        HRESULT get_receivedPackets(/* [retval][out] */ out long plReceivedPackets);
        
        [PreserveSig]
        HRESULT get_lostPackets(/* [retval][out] */ out long plLostPackets);
        
        [PreserveSig]
        HRESULT get_receptionQuality(/* [retval][out] */ out long plReceptionQuality);
        
        [PreserveSig]
        HRESULT get_bufferingCount(/* [retval][out] */ out long plBufferingCount);
        
        [PreserveSig]
        HRESULT get_bufferingProgress(/* [retval][out] */ out long plBufferingProgress);
        
        [PreserveSig]
        HRESULT get_bufferingTime(/* [retval][out] */ out long plBufferingTime);
        
        [PreserveSig]
        HRESULT put_bufferingTime(/* [in] */ int lBufferingTime);
        
        [PreserveSig]
        HRESULT get_frameRate(/* [retval][out] */ out long plFrameRate);
        
        [PreserveSig]
        HRESULT get_maxBitRate(/* [retval][out] */ out long plBitRate);
        
        [PreserveSig]
        HRESULT get_bitRate(/* [retval][out] */ out long plBitRate);
        
        [PreserveSig]
        HRESULT getProxySettings(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [retval][out] */ out long plProxySetting);
        
        [PreserveSig]
        HRESULT setProxySettings(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [in] */ int lProxySetting);
        
        [PreserveSig]
        HRESULT getProxyName(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [retval][out] */ out IntPtr pbstrProxyName);
        
        [PreserveSig]
        HRESULT setProxyName(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProxyName);
        
        [PreserveSig]
        HRESULT getProxyPort(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [retval][out] */ out long lProxyPort);
        
        [PreserveSig]
        HRESULT setProxyPort(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [in] */ int lProxyPort);
        
        [PreserveSig]
        HRESULT getProxyExceptionList(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [retval][out] */ out IntPtr pbstrExceptionList);
        
        [PreserveSig]
        HRESULT setProxyExceptionList(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string pbstrExceptionList);
        
        [PreserveSig]
        HRESULT getProxyBypassForLocal(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [retval][out] */ out bool pfBypassForLocal);
        
        [PreserveSig]
        HRESULT setProxyBypassForLocal(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [in] */ bool fBypassForLocal);
        
        [PreserveSig]
        HRESULT get_maxBandwidth(/* [retval][out] */ out long lMaxBandwidth);
        
        [PreserveSig]
        HRESULT put_maxBandwidth(/* [in] */ int lMaxBandwidth);
        
        [PreserveSig]
        HRESULT get_downloadProgress(/* [retval][out] */ out long plDownloadProgress);
        
        [PreserveSig]
        HRESULT get_encodedFrameRate(/* [retval][out] */ out long plFrameRate);
        
        [PreserveSig]
        HRESULT get_framesSkipped(/* [retval][out] */ out long plFrames);
    }
}
