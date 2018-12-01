// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(3526,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("379a0cf0-c1de-11d2-abf5-00a0c905f375"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
        new HRESULT GetBuffer(/* [annotation][out] _Out_ */ out IMediaSample ppBuffer, /* [annotation][unique][in] _In_opt_ */ ref long pStartTime, /* [annotation][unique][in] _In_opt_ */ ref long pEndTime, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        new HRESULT ReleaseBuffer(/* [in] */ IMediaSample pBuffer);
        
        // IMemAllocatorCallbackTemp
        [PreserveSig]
        HRESULT SetNotify(/* [in] */ IMemAllocatorNotifyCallbackTemp pNotify);
        
        [PreserveSig]
        HRESULT GetFreeCount(/* [annotation][out] _Out_ */ out long plBuffersFree);
    }
}
