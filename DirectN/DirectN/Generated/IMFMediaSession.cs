// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(984,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("90377834-21d0-4dee-8214-ba2e3e6c1127"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSession : IMFMediaEventGenerator
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
        
        // IMFMediaSession
        [PreserveSig]
        HRESULT SetTopology(/* [in] */ uint dwSetTopologyFlags, /* [in] __RPC__in_opt */ IMFTopology pTopology);
        
        [PreserveSig]
        HRESULT ClearTopologies();
        
        [PreserveSig]
        HRESULT Start(/* optional(GUID) */ IntPtr pguidTimeFormat, /* [unique][in] __RPC__in_opt */ [In, Out] PropVariant pvarStartPosition);
        
        [PreserveSig]
        HRESULT Pause();
        
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT Close();
        
        [PreserveSig]
        HRESULT Shutdown();
        
        [PreserveSig]
        HRESULT GetClock(/* [out] __RPC__deref_out_opt */ out IMFClock ppClock);
        
        [PreserveSig]
        HRESULT GetSessionCapabilities(/* [out] __RPC__out */ out uint pdwCaps);
        
        [PreserveSig]
        HRESULT GetFullTopology(/* [in] */ uint dwGetFullTopologyFlags, /* [in] */ ulong TopoId, /* [out] __RPC__deref_out_opt */ out IMFTopology ppFullTopology);
    }
}
