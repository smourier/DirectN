// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(3680,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7f91ce67-090c-4bb7-b78e-ed8ff2e31da0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VersionedRootSignatureDeserializer
    {
        [PreserveSig]
        HRESULT GetRootSignatureDescAtVersion(D3D_ROOT_SIGNATURE_VERSION convertToVersion, /* _Out_ */ out IntPtr ppDesc);
        
        [PreserveSig]
        void GetUnconvertedRootSignatureDesc(out D3D12_VERSIONED_ROOT_SIGNATURE_DESC size);
    }
}
