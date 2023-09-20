// generated from <Windows SDK Path>\shared\d3d9.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ff24beee-da21-4beb-98b5-d2f899f98af9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirect3DAuthenticatedChannel9
    {
        [PreserveSig]
        HRESULT GetCertificateSize(ref uint pCertificateSize);
        
        [PreserveSig]
        HRESULT GetCertificate(uint CertifacteSize, ref byte ppCertificate);
        
        [PreserveSig]
        HRESULT NegotiateKeyExchange(uint DataSize, IntPtr pData);
        
        [PreserveSig]
        HRESULT Query(uint InputSize, IntPtr pInput, uint OutputSize, IntPtr pOutput);
        
        [PreserveSig]
        HRESULT Configure(uint InputSize, IntPtr pInput, ref _D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT pOutput);
    }
}
