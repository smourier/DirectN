// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406bd7-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMOutputMediaProps : IWMMediaProps
    {
        // IWMMediaProps
        [PreserveSig]
        new HRESULT GetType(/* [out] */ out Guid pguidType);
        
        [PreserveSig]
        new HRESULT GetMediaType(/* [out] */ out _WMMediaType pType, /* [out][in] */ ref uint pcbType);
        
        [PreserveSig]
        new HRESULT SetMediaType(/* [in] */ ref _WMMediaType pType);
        
        // IWMOutputMediaProps
        [PreserveSig]
        HRESULT GetStreamGroupName(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out][in] */ ref ushort pcchName);
        
        [PreserveSig]
        HRESULT GetConnectionName(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out][in] */ ref ushort pcchName);
    }
}
