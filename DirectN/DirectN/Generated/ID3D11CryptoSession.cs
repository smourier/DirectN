// generated from <Windows SDK Path>\um\d3d11.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9b32f9ad-bdcc-40a6-a39d-d5c865845720"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11CryptoSession : ID3D11DeviceChild
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        // ID3D11CryptoSession
        [PreserveSig]
        void GetCryptoType(/* [annotation] _Out_ */ out Guid pCryptoType);
        
        [PreserveSig]
        void GetDecoderProfile(/* [annotation] _Out_ */ out Guid pDecoderProfile);
        
        [PreserveSig]
        HRESULT GetCertificateSize(/* [annotation] _Out_ */ out uint pCertificateSize);
        
        [PreserveSig]
        HRESULT GetCertificate(/* [annotation] _In_ */ int CertificateSize, /* [annotation] _Out_writes_bytes_(CertificateSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pCertificate);
        
        [PreserveSig]
        void GetCryptoSessionHandle(/* [annotation] _Out_ */ out IntPtr pCryptoSessionHandle);
    }
}
