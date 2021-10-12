// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsecure.h(114,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d9b67d36-a9ad-4eb4-baef-db284ef5504c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMAuthorizer
    {
        [PreserveSig]
        HRESULT GetCertCount(/* [out] */ out uint pcCerts);
        
        [PreserveSig]
        HRESULT GetCert(/* [in] */ uint dwIndex, /* [out] */ out IntPtr ppbCertData);
        
        [PreserveSig]
        HRESULT GetSharedData(/* [in] */ uint dwCertIndex, /* [in] */ ref byte pbSharedData, /* [in] */ ref byte pbCert, /* [out] */ out IntPtr ppbSharedData);
    }
}
