// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11on12.h(397,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("dc90f331-4740-43fa-866e-67f12cb58223"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11On12Device2 : ID3D11On12Device1
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
        new HRESULT GetD3D12Device([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDevice);
        
        // ID3D11On12Device2
        [PreserveSig]
        HRESULT UnwrapUnderlyingResource(/* _In_ */ ID3D11Resource pResource11, /* _In_ */ ID3D12CommandQueue pCommandQueue, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource12);
        
        [PreserveSig]
        HRESULT ReturnUnderlyingResource(/* _In_ */ ID3D11Resource pResource11, int NumSync, /* _In_reads_(NumSync) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ulong[] pSignalValues, /* _In_reads_(NumSync) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D12Fence[] ppFences);
    }
}
