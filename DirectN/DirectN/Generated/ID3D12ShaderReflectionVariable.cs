// generated from <Windows SDK Path>\um\d3d12shader.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8337a8a6-a216-444a-b2f4-314733a73aea"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12ShaderReflectionVariable
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D12_SHADER_VARIABLE_DESC pDesc);
        
        [PreserveSig]
        ID3D12ShaderReflectionType GetType();
        
        [PreserveSig]
        ID3D12ShaderReflectionConstantBuffer GetBuffer();
        
        [PreserveSig]
        uint GetInterfaceSlot(/* THIS_ _In_ */ uint uArrayIndex);
    }
}
