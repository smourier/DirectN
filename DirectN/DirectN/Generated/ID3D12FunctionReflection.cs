// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12shader.h(406,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1108795c-2772-4ba9-b2a8-d464dc7e2799"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12FunctionReflection
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D12_FUNCTION_DESC pDesc);
        
        [PreserveSig]
        ID3D12ShaderReflectionConstantBuffer GetConstantBufferByIndex(/* THIS_ _In_ */ uint BufferIndex);
        
        [PreserveSig]
        ID3D12ShaderReflectionConstantBuffer GetConstantBufferByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        HRESULT GetResourceBindingDesc(/* THIS_ _In_ */ uint ResourceIndex, /* _Out_ */ out _D3D12_SHADER_INPUT_BIND_DESC pDesc);
        
        [PreserveSig]
        ID3D12ShaderReflectionVariable GetVariableByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        HRESULT GetResourceBindingDescByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name, /* _Out_ */ out _D3D12_SHADER_INPUT_BIND_DESC pDesc);
        
        [PreserveSig]
        ID3D12FunctionParameterReflection GetFunctionParameter(/* THIS_ _In_ */ int ParameterIndex);
    }
}
