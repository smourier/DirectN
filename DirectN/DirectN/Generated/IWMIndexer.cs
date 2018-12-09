// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(15119,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6d7cdc71-9888-11d3-8edc-00c04f6109cf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMIndexer
    {
        [PreserveSig]
        HRESULT StartIndexing(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ IWMStatusCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pvContext);
        
        [PreserveSig]
        HRESULT Cancel();
    }
}
