// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e9931663-80bf-4c6e-98af-5dcf58747d1f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSaveJob
    {
        [PreserveSig]
        HRESULT BeginSave(/* [in] */ IMFByteStream pStream, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndSave(/* [in] */ IMFAsyncResult pResult);
        
        [PreserveSig]
        HRESULT CancelSave();
        
        [PreserveSig]
        HRESULT GetProgress(/* [annotation][out] _Out_ */ out uint pdwPercentComplete);
    }
}
