// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6d7cdc71-9888-11d3-8edc-00c04f6109cf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMIndexer
    {
        [PreserveSig]
        HRESULT StartIndexing(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ IWMStatusCallback pCallback, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT Cancel();
    }
}
