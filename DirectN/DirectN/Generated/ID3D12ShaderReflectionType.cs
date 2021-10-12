// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12shader.h(284,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e913c351-783d-48ca-a1d1-4f306284ad56"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12ShaderReflectionType
    {
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D12_SHADER_TYPE_DESC pDesc);
        
        [PreserveSig]
        ID3D12ShaderReflectionType GetMemberTypeByIndex(/* THIS_ _In_ */ uint Index);
        
        [PreserveSig]
        ID3D12ShaderReflectionType GetMemberTypeByName(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        string GetMemberTypeName(/* THIS_ _In_ */ uint Index);
        
        [PreserveSig]
        HRESULT IsEqual(/* THIS_ _In_ */ ID3D12ShaderReflectionType pType);
        
        [PreserveSig]
        ID3D12ShaderReflectionType GetSubType();
        
        [PreserveSig]
        ID3D12ShaderReflectionType GetBaseClass();
        
        [PreserveSig]
        uint GetNumInterfaces();
        
        [PreserveSig]
        ID3D12ShaderReflectionType GetInterfaceByIndex(/* THIS_ _In_ */ uint uIndex);
        
        [PreserveSig]
        HRESULT IsOfType(/* THIS_ _In_ */ ID3D12ShaderReflectionType pType);
        
        [PreserveSig]
        HRESULT ImplementsInterface(/* THIS_ _In_ */ ID3D12ShaderReflectionType pBase);
    }
}
