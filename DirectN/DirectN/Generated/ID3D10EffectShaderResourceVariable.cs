// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10effect.h(668,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c0a7157b-d872-4b1d-8073-efc2acd4b1fc"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10EffectShaderResourceVariable : ID3D10EffectVariable
    {
        // ID3D10EffectVariable
        [PreserveSig]
        new bool IsValid();
        
        [PreserveSig]
        new ID3D10EffectType GetType();
        
        [PreserveSig]
        new HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D10_EFFECT_VARIABLE_DESC pDesc);
        
        [PreserveSig]
        new ID3D10EffectVariable GetAnnotationByIndex(uint Index);
        
        [PreserveSig]
        new ID3D10EffectVariable GetAnnotationByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        new ID3D10EffectVariable GetMemberByIndex(uint Index);
        
        [PreserveSig]
        new ID3D10EffectVariable GetMemberByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        new ID3D10EffectVariable GetMemberBySemantic([MarshalAs(UnmanagedType.LPStr)] string Semantic);
        
        [PreserveSig]
        new ID3D10EffectVariable GetElement(uint Index);
        
        [PreserveSig]
        new ID3D10EffectConstantBuffer GetParentConstantBuffer();
        
        [PreserveSig]
        new ID3D10EffectScalarVariable AsScalar();
        
        [PreserveSig]
        new ID3D10EffectVectorVariable AsVector();
        
        [PreserveSig]
        new ID3D10EffectMatrixVariable AsMatrix();
        
        [PreserveSig]
        new ID3D10EffectStringVariable AsString();
        
        [PreserveSig]
        new ID3D10EffectShaderResourceVariable AsShaderResource();
        
        [PreserveSig]
        new ID3D10EffectRenderTargetViewVariable AsRenderTargetView();
        
        [PreserveSig]
        new ID3D10EffectDepthStencilViewVariable AsDepthStencilView();
        
        [PreserveSig]
        new ID3D10EffectConstantBuffer AsConstantBuffer();
        
        [PreserveSig]
        new ID3D10EffectShaderVariable AsShader();
        
        [PreserveSig]
        new ID3D10EffectBlendVariable AsBlend();
        
        [PreserveSig]
        new ID3D10EffectDepthStencilVariable AsDepthStencil();
        
        [PreserveSig]
        new ID3D10EffectRasterizerVariable AsRasterizer();
        
        [PreserveSig]
        new ID3D10EffectSamplerVariable AsSampler();
        
        [PreserveSig]
        new HRESULT SetRawValue(/* THIS_ _In_reads_bytes_(ByteCount) */ [MarshalAs(UnmanagedType.IUnknown)] object pData, uint Offset, uint ByteCount);
        
        [PreserveSig]
        new HRESULT GetRawValue(/* THIS_ _Out_writes_bytes_(ByteCount) */ IntPtr pData, uint Offset, uint ByteCount);
        
        // ID3D10EffectShaderResourceVariable
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
        HRESULT SetRawValue(/* THIS_ _In_reads_bytes_(ByteCount) */ [MarshalAs(UnmanagedType.IUnknown)] object pData, uint Offset, uint ByteCount);
        
        [PreserveSig]
        HRESULT GetRawValue(/* THIS_ _Out_writes_bytes_(ByteCount) */ IntPtr pData, uint Offset, uint ByteCount);
        
        [PreserveSig]
        HRESULT SetResource(/* THIS_ _In_opt_ */ ID3D10ShaderResourceView pResource);
        
        [PreserveSig]
        HRESULT GetResource(/* THIS_ _Out_ */ out ID3D10ShaderResourceView ppResource);
        
        [PreserveSig]
        HRESULT SetResourceArray(/* THIS_ _In_reads_(Count) */ out IntPtr ppResources, uint Offset, uint Count);
        
        [PreserveSig]
        HRESULT GetResourceArray(/* THIS_ _Out_writes_(Count) */ out IntPtr ppResources, uint Offset, uint Count);
    }
}
