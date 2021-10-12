// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(5995,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d16679f2-6ca0-472d-8d31-2f5d55aee155"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMProfileManager
    {
        [PreserveSig]
        HRESULT CreateEmptyProfile(/* [in] */ WMT_VERSION dwVersion, /* [out] */ out IWMProfile ppProfile);
        
        [PreserveSig]
        HRESULT LoadProfileByID(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidProfile, /* [out] */ out IWMProfile ppProfile);
        
        [PreserveSig]
        HRESULT LoadProfileByData(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProfile, /* [out] */ out IWMProfile ppProfile);
        
        [PreserveSig]
        HRESULT SaveProfile(/* [in] */ IWMProfile pIWMProfile, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszProfile, /* [out][in] */ ref uint pdwLength);
        
        [PreserveSig]
        HRESULT GetSystemProfileCount(/* [out] */ out uint pcProfiles);
        
        [PreserveSig]
        HRESULT LoadSystemProfile(/* [in] */ uint dwProfileIndex, /* [out] */ out IWMProfile ppProfile);
    }
}
