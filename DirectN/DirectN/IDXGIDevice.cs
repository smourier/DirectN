using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    public interface IDXGIDevice
    {
    }

    public interface IDXGIDevice2 : IDXGIDevice
    {
    }

    public interface IDXGIDevice3 : IDXGIDevice2
    {
    }

    // dxgi1_5.h
    [Guid("95B4F95F-D8DA-4CA4-9EE6-3B76D5968A10"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXGIDevice4 : IDXGIDevice3
    {
        [PreserveSig]
        HRESULT OfferResources1(int NumResources, IDXGIResource[] ppResources, DXGI_OFFER_RESOURCE_PRIORITY Priority, DXGI_OFFER_RESOURCE_FLAGS Flags);

        [PreserveSig]
        HRESULT ReclaimResources1(int NumResources, IDXGIResource[] ppResources, DXGI_RECLAIM_RESOURCE_RESULTS[] pResults);
    }
}
