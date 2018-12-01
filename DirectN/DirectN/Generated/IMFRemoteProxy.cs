// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(14927,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("994e23ad-1cc2-493c-b9fa-46f1cb040fa4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFRemoteProxy
    {
        [PreserveSig]
        HRESULT GetRemoteObject(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT GetRemoteHost(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
    }
}
