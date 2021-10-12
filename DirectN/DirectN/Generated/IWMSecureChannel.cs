// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsecure.h(228,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2720598a-d0f2-4189-bd10-91c46ef0936f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMSecureChannel : IWMAuthorizer
    {
        // IWMAuthorizer
        [PreserveSig]
        new HRESULT GetCertCount(/* [out] */ out uint pcCerts);
        
        [PreserveSig]
        new HRESULT GetCert(/* [in] */ uint dwIndex, /* [out] */ out IntPtr ppbCertData);
        
        [PreserveSig]
        new HRESULT GetSharedData(/* [in] */ uint dwCertIndex, /* [in] */ ref byte pbSharedData, /* [in] */ ref byte pbCert, /* [out] */ out IntPtr ppbSharedData);
        
        // IWMSecureChannel
        [PreserveSig]
        HRESULT WMSC_AddCertificate(/* [in] */ IWMAuthorizer pCert);
        
        [PreserveSig]
        HRESULT WMSC_AddSignature(/* [in] */ ref byte pbCertSig, /* [in] */ uint cbCertSig);
        
        [PreserveSig]
        HRESULT WMSC_Connect(/* [in] */ IWMSecureChannel pOtherSide);
        
        [PreserveSig]
        HRESULT WMSC_IsConnected(/* [out] */ out bool pfIsConnected);
        
        [PreserveSig]
        HRESULT WMSC_Disconnect();
        
        [PreserveSig]
        HRESULT WMSC_GetValidCertificate(/* [out] */ out IntPtr ppbCertificate, /* [out] */ out uint pdwSignature);
        
        [PreserveSig]
        HRESULT WMSC_Encrypt(/* [in] */ ref byte pbData, /* [in] */ uint cbData);
        
        [PreserveSig]
        HRESULT WMSC_Decrypt(/* [in] */ ref byte pbData, /* [in] */ uint cbData);
        
        [PreserveSig]
        HRESULT WMSC_Lock();
        
        [PreserveSig]
        HRESULT WMSC_Unlock();
        
        [PreserveSig]
        HRESULT WMSC_SetSharedData(/* [in] */ uint dwCertIndex, /* [in] */ ref byte pbSharedData);
    }
}
