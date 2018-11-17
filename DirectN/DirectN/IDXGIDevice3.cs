using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    // dxgi1_3.h
    [Guid("6007896c-3244-4afd-bf18-a6d3beda5023"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIDevice3 : IDXGIDevice2
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, int DataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT SetPrivateDataInterface([MarshalAs(UnmanagedType.LPStruct)] Guid Name, [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);

        [PreserveSig]
        new HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid Name, out int pDataSize, IntPtr pData);

        [PreserveSig]
        new HRESULT GetParent([MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);

        // IDXGIDevice
        [PreserveSig]
        new HRESULT GetAdapter(out IDXGIAdapter pAdapter);

        [PreserveSig]
        new HRESULT CreateSurface(
            ref DXGI_SURFACE_DESC pDesc,
            int NumSurfaces,
            DXGI_USAGE Usage,
            ref DXGI_SHARED_RESOURCE pSharedResource,
            out IDXGISurface ppSurface);

        [PreserveSig]
        new HRESULT QueryResourceResidency(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown)]
            object[] ppResources,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown, SizeParamIndex = 2)]
            DXGI_RESIDENCY[] pResidencyStatus,
            int NumResources);

        [PreserveSig]
        new HRESULT SetGPUThreadPriority(int Priority);

        [PreserveSig]
        new HRESULT GetGPUThreadPriority(out int pPriority);

        // IDXGIDevice1
        [PreserveSig]
        new HRESULT SetMaximumFrameLatency(int MaxLatency);

        [PreserveSig]
        new HRESULT GetMaximumFrameLatency(out int pMaxLatency);

        // IDXGIDevice2
        [PreserveSig]
        new HRESULT OfferResources(int NumResources, IDXGIResource[] ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority);

        [PreserveSig]
        new HRESULT ReclaimResources(int NumResources, IDXGIResource[] ppResources, out bool pDiscarded);

        [PreserveSig]
        new HRESULT EnqueueSetEvent(IntPtr hEvent);

        // IDXGIDevice3
        [PreserveSig]
        void Trim();
    }
}
