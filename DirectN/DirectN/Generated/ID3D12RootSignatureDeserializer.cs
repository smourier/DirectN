// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(3494,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("34ab647b-3cc8-46ac-841b-c0965645c046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12RootSignatureDeserializer
    {
        [PreserveSig]
        D3D12_ROOT_SIGNATURE_DESC GetRootSignatureDesc();
    }
}
