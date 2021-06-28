// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(15494,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("994e23af-1cc2-493c-b9fa-46f1cb040fa4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPMPServer
    {
        [PreserveSig]
        HRESULT LockProcess();
        
        [PreserveSig]
        HRESULT UnlockProcess();
        
        [PreserveSig]
        HRESULT CreateObjectByCLSID(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsid, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
    }
}
