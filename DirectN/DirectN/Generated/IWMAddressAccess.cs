// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(18727,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bb3c6389-1633-4e92-af14-9f3173ba39d0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMAddressAccess
    {
        [PreserveSig]
        HRESULT GetAccessEntryCount(/* [in] */ WM_AETYPE aeType, /* [out] */ out uint pcEntries);
        
        [PreserveSig]
        HRESULT GetAccessEntry(/* [in] */ WM_AETYPE aeType, /* [in] */ uint dwEntryNum, /* [out] */ out _WMAddressAccessEntry pAddrAccessEntry);
        
        [PreserveSig]
        HRESULT AddAccessEntry(/* [in] */ WM_AETYPE aeType, /* [in] */ ref _WMAddressAccessEntry pAddrAccessEntry);
        
        [PreserveSig]
        HRESULT RemoveAccessEntry(/* [in] */ WM_AETYPE aeType, /* [in] */ uint dwEntryNum);
    }
}
