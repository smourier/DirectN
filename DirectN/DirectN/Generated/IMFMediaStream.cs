// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(2166,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d182108f-4ec6-443f-aa42-a71106ec825f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaStream : IMFMediaEventGenerator
    {
        // IMFMediaEventGenerator
        [PreserveSig]
        new HRESULT GetEvent(/* [in] */ uint dwFlags, /* [out] __RPC__deref_out_opt */ out IMFMediaEvent ppEvent);
        
        [PreserveSig]
        new HRESULT BeginGetEvent(/* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        new HRESULT EndGetEvent(/* [in] */ IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out IMFMediaEvent ppEvent);
        
        [PreserveSig]
        new HRESULT QueueEvent(/* [in] */ uint met, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidExtendedType, /* [in] */ HRESULT hrStatus, /* [unique][in] __RPC__in_opt */ [In, Out] PropVariant pvValue);
        
        // IMFMediaStream
        [PreserveSig]
        HRESULT GetMediaSource(/* [out] __RPC__deref_out_opt */ out IMFMediaSource ppMediaSource);
        
        [PreserveSig]
        HRESULT GetStreamDescriptor(/* [out] __RPC__deref_out_opt */ out IMFStreamDescriptor ppStreamDescriptor);
        
        [PreserveSig]
        HRESULT RequestSample(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pToken);
    }
}
