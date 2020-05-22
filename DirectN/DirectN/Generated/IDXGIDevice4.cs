// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgi1_5.h(907,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("95b4f95f-d8da-4ca4-9ee6-3b76d5968a10"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIDevice4 : IDXGIDevice3
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [in] */ uint DataSize, /* [annotation][in] _In_reads_bytes_(DataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* optional(IUnknown) */ IntPtr pUnknown);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [annotation][out][in] _Inout_ */ ref uint pDataSize, /* [annotation][out] _Out_writes_bytes_(*pDataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT GetParent(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][retval][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);
        
        // IDXGIDevice
        [PreserveSig]
        new HRESULT GetAdapter(/* [annotation][out] _COM_Outptr_ */ out IDXGIAdapter pAdapter);
        
        [PreserveSig]
        new HRESULT CreateSurface(/* [annotation][in] _In_ */ ref DXGI_SURFACE_DESC pDesc, /* [in] */ uint NumSurfaces, /* [in] */ uint Usage, /* optional(DXGI_SHARED_RESOURCE) */ IntPtr pSharedResource, /* [annotation][out] _COM_Outptr_ */ out IDXGISurface ppSurface);
        
        [PreserveSig]
        new HRESULT QueryResourceResidency(/* [annotation][size_is][in] _In_reads_(NumResources) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2, ArraySubType = UnmanagedType.IUnknown)] object[] ppResources, /* [annotation][size_is][out] _Out_writes_(NumResources) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DXGI_RESIDENCY[] pResidencyStatus, /* [in] */ int NumResources);
        
        [PreserveSig]
        new HRESULT SetGPUThreadPriority(/* [in] */ int Priority);
        
        [PreserveSig]
        new HRESULT GetGPUThreadPriority(/* [annotation][retval][out] _Out_ */ out int pPriority);
        
        // IDXGIDevice1
        [PreserveSig]
        new HRESULT SetMaximumFrameLatency(/* [in] */ uint MaxLatency);
        
        [PreserveSig]
        new HRESULT GetMaximumFrameLatency(/* [annotation][out] _Out_ */ out uint pMaxLatency);
        
        // IDXGIDevice2
        [PreserveSig]
        new HRESULT OfferResources(/* [annotation][in] _In_ */ int NumResources, /* [annotation][size_is][in] _In_reads_(NumResources) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IDXGIResource[] ppResources, /* [annotation][in] _In_ */ _DXGI_OFFER_RESOURCE_PRIORITY Priority);
        
        [PreserveSig]
        new HRESULT ReclaimResources(/* [annotation][in] _In_ */ int NumResources, /* [annotation][size_is][in] _In_reads_(NumResources) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IDXGIResource[] ppResources, /* [annotation][size_is][out] _Out_writes_all_opt_(NumResources) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] bool[] pDiscarded);
        
        [PreserveSig]
        new HRESULT EnqueueSetEvent(/* [annotation][in] _In_ */ IntPtr hEvent);
        
        // IDXGIDevice3
        [PreserveSig]
        new void Trim();
        
        // IDXGIDevice4
        [PreserveSig]
        HRESULT OfferResources1(/* [annotation][in] _In_ */ int NumResources, /* [annotation][size_is][in] _In_reads_(NumResources) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IDXGIResource[] ppResources, /* [annotation][in] _In_ */ _DXGI_OFFER_RESOURCE_PRIORITY Priority, /* [annotation][in] _In_ */ uint Flags);
        
        [PreserveSig]
        HRESULT ReclaimResources1(/* [annotation][in] _In_ */ int NumResources, /* [annotation][size_is][in] _In_reads_(NumResources) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IDXGIResource[] ppResources, /* [annotation][size_is][out] _Out_writes_all_(NumResources) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] _DXGI_RECLAIM_RESOURCE_RESULTS[] pResults);
    }
}
