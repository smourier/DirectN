// generated from <Windows SDK Path>\um\mfobjects.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("36f846fc-2256-48b6-b58e-e2b638316581"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEventQueue
    {
        [PreserveSig]
        HRESULT GetEvent(/* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IMFMediaEvent ppEvent);
        
        [PreserveSig]
        HRESULT BeginGetEvent(/* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndGetEvent(/* [in] */ IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out IMFMediaEvent ppEvent);
        
        [PreserveSig]
        HRESULT QueueEvent(/* [in] */ IMFMediaEvent pEvent);
        
        [PreserveSig]
        HRESULT QueueEventParamVar(/* [in] */ uint met, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidExtendedType, /* [in] */ HRESULT hrStatus, /* [unique][in] */ [In, Out] PROPVARIANT pvValue);
        
        [PreserveSig]
        HRESULT QueueEventParamUnk(/* [in] */ uint met, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidExtendedType, /* [in] */ HRESULT hrStatus, /* [unique][in] */ [MarshalAs(UnmanagedType.IUnknown)] object pUnk);
        
        [PreserveSig]
        HRESULT Shutdown();
    }
}
