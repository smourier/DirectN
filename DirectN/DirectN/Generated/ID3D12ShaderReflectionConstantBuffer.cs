// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12shader.h(312,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c59598b4-48b3-4869-b9b1-b1618b14a8b7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12ShaderReflectionConstantBuffer
    {
        [PreserveSig]
        HRESULT GetDesc(ref _D3D12_SHADER_BUFFER_DESC pDesc);
        
        [PreserveSig]
        ID3D12ShaderReflectionVariable GetVariableByIndex(/* THIS_ _In_ */ uint Index);
        
        [PreserveSig]
        ID3D12ShaderReflectionVariable GetVariableByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name);
    }
}
