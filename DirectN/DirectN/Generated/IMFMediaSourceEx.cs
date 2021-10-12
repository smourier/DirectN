// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(1935,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3c9b2eb9-86d5-4514-a394-f56664f9f0d8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSourceEx : IMFMediaSource
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
        
        // IMFMediaSource
        [PreserveSig]
        new HRESULT GetCharacteristics(/* [out] __RPC__out */ out uint pdwCharacteristics);
        
        [PreserveSig]
        new HRESULT CreatePresentationDescriptor(/* [annotation][out] _Outptr_ */ out IMFPresentationDescriptor ppPresentationDescriptor);
        
        [PreserveSig]
        new HRESULT Start(/* [in] __RPC__in_opt */ IMFPresentationDescriptor pPresentationDescriptor, /* optional(GUID) */ IntPtr pguidTimeFormat, /* [unique][in] __RPC__in_opt */ [In, Out] PropVariant pvarStartPosition);
        
        [PreserveSig]
        new HRESULT Stop();
        
        [PreserveSig]
        new HRESULT Pause();
        
        [PreserveSig]
        new HRESULT Shutdown();
        
        // IMFMediaSourceEx
        [PreserveSig]
        HRESULT GetSourceAttributes(/* [out] __RPC__deref_out_opt */ out IMFAttributes ppAttributes);
        
        [PreserveSig]
        HRESULT GetStreamAttributes(/* [in] */ uint dwStreamIdentifier, /* [out] __RPC__deref_out_opt */ out IMFAttributes ppAttributes);
        
        [PreserveSig]
        HRESULT SetD3DManager(/* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pManager);
    }
}
