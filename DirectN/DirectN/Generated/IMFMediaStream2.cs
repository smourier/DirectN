// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(18373,5)
using System;
using System.Runtime.InteropServices;
using MF_STREAM_STATE = DirectN._MF_STREAM_STATE;

namespace DirectN
{
    [Guid("c5bc37d6-75c7-46a1-a132-81b5f723c20f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaStream2 : IMFMediaStream
    {
        // IMFMediaStream
        [PreserveSig]
        new HRESULT GetMediaSource(/* [out] __RPC__deref_out_opt */ out IMFMediaSource ppMediaSource);
        
        [PreserveSig]
        new HRESULT GetStreamDescriptor(/* [out] __RPC__deref_out_opt */ out IMFStreamDescriptor ppStreamDescriptor);
        
        [PreserveSig]
        new HRESULT RequestSample(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pToken);
        
        // IMFMediaStream2
        [PreserveSig]
        HRESULT SetStreamState(/* [annotation][in] _In_ */ MF_STREAM_STATE value);
        
        [PreserveSig]
        HRESULT GetStreamState(/* [annotation][out] _Out_ */ out MF_STREAM_STATE value);
    }
}
