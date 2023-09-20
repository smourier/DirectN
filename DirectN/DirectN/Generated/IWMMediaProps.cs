// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406bce-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
