// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(15400,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8e36395f-c7b9-43c4-a54d-512b4af63c95"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSampleProtection
    {
        [PreserveSig]
        HRESULT GetInputProtectionVersion(/* [annotation][out] _Out_ */ out uint pdwVersion);
        
        [PreserveSig]
        HRESULT GetOutputProtectionVersion(/* [annotation][out] _Out_ */ out uint pdwVersion);
        
        [PreserveSig]
        HRESULT GetProtectionCertificate(/* [in] */ uint dwVersion, /* [annotation][out] _Outptr_result_bytebuffer_(*pcbCert) */ out IntPtr ppCert, /* [annotation][out] _Out_ */ out uint pcbCert);
        
        [PreserveSig]
        HRESULT InitOutputProtection(/* [in] */ uint dwVersion, /* [in] */ uint dwOutputId, /* [in] */ ref byte pbCert, /* [in] */ uint cbCert, /* [out] */ out IntPtr ppbSeed, /* [out] */ out uint pcbSeed);
        
        [PreserveSig]
        HRESULT InitInputProtection(/* [in] */ uint dwVersion, /* [in] */ uint dwInputId, /* [in] */ ref byte pbSeed, /* [in] */ uint cbSeed);
    }
}
