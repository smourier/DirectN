// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(3064,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("96406bd5-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMInputMediaProps : IWMMediaProps
    {
        // IWMMediaProps
        [PreserveSig]
        new HRESULT GetType(/* [out] */ out Guid pguidType);
        
        [PreserveSig]
        new HRESULT GetMediaType(/* [out] */ out _WMMediaType pType, /* [out][in] */ ref uint pcbType);
        
        [PreserveSig]
        new HRESULT SetMediaType(/* [in] */ ref _WMMediaType pType);
        
        // IWMInputMediaProps
        [PreserveSig]
        HRESULT GetConnectionName(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out][in] */ ref ushort pcchName);
        
        [PreserveSig]
        HRESULT GetGroupName(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out][in] */ ref ushort pcchName);
    }
}
