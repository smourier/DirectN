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
}
