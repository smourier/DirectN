// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11shader.h(305,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("eb62d63d-93dd-4318-8ae8-c6f83ad371b8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11ShaderReflectionConstantBuffer
    {
        [PreserveSig]
        HRESULT GetDesc(ref _D3D11_SHADER_BUFFER_DESC pDesc);
        
        [PreserveSig]
        ID3D11ShaderReflectionVariable GetVariableByIndex(/* THIS_ _In_ */ uint Index);
        
        [PreserveSig]
        ID3D11ShaderReflectionVariable GetVariableByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name);
    }
}
