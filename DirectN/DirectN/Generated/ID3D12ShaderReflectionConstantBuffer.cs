// generated from <Windows SDK Path>\um\d3d12shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c59598b4-48b3-4869-b9b1-b1618b14a8b7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
