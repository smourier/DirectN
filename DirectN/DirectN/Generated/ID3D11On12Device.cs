// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11on12.h(174,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("85611e73-70a9-490e-9614-a9e302777904"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11On12Device
    {
        [PreserveSig]
        HRESULT CreateWrappedResource(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pResource12, /* _In_ */ ref D3D11_RESOURCE_FLAGS pFlags11, D3D12_RESOURCE_STATES InState, D3D12_RESOURCE_STATES OutState, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppResource11);
        
        [PreserveSig]
        void ReleaseWrappedResources(/* _In_reads_( NumResources ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Resource[] ppResources, int NumResources);
        
        [PreserveSig]
        void AcquireWrappedResources(/* _In_reads_( NumResources ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Resource[] ppResources, int NumResources);
    }
}
