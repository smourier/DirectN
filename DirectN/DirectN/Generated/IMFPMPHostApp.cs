// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("84d2054a-3aa1-4728-a3b0-440a418cf49c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPMPHostApp
    {
        [PreserveSig]
        HRESULT LockProcess();
        
        [PreserveSig]
        HRESULT UnlockProcess();
        
        [PreserveSig]
        HRESULT ActivateClassById(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string id, /* [unique][in] __RPC__in_opt */ IStream pStream, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
    }
}
