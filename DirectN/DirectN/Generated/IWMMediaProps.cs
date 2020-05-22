// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(2219,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("96406bce-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMMediaProps
    {
        [PreserveSig]
        HRESULT GetType(/* [out] */ out Guid pguidType);
        
        [PreserveSig]
        HRESULT GetMediaType(/* [out] */ out _WMMediaType pType, /* [out][in] */ ref uint pcbType);
        
        [PreserveSig]
        HRESULT SetMediaType(/* [in] */ ref _WMMediaType pType);
    }
}
