// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(17348,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bddc4d08-944d-4d52-a612-46c3fda07dd4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderAccelerator
    {
        [PreserveSig]
        HRESULT GetCodecInterface(/* [in] */ uint dwOutputNum, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [out] */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvCodecInterface);
        
        [PreserveSig]
        HRESULT Notify(/* [in] */ uint dwOutputNum, /* [in] */ ref _WMMediaType pSubtype);
    }
}
