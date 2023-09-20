// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("35fe1bb8-a3a9-40fe-bbec-eb569c9ccca3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFWorkQueueServices
    {
        [PreserveSig]
        HRESULT BeginRegisterTopologyWorkQueuesWithMMCSS(/* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndRegisterTopologyWorkQueuesWithMMCSS(/* [in] */ IMFAsyncResult pResult);
        
        [PreserveSig]
        HRESULT BeginUnregisterTopologyWorkQueuesWithMMCSS(/* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndUnregisterTopologyWorkQueuesWithMMCSS(/* [in] */ IMFAsyncResult pResult);
        
        [PreserveSig]
        HRESULT GetTopologyWorkQueueMMCSSClass(/* [in] */ uint dwTopologyWorkQueueId, /* [size_is][out] __RPC__out_ecount_full(*pcchClass) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszClass, /* [out][in] __RPC__inout */ ref uint pcchClass);
        
        [PreserveSig]
        HRESULT GetTopologyWorkQueueMMCSSTaskId(/* [in] */ uint dwTopologyWorkQueueId, /* [out] __RPC__out */ out uint pdwTaskId);
        
        [PreserveSig]
        HRESULT BeginRegisterPlatformWorkQueueWithMMCSS(/* [in] */ uint dwPlatformWorkQueue, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, /* [in] */ uint dwTaskId, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndRegisterPlatformWorkQueueWithMMCSS(/* [in] */ IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out uint pdwTaskId);
        
        [PreserveSig]
        HRESULT BeginUnregisterPlatformWorkQueueWithMMCSS(/* [in] */ uint dwPlatformWorkQueue, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndUnregisterPlatformWorkQueueWithMMCSS(/* [in] */ IMFAsyncResult pResult);
        
        [PreserveSig]
        HRESULT GetPlaftormWorkQueueMMCSSClass(/* [in] */ uint dwPlatformWorkQueueId, /* [size_is][out] __RPC__out_ecount_full(*pcchClass) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszClass, /* [out][in] __RPC__inout */ ref uint pcchClass);
        
        [PreserveSig]
        HRESULT GetPlatformWorkQueueMMCSSTaskId(/* [in] */ uint dwPlatformWorkQueueId, /* [out] __RPC__out */ out uint pdwTaskId);
    }
}
