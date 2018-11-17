using System;
using System.Runtime.InteropServices;

namespace DirectN
{
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
}
