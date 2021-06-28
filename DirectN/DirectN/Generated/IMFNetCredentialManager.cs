// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(11571,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5b87ef6b-7ed8-434f-ba0e-184fac1628d1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFNetCredentialManager
    {
        [PreserveSig]
        HRESULT BeginGetCredentials(/* [in] */ ref _MFNetCredentialManagerGetParam pParam, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndGetCredentials(/* [in] */ IMFAsyncResult pResult, /* [annotation][out] _Outptr_ */ out IMFNetCredential ppCred);
        
        [PreserveSig]
        HRESULT SetGood(/* [in] */ IMFNetCredential pCred, /* [in] */ bool fGood);
    }
}
