// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(11041,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9b32f9ad-bdcc-40a6-a39d-d5c865845720"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11CryptoSession : ID3D11DeviceChild
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* [annotation] _Out_writes_bytes_opt_( *pDataSize ) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_reads_bytes_opt_( DataSize ) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        // ID3D11CryptoSession
        [PreserveSig]
        void GetCryptoType(/* [annotation] _Out_ */ out Guid pCryptoType);
        
        [PreserveSig]
        void GetDecoderProfile(/* [annotation] _Out_ */ out Guid pDecoderProfile);
        
        [PreserveSig]
        HRESULT GetCertificateSize(/* [annotation] _Out_ */ out uint pCertificateSize);
        
        [PreserveSig]
        HRESULT GetCertificate(/* [annotation] _In_ */ uint CertificateSize, /* [annotation] _Out_writes_bytes_(CertificateSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pCertificate);
        
        [PreserveSig]
        void GetCryptoSessionHandle(/* [annotation] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object pCryptoSessionHandle);
    }
}
