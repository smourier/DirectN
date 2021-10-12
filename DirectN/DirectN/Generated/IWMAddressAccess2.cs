// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(18854,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("65a83fc2-3e98-4d4d-81b5-2a742886b33d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMAddressAccess2 : IWMAddressAccess
    {
        // IWMAddressAccess
        [PreserveSig]
        new HRESULT GetAccessEntryCount(/* [in] */ WM_AETYPE aeType, /* [out] */ out uint pcEntries);
        
        [PreserveSig]
        new HRESULT GetAccessEntry(/* [in] */ WM_AETYPE aeType, /* [in] */ uint dwEntryNum, /* [out] */ out _WMAddressAccessEntry pAddrAccessEntry);
        
        [PreserveSig]
        new HRESULT AddAccessEntry(/* [in] */ WM_AETYPE aeType, /* [in] */ ref _WMAddressAccessEntry pAddrAccessEntry);
        
        [PreserveSig]
        new HRESULT RemoveAccessEntry(/* [in] */ WM_AETYPE aeType, /* [in] */ uint dwEntryNum);
        
        // IWMAddressAccess2
        [PreserveSig]
        HRESULT GetAccessEntryEx(/* [in] */ WM_AETYPE aeType, /* [in] */ uint dwEntryNum, /* [out] */ out IntPtr pbstrAddress, /* [out] */ out IntPtr pbstrMask);
        
        [PreserveSig]
        HRESULT AddAccessEntryEx(/* [in] */ WM_AETYPE aeType, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAddress, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrMask);
    }
}
