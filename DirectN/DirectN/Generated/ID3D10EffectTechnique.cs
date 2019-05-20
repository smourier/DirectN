// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10effect.h(1261,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("db122ce8-d1c9-4292-b237-24ed3de8b175"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10EffectTechnique
    {
        [PreserveSig]
        bool IsValid();
        
        [PreserveSig]
        HRESULT GetDesc(ref _D3D10_TECHNIQUE_DESC pDesc);
        
        [PreserveSig]
        ID3D10EffectVariable GetAnnotationByIndex(uint Index);
        
        [PreserveSig]
        ID3D10EffectVariable GetAnnotationByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        ID3D10EffectPass GetPassByIndex(uint Index);
        
        [PreserveSig]
        ID3D10EffectPass GetPassByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        HRESULT ComputeStateBlockMask(/* THIS_ _Out_ */ out _D3D10_STATE_BLOCK_MASK pStateBlockMask);
    }
}
