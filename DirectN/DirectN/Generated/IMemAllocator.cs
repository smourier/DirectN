// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(3370,5)
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [Guid("56a8689c-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
