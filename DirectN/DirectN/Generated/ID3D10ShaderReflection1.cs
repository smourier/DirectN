// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\d3d10_1shader.h(263,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c3457783-a846-47ce-9520-cea6f66e7447"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10ShaderReflection1
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D10_SHADER_DESC pDesc);
        
        [PreserveSig]
        ID3D10ShaderReflectionConstantBuffer GetConstantBufferByIndex(uint Index);
        
        [PreserveSig]
        ID3D10ShaderReflectionConstantBuffer GetConstantBufferByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        HRESULT GetResourceBindingDesc(uint ResourceIndex, /* _Out_ */ out _D3D10_SHADER_INPUT_BIND_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetInputParameterDesc(uint ParameterIndex, /* _Out_ */ out _D3D10_SIGNATURE_PARAMETER_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetOutputParameterDesc(uint ParameterIndex, /* _Out_ */ out _D3D10_SIGNATURE_PARAMETER_DESC pDesc);
        
        [PreserveSig]
        ID3D10ShaderReflectionVariable GetVariableByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        HRESULT GetResourceBindingDescByName([MarshalAs(UnmanagedType.LPStr)] string Name, /* _Out_ */ out _D3D10_SHADER_INPUT_BIND_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetMovInstructionCount(/* THIS_ _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetMovcInstructionCount(/* THIS_ _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetConversionInstructionCount(/* THIS_ _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetBitwiseInstructionCount(/* THIS_ _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetGSInputPrimitive(/* THIS_ _Out_ */ out D3D_PRIMITIVE pPrim);
        
        [PreserveSig]
        HRESULT IsLevel9Shader(/* THIS_ _Out_ */ out bool pbLevel9Shader);
        
        [PreserveSig]
        HRESULT IsSampleFrequencyShader(/* THIS_ _Out_ */ out bool pbSampleFrequency);
    }
}
