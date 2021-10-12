// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfobjects.h(4437,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2cd0bd52-bcd5-4b89-b62c-eadc0c031e7d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEventGenerator
    {
        [PreserveSig]
        HRESULT GetEvent(/* [in] */ uint dwFlags, /* [out] __RPC__deref_out_opt */ out IMFMediaEvent ppEvent);
        
        [PreserveSig]
        HRESULT BeginGetEvent(/* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndGetEvent(/* [in] */ IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out IMFMediaEvent ppEvent);
        
        [PreserveSig]
        HRESULT QueueEvent(/* [in] */ uint met, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidExtendedType, /* [in] */ HRESULT hrStatus, /* [unique][in] __RPC__in_opt */ [In, Out] PropVariant pvValue);
    }
}
