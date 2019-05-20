// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmp.h(11266,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b22c85f9-263c-4372-a0da-b518db9b4098"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPSyncDevice3 : IWMPSyncDevice2
    {
        // IWMPSyncDevice
        [PreserveSig]
        new HRESULT get_friendlyName(/* [retval][out] */ out IntPtr pbstrName);
        
        [PreserveSig]
        new HRESULT put_friendlyName(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName);
        
        [PreserveSig]
        new HRESULT get_deviceName(/* [retval][out] */ out IntPtr pbstrName);
        
        [PreserveSig]
        new HRESULT get_deviceId(/* [retval][out] */ out IntPtr pbstrDeviceId);
        
        [PreserveSig]
        new HRESULT get_partnershipIndex(/* [retval][out] */ out long plIndex);
        
        [PreserveSig]
        new HRESULT get_connected(/* [retval][out] */ out bool pvbConnected);
        
        [PreserveSig]
        new HRESULT get_status(/* [retval][out] */ out WMPDeviceStatus pwmpds);
        
        [PreserveSig]
        new HRESULT get_syncState(/* [retval][out] */ out WMPSyncState pwmpss);
        
        [PreserveSig]
        new HRESULT get_progress(/* [retval][out] */ out long plProgress);
        
        [PreserveSig]
        new HRESULT getItemInfo(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName, /* [retval][out] */ out IntPtr pbstrVal);
        
        [PreserveSig]
        new HRESULT createPartnership(/* [in] */ bool vbShowUI);
        
        [PreserveSig]
        new HRESULT deletePartnership();
        
        [PreserveSig]
        new HRESULT start();
        
        [PreserveSig]
        new HRESULT stop();
        
        [PreserveSig]
        new HRESULT showSettings();
        
        [PreserveSig]
        new HRESULT isIdentical(/* [in] */ IWMPSyncDevice pDevice, /* [retval][out] */ out bool pvbool);
        
        // IWMPSyncDevice2
        [PreserveSig]
        new HRESULT setItemInfo(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrVal);
        
        // IWMPSyncDevice3
        [PreserveSig]
        HRESULT estimateSyncSize(/* [unique][in] */ IWMPPlaylist pNonRulePlaylist, /* [unique][in] */ IWMPPlaylist pRulesPlaylist);
        
        [PreserveSig]
        HRESULT cancelEstimation();
    }
}
