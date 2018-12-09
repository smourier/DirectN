// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmcodecdsp.h(1863,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2573e11a-f01a-4fdd-a98d-63b8e0ba9589"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMCodecProps
    {
        [PreserveSig]
        HRESULT GetFormatProp(/* [in] */ ref _DMOMediaType pmt, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_PROP_DATATYPE pType, /* [size_is][unique][out][in] */ [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref uint pdwSize);
        
        [PreserveSig]
        HRESULT GetCodecProp(/* [in] */ uint dwFormat, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] */ out WMT_PROP_DATATYPE pType, /* [size_is][unique][out][in] */ [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[] pValue, /* [out][in] */ ref uint pdwSize);
    }
}
