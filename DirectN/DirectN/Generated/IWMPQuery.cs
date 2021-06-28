// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmp.h(9924,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a00918f3-a6b0-4bfb-9189-fd834c7bc5a5"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPQuery
    {
        [PreserveSig]
        HRESULT addCondition(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribute, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrOperator, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrValue);
        
        [PreserveSig]
        HRESULT beginNextGroup();
    }
}
