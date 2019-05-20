// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11shader.h(326,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8d536ca1-0cca-4956-a837-786963755584"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11ShaderReflection
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D11_SHADER_DESC pDesc);
        
        [PreserveSig]
        ID3D11ShaderReflectionConstantBuffer GetConstantBufferByIndex(/* THIS_ _In_ */ uint Index);
        
        [PreserveSig]
        ID3D11ShaderReflectionConstantBuffer GetConstantBufferByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        HRESULT GetResourceBindingDesc(/* THIS_ _In_ */ uint ResourceIndex, /* _Out_ */ out _D3D11_SHADER_INPUT_BIND_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetInputParameterDesc(/* THIS_ _In_ */ uint ParameterIndex, /* _Out_ */ out _D3D11_SIGNATURE_PARAMETER_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetOutputParameterDesc(/* THIS_ _In_ */ uint ParameterIndex, /* _Out_ */ out _D3D11_SIGNATURE_PARAMETER_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetPatchConstantParameterDesc(/* THIS_ _In_ */ uint ParameterIndex, /* _Out_ */ out _D3D11_SIGNATURE_PARAMETER_DESC pDesc);
        
        [PreserveSig]
        ID3D11ShaderReflectionVariable GetVariableByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        HRESULT GetResourceBindingDescByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name, /* _Out_ */ out _D3D11_SHADER_INPUT_BIND_DESC pDesc);
        
        [PreserveSig]
        uint GetMovInstructionCount();
        
        [PreserveSig]
        uint GetMovcInstructionCount();
        
        [PreserveSig]
        uint GetConversionInstructionCount();
        
        [PreserveSig]
        uint GetBitwiseInstructionCount();
        
        [PreserveSig]
        D3D_PRIMITIVE GetGSInputPrimitive();
        
        [PreserveSig]
        bool IsSampleFrequencyShader();
        
        [PreserveSig]
        uint GetNumInterfaceSlots();
        
        [PreserveSig]
        HRESULT GetMinFeatureLevel(/* THIS_ _Out_ */ out D3D_FEATURE_LEVEL pLevel);
        
        [PreserveSig]
        uint GetThreadGroupSize(/* THIS_ _Out_opt_ */ out uint pSizeX, /* _Out_opt_ */ out uint pSizeY, /* _Out_opt_ */ out uint pSizeZ);
        
        [PreserveSig]
        ulong GetRequiresFlags();
    }
}
