// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(16490,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a4503bec-5508-4148-97ac-bfa75760a70d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMRegisteredDevice
    {
        [PreserveSig]
        HRESULT GetDeviceSerialNumber(/* [out] */ out _DRM_VAL16 pSerialNumber);
        
        [PreserveSig]
        HRESULT GetDeviceCertificate(/* [out] */ out INSSBuffer ppCertificate);
        
        [PreserveSig]
        HRESULT GetDeviceType(/* [out] */ out uint pdwType);
        
        [PreserveSig]
        HRESULT GetAttributeCount(/* [out] */ out uint pcAttributes);
        
        [PreserveSig]
        HRESULT GetAttributeByIndex(/* [in] */ uint dwIndex, /* [out] */ out IntPtr pbstrName, /* [out] */ out IntPtr pbstrValue);
        
        [PreserveSig]
        HRESULT GetAttributeByName(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName, /* [out] */ out IntPtr pbstrValue);
        
        [PreserveSig]
        HRESULT SetAttributeByName(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrValue);
        
        [PreserveSig]
        HRESULT Approve(/* [in] */ bool fApprove);
        
        [PreserveSig]
        HRESULT IsValid(/* [out] */ out bool pfValid);
        
        [PreserveSig]
        HRESULT IsApproved(/* [out] */ out bool pfApproved);
        
        [PreserveSig]
        HRESULT IsWmdrmCompliant(/* [out] */ out bool pfCompliant);
        
        [PreserveSig]
        HRESULT IsOpened(/* [out] */ out bool pfOpened);
        
        [PreserveSig]
        HRESULT Open();
        
        [PreserveSig]
        HRESULT Close();
    }
}
