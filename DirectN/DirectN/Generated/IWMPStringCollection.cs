// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(2673,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4a976298-8c0d-11d3-b389-00c04f68574b"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPStringCollection
    {
        [PreserveSig]
        HRESULT get_count(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT item(/* [in] */ int lIndex, /* [retval][out] */ out IntPtr pbstrString);
    }
}
