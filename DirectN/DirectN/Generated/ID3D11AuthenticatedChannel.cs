// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11.h(10635,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3015a308-dcbd-47aa-a747-192486d14d4a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11AuthenticatedChannel : ID3D11DeviceChild
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
        
        // ID3D11AuthenticatedChannel
        [PreserveSig]
        HRESULT GetCertificateSize(/* [annotation] _Out_ */ out uint pCertificateSize);
        
        [PreserveSig]
        HRESULT GetCertificate(/* [annotation] _In_ */ uint CertificateSize, /* [annotation] _Out_writes_bytes_(CertificateSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pCertificate);
        
        [PreserveSig]
        void GetChannelHandle(/* [annotation] _Out_ */ out IntPtr pChannelHandle);
    }
}
