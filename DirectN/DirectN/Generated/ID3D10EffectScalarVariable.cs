// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d10effect.h(422,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00e48f7b-d2c8-49e8-a86c-022dee53431f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10EffectScalarVariable : ID3D10EffectVariable
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
        new HRESULT SetRawValue(/* THIS_ _In_reads_bytes_(ByteCount) */ IntPtr pData, uint Offset, uint ByteCount);
        
        [PreserveSig]
        new HRESULT GetRawValue(/* THIS_ _Out_writes_bytes_(ByteCount) */ IntPtr pData, uint Offset, uint ByteCount);
        
        // ID3D10EffectScalarVariable
        [PreserveSig]
        HRESULT SetFloat(float Value);
        
        [PreserveSig]
        HRESULT GetFloat(/* THIS_ _Out_ */ out float pValue);
        
        [PreserveSig]
        HRESULT SetFloatArray(/* THIS_ _In_reads_(Count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] pData, uint Offset, int Count);
        
        [PreserveSig]
        HRESULT GetFloatArray(/* THIS_ _Out_writes_(Count) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] float[] pData, uint Offset, int Count);
        
        [PreserveSig]
        HRESULT SetInt(int Value);
        
        [PreserveSig]
        HRESULT GetInt(/* THIS_ _Out_ */ out int pValue);
        
        [PreserveSig]
        HRESULT SetIntArray(/* THIS_ _In_reads_(Count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] int[] pData, uint Offset, int Count);
        
        [PreserveSig]
        HRESULT GetIntArray(/* THIS_ _Out_writes_(Count) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] int[] pData, uint Offset, int Count);
        
        [PreserveSig]
        HRESULT SetBool(bool Value);
        
        [PreserveSig]
        HRESULT GetBool(/* THIS_ _Out_ */ out bool pValue);
        
        [PreserveSig]
        HRESULT SetBoolArray(/* THIS_ _In_reads_(Count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] bool[] pData, uint Offset, int Count);
        
        [PreserveSig]
        HRESULT GetBoolArray(/* THIS_ _Out_writes_(Count) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] bool[] pData, uint Offset, int Count);
    }
}
