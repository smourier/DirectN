// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(2115,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d182108f-4ec6-443f-aa42-a71106ec825f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaStream
    {
        [PreserveSig]
        HRESULT GetMediaSource(/* [out] __RPC__deref_out_opt */ out IMFMediaSource ppMediaSource);
        
        [PreserveSig]
        HRESULT GetStreamDescriptor(/* [out] __RPC__deref_out_opt */ out IMFStreamDescriptor ppStreamDescriptor);
        
        [PreserveSig]
        HRESULT RequestSample(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pToken);
    }
}
