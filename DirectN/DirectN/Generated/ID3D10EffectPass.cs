// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10effect.h(1217,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5cfbeb89-1a06-46e0-b282-e3f9bfa36a54"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10EffectPass
    {
        [PreserveSig]
        bool IsValid();
        
        [PreserveSig]
        HRESULT GetDesc(ref _D3D10_PASS_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetVertexShaderDesc(ref _D3D10_PASS_SHADER_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetGeometryShaderDesc(ref _D3D10_PASS_SHADER_DESC pDesc);
        
        [PreserveSig]
        HRESULT GetPixelShaderDesc(ref _D3D10_PASS_SHADER_DESC pDesc);
        
        [PreserveSig]
        ID3D10EffectVariable GetAnnotationByIndex(uint Index);
        
        [PreserveSig]
        ID3D10EffectVariable GetAnnotationByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        HRESULT Apply(uint Flags);
        
        [PreserveSig]
        HRESULT ComputeStateBlockMask(/* THIS_ _Out_ */ out _D3D10_STATE_BLOCK_MASK pStateBlockMask);
    }
}
