// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmp.h(9140,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("82a2986c-0293-4fd0-b279-b21b86c058be"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPSyncDevice
    {
        [PreserveSig]
        HRESULT get_friendlyName(/* [retval][out] */ out IntPtr pbstrName);
        
        [PreserveSig]
        HRESULT put_friendlyName(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName);
        
        [PreserveSig]
        HRESULT get_deviceName(/* [retval][out] */ out IntPtr pbstrName);
        
        [PreserveSig]
        HRESULT get_deviceId(/* [retval][out] */ out IntPtr pbstrDeviceId);
        
        [PreserveSig]
        HRESULT get_partnershipIndex(/* [retval][out] */ out long plIndex);
        
        [PreserveSig]
        HRESULT get_connected(/* [retval][out] */ out bool pvbConnected);
        
        [PreserveSig]
        HRESULT get_status(/* [retval][out] */ out WMPDeviceStatus pwmpds);
        
        [PreserveSig]
        HRESULT get_syncState(/* [retval][out] */ out WMPSyncState pwmpss);
        
        [PreserveSig]
        HRESULT get_progress(/* [retval][out] */ out long plProgress);
        
        [PreserveSig]
        HRESULT getItemInfo(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName, /* [retval][out] */ out IntPtr pbstrVal);
        
        [PreserveSig]
        HRESULT createPartnership(/* [in] */ bool vbShowUI);
        
        [PreserveSig]
        HRESULT deletePartnership();
        
        [PreserveSig]
        HRESULT start();
        
        [PreserveSig]
        HRESULT stop();
        
        [PreserveSig]
        HRESULT showSettings();
        
        [PreserveSig]
        HRESULT isIdentical(/* [in] */ IWMPSyncDevice pDevice, /* [retval][out] */ out bool pvbool);
    }
}
