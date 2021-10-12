// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfobjects.h(3543,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ac6b7889-0740-4d51-8619-905994a55cc6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFAsyncResult
    {
        [PreserveSig]
        HRESULT GetState(/* [out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppunkState);
        
        [PreserveSig]
        HRESULT GetStatus();
        
        [PreserveSig]
        HRESULT SetStatus(/* [in] */ HRESULT hrStatus);
        
        [PreserveSig]
        HRESULT GetObjectW(/* [out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        
        [PreserveSig]
        object GetStateNoAddRef();
    }
}
