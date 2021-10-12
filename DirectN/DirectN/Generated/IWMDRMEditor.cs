// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(5063,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ff130ebc-a6c3-42a6-b401-c3382c3e08b3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDRMEditor
    {
        [PreserveSig]
        HRESULT GetDRMProperty(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwstrName, /* [out] */ out WMT_ATTR_DATATYPE pdwType, /* [size_is][out] */ [Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref ushort pcbLength);
    }
}
