// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(15652,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("eaecb74a-9a50-42ce-9541-6a7f57aa4ad7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFFinalizableMediaSink : IMFMediaSink
    {
        // IMFMediaSink
        [PreserveSig]
        new HRESULT GetCharacteristics(/* [out] __RPC__out */ out uint pdwCharacteristics);
        
        [PreserveSig]
        new HRESULT AddStreamSink(/* [in] */ uint dwStreamSinkIdentifier, /* [in] __RPC__in_opt */ IMFMediaType pMediaType, /* [out] __RPC__deref_out_opt */ out IMFStreamSink ppStreamSink);
        
        [PreserveSig]
        new HRESULT RemoveStreamSink(/* [in] */ uint dwStreamSinkIdentifier);
        
        [PreserveSig]
        new HRESULT GetStreamSinkCount(/* [out] __RPC__out */ out uint pcStreamSinkCount);
        
        [PreserveSig]
        new HRESULT GetStreamSinkByIndex(/* [in] */ uint dwIndex, /* [out] __RPC__deref_out_opt */ out IMFStreamSink ppStreamSink);
        
        [PreserveSig]
        new HRESULT GetStreamSinkById(/* [in] */ uint dwStreamSinkIdentifier, /* [out] __RPC__deref_out_opt */ out IMFStreamSink ppStreamSink);
        
        [PreserveSig]
        new HRESULT SetPresentationClock(/* [in] __RPC__in_opt */ IMFPresentationClock pPresentationClock);
        
        [PreserveSig]
        new HRESULT GetPresentationClock(/* [out] __RPC__deref_out_opt */ out IMFPresentationClock ppPresentationClock);
        
        [PreserveSig]
        new HRESULT Shutdown();
        
        // IMFFinalizableMediaSink
        [PreserveSig]
        HRESULT BeginFinalize(/* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndFinalize(/* [in] */ IMFAsyncResult pResult);
    }
}
