// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11shader.h(399,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("207bcecb-d683-4a06-a8a3-9b149b9f73a4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11FunctionReflection
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D11_FUNCTION_DESC pDesc);
        
        [PreserveSig]
        ID3D11ShaderReflectionConstantBuffer GetConstantBufferByIndex(/* THIS_ _In_ */ uint BufferIndex);
        
        [PreserveSig]
        ID3D11ShaderReflectionConstantBuffer GetConstantBufferByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        HRESULT GetResourceBindingDesc(/* THIS_ _In_ */ uint ResourceIndex, /* _Out_ */ out _D3D11_SHADER_INPUT_BIND_DESC pDesc);
        
        [PreserveSig]
        ID3D11ShaderReflectionVariable GetVariableByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        HRESULT GetResourceBindingDescByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name, /* _Out_ */ out _D3D11_SHADER_INPUT_BIND_DESC pDesc);
        
        [PreserveSig]
        ID3D11FunctionParameterReflection GetFunctionParameter(/* THIS_ _In_ */ int ParameterIndex);
    }
}
