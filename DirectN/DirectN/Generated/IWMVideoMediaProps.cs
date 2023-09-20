// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406bcf-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMVideoMediaProps : IWMMediaProps
    {
        // IWMMediaProps
        [PreserveSig]
        new HRESULT GetType(/* [out] */ out Guid pguidType);
        
        [PreserveSig]
        new HRESULT GetMediaType(/* [out] */ out _WMMediaType pType, /* [out][in] */ ref uint pcbType);
        
        [PreserveSig]
        new HRESULT SetMediaType(/* [in] */ ref _WMMediaType pType);
        
        // IWMVideoMediaProps
        [PreserveSig]
        HRESULT GetMaxKeyFrameSpacing(/* [out] */ out long pllTime);
        
        [PreserveSig]
        HRESULT SetMaxKeyFrameSpacing(/* [in] */ long llTime);
        
        [PreserveSig]
        HRESULT GetQuality(/* [out] */ out uint pdwQuality);
        
        [PreserveSig]
        HRESULT SetQuality(/* [in] */ uint dwQuality);
    }
}
