// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(18377,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c5bc37d6-75c7-46a1-a132-81b5f723c20f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaStream2 : IMFMediaStream
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
        new HRESULT GetMediaSource(/* [out] __RPC__deref_out_opt */ out IMFMediaSource ppMediaSource);
        
        [PreserveSig]
        new HRESULT GetStreamDescriptor(/* [out] __RPC__deref_out_opt */ out IMFStreamDescriptor ppStreamDescriptor);
        
        [PreserveSig]
        new HRESULT RequestSample(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pToken);
        
        // IMFMediaStream2
        [PreserveSig]
        HRESULT SetStreamState(/* [annotation][in] _In_ */ _MF_STREAM_STATE value);
        
        [PreserveSig]
        HRESULT GetStreamState(/* [annotation][out] _Out_ */ out _MF_STREAM_STATE value);
    }
}
