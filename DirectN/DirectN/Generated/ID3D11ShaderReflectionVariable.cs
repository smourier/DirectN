// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11shader.h(287,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("51f23923-f3e5-4bd1-91cb-606177d8db4c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11ShaderReflectionVariable
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D11_SHADER_VARIABLE_DESC pDesc);
        
        [PreserveSig]
        ID3D11ShaderReflectionType GetType();
        
        [PreserveSig]
        ID3D11ShaderReflectionConstantBuffer GetBuffer();
        
        [PreserveSig]
        uint GetInterfaceSlot(/* THIS_ _In_ */ uint uArrayIndex);
    }
}
