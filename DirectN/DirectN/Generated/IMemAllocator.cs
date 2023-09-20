// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("56a8689c-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMemAllocator
    {
        [PreserveSig]
        HRESULT SetProperties(/* [annotation][in] _In_ */ ref _AllocatorProperties pRequest, /* [annotation][out] _Out_ */ out _AllocatorProperties pActual);
        
        [PreserveSig]
        HRESULT GetProperties(/* [annotation][out] _Out_ */ out _AllocatorProperties pProps);
        
        [PreserveSig]
        HRESULT Commit();
        
        [PreserveSig]
        HRESULT Decommit();
        
        [PreserveSig]
        HRESULT GetBuffer(/* [annotation][out] _Out_ */ out IMediaSample ppBuffer, /* optional(REFERENCE_TIME) */ IntPtr pStartTime, /* optional(REFERENCE_TIME) */ IntPtr pEndTime, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT ReleaseBuffer(/* [in] */ IMediaSample pBuffer);
    }
}
