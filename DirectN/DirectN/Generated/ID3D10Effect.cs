﻿// generated from <Windows SDK Path>\um\d3d10effect.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("51b0ca8b-ec0b-4519-870d-8ee1cb5017c7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10Effect
    {
        [PreserveSig]
        bool IsValid();
        
        [PreserveSig]
        bool IsPool();
        
        [PreserveSig]
        HRESULT GetDevice(/* THIS_ _Out_ */ out ID3D10Device ppDevice);
        
        [PreserveSig]
        HRESULT GetDesc(/* THIS_ _Out_ */ out _D3D10_EFFECT_DESC pDesc);
        
        [PreserveSig]
        ID3D10EffectConstantBuffer GetConstantBufferByIndex(uint Index);
        
        [PreserveSig]
        ID3D10EffectConstantBuffer GetConstantBufferByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        ID3D10EffectVariable GetVariableByIndex(uint Index);
        
        [PreserveSig]
        ID3D10EffectVariable GetVariableByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        ID3D10EffectVariable GetVariableBySemantic([MarshalAs(UnmanagedType.LPStr)] string Semantic);
        
        [PreserveSig]
        ID3D10EffectTechnique GetTechniqueByIndex(uint Index);
        
        [PreserveSig]
        ID3D10EffectTechnique GetTechniqueByName([MarshalAs(UnmanagedType.LPStr)] string Name);
        
        [PreserveSig]
        HRESULT Optimize();
        
        [PreserveSig]
        bool IsOptimized();
    }
}
