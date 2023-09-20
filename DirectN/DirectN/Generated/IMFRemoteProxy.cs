// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("994e23ad-1cc2-493c-b9fa-46f1cb040fa4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFRemoteProxy
    {
        [PreserveSig]
        HRESULT GetRemoteObject(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT GetRemoteHost(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
    }
}
