// generated from <Windows SDK Path>\um\documenttarget.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c560298a-535c-48f9-866a-632540660cb4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPrintDocumentPackageTarget2
    {
        [PreserveSig]
        HRESULT GetIsTargetIppPrinter(/* [out] __RPC__out */ out bool isIppPrinter);
        
        [PreserveSig]
        HRESULT GetTargetIppPrintDevice(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvTarget);
    }
}
