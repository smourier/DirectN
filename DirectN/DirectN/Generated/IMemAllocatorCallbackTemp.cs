// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(3685,5)
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("379a0cf0-c1de-11d2-abf5-00a0c905f375"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMemAllocatorCallbackTemp : IMemAllocator
    {
        // IMemAllocator
        [PreserveSig]
        new HRESULT SetProperties(/* [annotation][in] _In_ */ ref _AllocatorProperties pRequest, /* [annotation][out] _Out_ */ out _AllocatorProperties pActual);
        
        [PreserveSig]
        new HRESULT GetProperties(/* [annotation][out] _Out_ */ out _AllocatorProperties pProps);
        
        [PreserveSig]
        new HRESULT Commit();
        
        [PreserveSig]
        new HRESULT Decommit();
        
        [PreserveSig]
        new HRESULT GetBuffer(/* [annotation][out] _Out_ */ out IMediaSample ppBuffer, /* optional(REFERENCE_TIME) */ IntPtr pStartTime, /* optional(REFERENCE_TIME) */ IntPtr pEndTime, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        new HRESULT ReleaseBuffer(/* [in] */ IMediaSample pBuffer);
        
        // IMemAllocatorCallbackTemp
        [PreserveSig]
        HRESULT SetNotify(/* [in] */ IMemAllocatorNotifyCallbackTemp pNotify);
        
        [PreserveSig]
        HRESULT GetFreeCount(/* [annotation][out] _Out_ */ out int plBuffersFree);
    }
}
