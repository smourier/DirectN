// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("34ab647b-3cc8-46ac-841b-c0965645c046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12RootSignatureDeserializer
    {
        [PreserveSig]
        void GetRootSignatureDesc(out D3D12_ROOT_SIGNATURE_DESC size);
    }
}
