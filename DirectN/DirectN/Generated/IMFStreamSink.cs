// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(2647,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0a97b3cf-8e7c-4a3d-8f8c-0c843dc247fb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFStreamSink : IMFMediaEventGenerator
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
        
        // IMFStreamSink
        [PreserveSig]
        HRESULT GetMediaSink(/* [out] __RPC__deref_out_opt */ out IMFMediaSink ppMediaSink);
        
        [PreserveSig]
        HRESULT GetIdentifier(/* [out] __RPC__out */ out uint pdwIdentifier);
        
        [PreserveSig]
        HRESULT GetMediaTypeHandler(/* [out] __RPC__deref_out_opt */ out IMFMediaTypeHandler ppHandler);
        
        [PreserveSig]
        HRESULT ProcessSample(/* [in] __RPC__in_opt */ IMFSample pSample);
        
        [PreserveSig]
        HRESULT PlaceMarker(/* [in] */ _MFSTREAMSINK_MARKER_TYPE eMarkerType, /* [in] __RPC__in */ [In, Out] PropVariant pvarMarkerValue, /* [in] __RPC__in */ [In, Out] PropVariant pvarContextValue);
        
        [PreserveSig]
        HRESULT Flush();
    }
}
