// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(9443,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96bf961b-40fe-42f1-ba9d-320238b49700"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFWorkQueueServicesEx : IMFWorkQueueServices
    {
        // IMFWorkQueueServices
        [PreserveSig]
        new HRESULT BeginRegisterTopologyWorkQueuesWithMMCSS(/* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        new HRESULT EndRegisterTopologyWorkQueuesWithMMCSS(/* [in] */ IMFAsyncResult pResult);
        
        [PreserveSig]
        new HRESULT BeginUnregisterTopologyWorkQueuesWithMMCSS(/* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        new HRESULT EndUnregisterTopologyWorkQueuesWithMMCSS(/* [in] */ IMFAsyncResult pResult);
        
        [PreserveSig]
        new HRESULT GetTopologyWorkQueueMMCSSClass(/* [in] */ uint dwTopologyWorkQueueId, /* [size_is][out] __RPC__out_ecount_full(*pcchClass) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszClass, /* [out][in] __RPC__inout */ ref uint pcchClass);
        
        [PreserveSig]
        new HRESULT GetTopologyWorkQueueMMCSSTaskId(/* [in] */ uint dwTopologyWorkQueueId, /* [out] __RPC__out */ out uint pdwTaskId);
        
        [PreserveSig]
        new HRESULT BeginRegisterPlatformWorkQueueWithMMCSS(/* [in] */ uint dwPlatformWorkQueue, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, /* [in] */ uint dwTaskId, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        new HRESULT EndRegisterPlatformWorkQueueWithMMCSS(/* [in] */ IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out uint pdwTaskId);
        
        [PreserveSig]
        new HRESULT BeginUnregisterPlatformWorkQueueWithMMCSS(/* [in] */ uint dwPlatformWorkQueue, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        new HRESULT EndUnregisterPlatformWorkQueueWithMMCSS(/* [in] */ IMFAsyncResult pResult);
        
        [PreserveSig]
        new HRESULT GetPlaftormWorkQueueMMCSSClass(/* [in] */ uint dwPlatformWorkQueueId, /* [size_is][out] __RPC__out_ecount_full(*pcchClass) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszClass, /* [out][in] __RPC__inout */ ref uint pcchClass);
        
        [PreserveSig]
        new HRESULT GetPlatformWorkQueueMMCSSTaskId(/* [in] */ uint dwPlatformWorkQueueId, /* [out] __RPC__out */ out uint pdwTaskId);
        
        // IMFWorkQueueServicesEx
        [PreserveSig]
        HRESULT GetTopologyWorkQueueMMCSSPriority(/* [in] */ uint dwTopologyWorkQueueId, /* [out] __RPC__out */ out int plPriority);
        
        [PreserveSig]
        HRESULT BeginRegisterPlatformWorkQueueWithMMCSSEx(/* [in] */ uint dwPlatformWorkQueue, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, /* [in] */ uint dwTaskId, /* [in] */ int lPriority, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT GetPlatformWorkQueueMMCSSPriority(/* [in] */ uint dwPlatformWorkQueueId, /* [out] __RPC__out */ out int plPriority);
    }
}
