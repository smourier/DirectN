// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7f91ce67-090c-4bb7-b78e-ed8ff2e31da0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VersionedRootSignatureDeserializer
    {
        [PreserveSig]
        HRESULT GetRootSignatureDescAtVersion(D3D_ROOT_SIGNATURE_VERSION convertToVersion, /* _Out_ */ out IntPtr ppDesc);
        
        [PreserveSig]
        void GetUnconvertedRootSignatureDesc(out D3D12_VERSIONED_ROOT_SIGNATURE_DESC size);
    }
}
