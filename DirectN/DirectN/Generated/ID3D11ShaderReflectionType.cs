// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11shader.h(262,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6e6ffa6a-9bae-4613-a51e-91652d508c21"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11ShaderReflectionType
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D11_SHADER_TYPE_DESC pDesc);
        
        [PreserveSig]
        ID3D11ShaderReflectionType GetMemberTypeByIndex(/* THIS_ _In_ */ uint Index);
        
        [PreserveSig]
        ID3D11ShaderReflectionType GetMemberTypeByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        string GetMemberTypeName(/* THIS_ _In_ */ uint Index);
        
        [PreserveSig]
        HRESULT IsEqual(/* THIS_ _In_ */ ID3D11ShaderReflectionType pType);
        
        [PreserveSig]
        ID3D11ShaderReflectionType GetSubType();
        
        [PreserveSig]
        ID3D11ShaderReflectionType GetBaseClass();
        
        [PreserveSig]
        uint GetNumInterfaces();
        
        [PreserveSig]
        ID3D11ShaderReflectionType GetInterfaceByIndex(/* THIS_ _In_ */ uint uIndex);
        
        [PreserveSig]
        HRESULT IsOfType(/* THIS_ _In_ */ ID3D11ShaderReflectionType pType);
        
        [PreserveSig]
        HRESULT ImplementsInterface(/* THIS_ _In_ */ ID3D11ShaderReflectionType pBase);
    }
}
