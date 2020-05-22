// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(5890,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7a924e51-73c1-494d-8019-23d37ed9b89a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMProfileManager2 : IWMProfileManager
    {
        // IWMProfileManager
        [PreserveSig]
        new HRESULT CreateEmptyProfile(/* [in] */ WMT_VERSION dwVersion, /* [out] */ out IWMProfile ppProfile);
        
        [PreserveSig]
        new HRESULT LoadProfileByID(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidProfile, /* [out] */ out IWMProfile ppProfile);
        
        [PreserveSig]
        new HRESULT LoadProfileByData(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProfile, /* [out] */ out IWMProfile ppProfile);
        
        [PreserveSig]
        new HRESULT SaveProfile(/* [in] */ IWMProfile pIWMProfile, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProfile, /* [out][in] */ ref uint pdwLength);
        
        [PreserveSig]
        new HRESULT GetSystemProfileCount(/* [out] */ out uint pcProfiles);
        
        [PreserveSig]
        new HRESULT LoadSystemProfile(/* [in] */ uint dwProfileIndex, /* [out] */ out IWMProfile ppProfile);
        
        // IWMProfileManager2
        [PreserveSig]
        HRESULT GetSystemProfileVersion(ref WMT_VERSION pdwVersion);
        
        [PreserveSig]
        HRESULT SetSystemProfileVersion(WMT_VERSION dwVersion);
    }
}
