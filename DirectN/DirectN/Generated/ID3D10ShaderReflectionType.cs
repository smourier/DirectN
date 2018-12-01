// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10shader.h(281,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c530ad7d-9b16-4395-a979-ba2ecff83add"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10ShaderReflectionType
    {
        [PreserveSig]
        HRESULT GetDesc(ref _D3D10_SHADER_TYPE_DESC pDesc);
        
        [PreserveSig]
        ID3D10ShaderReflectionType GetMemberTypeByIndex(uint Index);
        
        [PreserveSig]
        ID3D10ShaderReflectionType GetMemberTypeByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        string GetMemberTypeName(uint Index);
    }
}
