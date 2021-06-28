// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(3331,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6816dad3-2b4b-4c8e-8149-874c3483a753"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMIStreamProps
    {
        [PreserveSig]
        HRESULT GetProperty(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_ATTR_DATATYPE pType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref uint pdwSize);
    }
}
