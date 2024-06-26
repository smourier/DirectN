﻿// generated from <Windows SDK Path>\um\d3d11on12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bdb64df4-ea2f-4c70-b861-aaab1258bb5d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11On12Device1 : ID3D11On12Device
    {
        // ID3D11On12Device
        [PreserveSig]
        new HRESULT CreateWrappedResource(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pResource12, /* _In_ */ ref D3D11_RESOURCE_FLAGS pFlags11, D3D12_RESOURCE_STATES InState, D3D12_RESOURCE_STATES OutState, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppResource11);
        
        [PreserveSig]
        new void ReleaseWrappedResources(/* _In_reads_( NumResources ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Resource[] ppResources, int NumResources);
        
        [PreserveSig]
        new void AcquireWrappedResources(/* _In_reads_( NumResources ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Resource[] ppResources, int NumResources);
        
        // ID3D11On12Device1
        [PreserveSig]
        HRESULT GetD3D12Device([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDevice);
    }
}
