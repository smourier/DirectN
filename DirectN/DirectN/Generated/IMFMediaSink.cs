// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(2451,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6ef2a660-47c0-4666-b13d-cbb717f2fa2c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSink
    {
        [PreserveSig]
        HRESULT GetCharacteristics(/* [out] __RPC__out */ out uint pdwCharacteristics);
        
        [PreserveSig]
        HRESULT AddStreamSink(/* [in] */ uint dwStreamSinkIdentifier, /* [in] __RPC__in_opt */ IMFMediaType pMediaType, /* [out] __RPC__deref_out_opt */ out IMFStreamSink ppStreamSink);
        
        [PreserveSig]
        HRESULT RemoveStreamSink(/* [in] */ uint dwStreamSinkIdentifier);
        
        [PreserveSig]
        HRESULT GetStreamSinkCount(/* [out] __RPC__out */ out uint pcStreamSinkCount);
        
        [PreserveSig]
        HRESULT GetStreamSinkByIndex(/* [in] */ uint dwIndex, /* [out] __RPC__deref_out_opt */ out IMFStreamSink ppStreamSink);
        
        [PreserveSig]
        HRESULT GetStreamSinkById(/* [in] */ uint dwStreamSinkIdentifier, /* [out] __RPC__deref_out_opt */ out IMFStreamSink ppStreamSink);
        
        [PreserveSig]
        HRESULT SetPresentationClock(/* [in] __RPC__in_opt */ IMFPresentationClock pPresentationClock);
        
        [PreserveSig]
        HRESULT GetPresentationClock(/* [out] __RPC__deref_out_opt */ out IMFPresentationClock ppPresentationClock);
        
        [PreserveSig]
        HRESULT Shutdown();
    }
}
