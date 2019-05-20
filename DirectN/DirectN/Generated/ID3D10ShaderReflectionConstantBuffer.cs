// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10shader.h(319,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("66c66a94-dddd-4b62-a66a-f0da33c2b4d0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10ShaderReflectionConstantBuffer
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D10_SHADER_BUFFER_DESC pDesc);
        
        [PreserveSig]
        ID3D10ShaderReflectionVariable GetVariableByIndex(uint Index);
        
        [PreserveSig]
        ID3D10ShaderReflectionVariable GetVariableByName([MarshalAs(UnmanagedType.LPStr)] string Name);
    }
}
