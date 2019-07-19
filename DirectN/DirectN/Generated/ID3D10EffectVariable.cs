// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10effect.h(373,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ae897105-00e6-45bf-bb8e-281dd6db8e1b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10EffectVariable
    {
        [PreserveSig]
        bool IsValid();
        
        [PreserveSig]
        ID3D10EffectType GetType();
        
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D10_EFFECT_VARIABLE_DESC pDesc);
        
        [PreserveSig]
        ID3D10EffectVariable GetAnnotationByIndex(uint Index);
        
        [PreserveSig]
        ID3D10EffectVariable GetAnnotationByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        ID3D10EffectVariable GetMemberByIndex(uint Index);
        
        [PreserveSig]
        ID3D10EffectVariable GetMemberByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        ID3D10EffectVariable GetMemberBySemantic([MarshalAs(UnmanagedType.LPStr)] string Semantic);
        
        [PreserveSig]
        ID3D10EffectVariable GetElement(uint Index);
        
        [PreserveSig]
        ID3D10EffectConstantBuffer GetParentConstantBuffer();
        
        [PreserveSig]
        ID3D10EffectScalarVariable AsScalar();
        
        [PreserveSig]
        ID3D10EffectVectorVariable AsVector();
        
        [PreserveSig]
        ID3D10EffectMatrixVariable AsMatrix();
        
        [PreserveSig]
        ID3D10EffectStringVariable AsString();
        
        [PreserveSig]
        ID3D10EffectShaderResourceVariable AsShaderResource();
        
        [PreserveSig]
        ID3D10EffectRenderTargetViewVariable AsRenderTargetView();
        
        [PreserveSig]
        ID3D10EffectDepthStencilViewVariable AsDepthStencilView();
        
        [PreserveSig]
        ID3D10EffectConstantBuffer AsConstantBuffer();
        
        [PreserveSig]
        ID3D10EffectShaderVariable AsShader();
        
        [PreserveSig]
        ID3D10EffectBlendVariable AsBlend();
        
        [PreserveSig]
        ID3D10EffectDepthStencilVariable AsDepthStencil();
        
        [PreserveSig]
        ID3D10EffectRasterizerVariable AsRasterizer();
        
        [PreserveSig]
        ID3D10EffectSamplerVariable AsSampler();
        
        [PreserveSig]
        HRESULT SetRawValue(/* THIS_ _In_reads_bytes_(ByteCount) */ IntPtr pData, uint Offset, uint ByteCount);
        
        [PreserveSig]
        HRESULT GetRawValue(/* THIS_ _Out_writes_bytes_(ByteCount) */ IntPtr pData, uint Offset, uint ByteCount);
    }
}
