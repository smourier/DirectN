// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(1273,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fbe5a32d-a497-4b61-bb85-97b1a848a6e3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceResolver
    {
        [PreserveSig]
        HRESULT CreateObjectFromURL(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ uint dwFlags, /* [in] */ ref IPropertyStore pProps, /* [annotation][out] _Out_ */ out MF_OBJECT_TYPE pObjectType, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        
        [PreserveSig]
        HRESULT CreateObjectFromByteStream(/* [in] */ ref IMFByteStream pByteStream, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ uint dwFlags, /* [in] */ ref IPropertyStore pProps, /* [annotation][out] _Out_ */ out MF_OBJECT_TYPE pObjectType, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        
        [PreserveSig]
        HRESULT BeginCreateObjectFromURL(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ uint dwFlags, /* [in] */ ref IPropertyStore pProps, /* [annotation][out] _Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknownCancelCookie, /* [in] */ ref IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndCreateObjectFromURL(/* [in] */ ref IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out MF_OBJECT_TYPE pObjectType, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        
        [PreserveSig]
        HRESULT BeginCreateObjectFromByteStream(/* [in] */ ref IMFByteStream pByteStream, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ uint dwFlags, /* [in] */ ref IPropertyStore pProps, /* [annotation][out] _Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknownCancelCookie, /* [in] */ ref IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndCreateObjectFromByteStream(/* [in] */ ref IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out MF_OBJECT_TYPE pObjectType, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        
        [PreserveSig]
        HRESULT CancelObjectCreation(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pIUnknownCancelCookie);
    }
}
