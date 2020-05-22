// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(4392,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6d7cdc70-9888-11d3-8edc-00c04f6109cf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMStatusCallback
    {
        [PreserveSig]
        HRESULT OnStatus(/* [in] */ WMT_STATUS Status, /* [in] */ HRESULT hr, /* [in] */ WMT_ATTR_DATATYPE dwType, /* [in] */ ref byte pValue, /* [in] */ IntPtr pvContext);
    }
}
