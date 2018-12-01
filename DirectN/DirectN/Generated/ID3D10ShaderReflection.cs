// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10shader.h(338,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d40e20b6-f8f7-42ad-ab20-4baf8f15dfaa"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10ShaderReflection
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
    }
}
