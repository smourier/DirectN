// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgi.h(2185,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("54ec77fa-1377-44e6-8c32-88fd5f44c84c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGIDevice : IDXGIObject
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
        HRESULT GetAdapter(/* [annotation][out] _COM_Outptr_ */ out IDXGIAdapter pAdapter);
        
        [PreserveSig]
        HRESULT CreateSurface(/* [annotation][in] _In_ */ ref DXGI_SURFACE_DESC pDesc, /* [in] */ uint NumSurfaces, /* [in] */ uint Usage, /* optional(DXGI_SHARED_RESOURCE) */ IntPtr pSharedResource, /* [annotation][out] _COM_Outptr_ */ out IDXGISurface ppSurface);
        
        [PreserveSig]
        HRESULT QueryResourceResidency(/* [annotation][size_is][in] _In_reads_(NumResources) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2, ArraySubType = UnmanagedType.IUnknown)] object[] ppResources, /* [annotation][size_is][out] _Out_writes_(NumResources) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] DXGI_RESIDENCY[] pResidencyStatus, /* [in] */ int NumResources);
        
        [PreserveSig]
        HRESULT SetGPUThreadPriority(/* [in] */ int Priority);
        
        [PreserveSig]
        HRESULT GetGPUThreadPriority(/* [annotation][retval][out] _Out_ */ out int pPriority);
    }
}
