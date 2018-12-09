// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmlss.h(742,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("01f5f85e-0a81-40da-a7c8-21ef3af8440c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWindowsMediaLibrarySharingServices
    {
        [PreserveSig]
        HRESULT showShareMediaCPL(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string device);
        
        [PreserveSig]
        HRESULT get_userHomeMediaSharingState(/* [retval][out] */ out VARIANT_BOOL sharingEnabled);
        
        [PreserveSig]
        HRESULT put_userHomeMediaSharingState(/* [in] */ short sharingEnabled);
        
        [PreserveSig]
        HRESULT get_userHomeMediaSharingLibraryName(/* [retval][out] */ out IntPtr libraryName);
        
        [PreserveSig]
        HRESULT put_userHomeMediaSharingLibraryName(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string libraryName);
        
        [PreserveSig]
        HRESULT get_computerHomeMediaSharingAllowedState(/* [retval][out] */ out VARIANT_BOOL sharingAllowed);
        
        [PreserveSig]
        HRESULT put_computerHomeMediaSharingAllowedState(/* [in] */ short sharingAllowed);
        
        [PreserveSig]
        HRESULT get_userInternetMediaSharingState(/* [retval][out] */ out VARIANT_BOOL sharingEnabled);
        
        [PreserveSig]
        HRESULT put_userInternetMediaSharingState(/* [in] */ short sharingEnabled);
        
        [PreserveSig]
        HRESULT get_computerInternetMediaSharingAllowedState(/* [retval][out] */ out VARIANT_BOOL sharingAllowed);
        
        [PreserveSig]
        HRESULT put_computerInternetMediaSharingAllowedState(/* [in] */ short sharingAllowed);
        
        [PreserveSig]
        HRESULT get_internetMediaSharingSecurityGroup(/* [retval][out] */ out IntPtr securityGroup);
        
        [PreserveSig]
        HRESULT put_internetMediaSharingSecurityGroup(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string securityGroup);
        
        [PreserveSig]
        HRESULT get_allowSharingToAllDevices(/* [retval][out] */ out VARIANT_BOOL sharingEnabled);
        
        [PreserveSig]
        HRESULT put_allowSharingToAllDevices(/* [in] */ short sharingEnabled);
        
        [PreserveSig]
        HRESULT setDefaultAuthorization(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string MACAddresses, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string friendlyName, /* [in] */ short authorization);
        
        [PreserveSig]
        HRESULT setAuthorizationState(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string MACAddress, /* [in] */ short authorizationState);
        
        [PreserveSig]
        HRESULT getAllDevices(/* [retval][out] */ out IWindowsMediaLibrarySharingDevices devices);
        
        [PreserveSig]
        HRESULT get_customSettingsApplied(/* [retval][out] */ out VARIANT_BOOL customSettingsApplied);
    }
}
