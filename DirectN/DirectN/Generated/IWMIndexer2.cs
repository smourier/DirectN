// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(16256,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b70f1e42-6255-4df0-a6b9-02b212d9e2bb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMIndexer2 : IWMIndexer
    {
        // IWMIndexer
        [PreserveSig]
        new HRESULT StartIndexing(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ IWMStatusCallback pCallback, /* [in] */ IntPtr pvContext);
        
        [PreserveSig]
        new HRESULT Cancel();
        
        // IWMIndexer2
        [PreserveSig]
        HRESULT Configure(/* [in] */ ushort wStreamNum, /* [in] */ tagWMT_INDEXER_TYPE nIndexerType, /* [in] */ IntPtr pvInterval, /* [in] */ IntPtr pvIndexType);
    }
}
