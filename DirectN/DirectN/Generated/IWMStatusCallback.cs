// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6d7cdc70-9888-11d3-8edc-00c04f6109cf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMStatusCallback
    {
        [PreserveSig]
        HRESULT OnStatus(/* [in] */ WMT_STATUS Status, /* [in] */ HRESULT hr, /* [in] */ WMT_ATTR_DATATYPE dwType, /* [in] */ ref byte pValue, /* [in] */ IntPtr pvContext);
    }
}
