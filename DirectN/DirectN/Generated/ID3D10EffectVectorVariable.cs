// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10effect.h(489,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("62b98c44-1f82-4c67-bcd0-72cf8f217e81"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10EffectVectorVariable : ID3D10EffectVariable
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
        
        // ID3D10EffectVectorVariable
        [PreserveSig]
        HRESULT SetBoolVector(ref bool pData);
        
        [PreserveSig]
        HRESULT SetIntVector(ref int pData);
        
        [PreserveSig]
        HRESULT SetFloatVector(ref float pData);
        
        [PreserveSig]
        HRESULT GetBoolVector(ref bool pData);
        
        [PreserveSig]
        HRESULT GetIntVector(ref int pData);
        
        [PreserveSig]
        HRESULT GetFloatVector(ref float pData);
        
        [PreserveSig]
        HRESULT SetBoolVectorArray(ref bool pData, uint Offset, uint Count);
        
        [PreserveSig]
        HRESULT SetIntVectorArray(ref int pData, uint Offset, uint Count);
        
        [PreserveSig]
        HRESULT SetFloatVectorArray(ref float pData, uint Offset, uint Count);
        
        [PreserveSig]
        HRESULT GetBoolVectorArray(ref bool pData, uint Offset, uint Count);
        
        [PreserveSig]
        HRESULT GetIntVectorArray(ref int pData, uint Offset, uint Count);
        
        [PreserveSig]
        HRESULT GetFloatVectorArray(ref float pData, uint Offset, uint Count);
    }
}
