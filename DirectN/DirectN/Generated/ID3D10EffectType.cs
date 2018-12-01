// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10effect.h(306,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4e9e1ddc-cd9d-4772-a837-00180b9b88fd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10EffectType
    {
        [PreserveSig]
        bool IsValid();
        
        [PreserveSig]
        HRESULT GetDesc(ref _D3D10_EFFECT_TYPE_DESC pDesc);
        
        [PreserveSig]
        ID3D10EffectType GetMemberTypeByIndex(uint Index);
        
        [PreserveSig]
        ID3D10EffectType GetMemberTypeByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        ID3D10EffectType GetMemberTypeBySemantic([MarshalAs(UnmanagedType.LPStr)] string Semantic);
        
        [PreserveSig]
        string GetMemberName(uint Index);
        
        [PreserveSig]
        string GetMemberSemantic(uint Index);
    }
}
