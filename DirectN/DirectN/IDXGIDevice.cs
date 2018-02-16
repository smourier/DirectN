using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    // dxgi.h
    [Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIDevice : IDXGIObject
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
        HRESULT GetAdapter(out IDXGIAdapter pAdapter);

        [PreserveSig]
        HRESULT CreateSurface(
            ref DXGI_SURFACE_DESC pDesc,
            int NumSurfaces,
            DXGI_USAGE Usage,
            ref DXGI_SHARED_RESOURCE pSharedResource,
            out IDXGISurface ppSurface);

        [PreserveSig]
        HRESULT QueryResourceResidency(
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown)]
            object[] ppResources,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown, SizeParamIndex = 2)]
            DXGI_RESIDENCY[] pResidencyStatus,
            int NumResources);
        
        [PreserveSig]
        HRESULT SetGPUThreadPriority(int Priority);

        [PreserveSig]
        HRESULT GetGPUThreadPriority(out int pPriority);
    }

    // dxgi.h
    [Guid("77db970f-6276-48ba-ba28-070143b4392c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIDevice1 : IDXGIDevice
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
        HRESULT SetMaximumFrameLatency(int MaxLatency);

        [PreserveSig]
        HRESULT GetMaximumFrameLatency(out int pMaxLatency);
    }

    // dxgi1_2.h
    [Guid("05008617-fbfd-4051-a790-144884b4f6a9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIDevice2 : IDXGIDevice1
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
        HRESULT OfferResources(int NumResources, IDXGIResource[] ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority);

        [PreserveSig]
        HRESULT ReclaimResources(int NumResources, IDXGIResource[] ppResources, out bool pDiscarded);

        [PreserveSig]
        HRESULT EnqueueSetEvent(IntPtr hEvent);
    }

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

    // dxgi1_5.h
    [Guid("95B4F95F-D8DA-4CA4-9EE6-3B76D5968A10"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIDevice4 : IDXGIDevice3
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
        new void Trim();

        // IDXGIDevice4
        [PreserveSig]
        HRESULT OfferResources1(int NumResources, IDXGIResource[] ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority, DXGI_OFFER_RESOURCE_FLAGS Flags);

        [PreserveSig]
        HRESULT ReclaimResources1(int NumResources, IDXGIResource[] ppResources, DXGI_RECLAIM_RESOURCE_RESULTS[] pResults);
    }
}
