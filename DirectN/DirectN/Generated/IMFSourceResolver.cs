// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(1370,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fbe5a32d-a497-4b61-bb85-97b1a848a6e3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceResolver
    {
        [PreserveSig]
        HRESULT CreateObjectFromURL(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ uint dwFlags, /* [in] */ ref IPropertyStore pProps, /* [annotation][out] _Out_ */ out MF_OBJECT_TYPE pObjectType, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        
        [PreserveSig]
        HRESULT CreateObjectFromByteStream(/* [in] */ IMFByteStream pByteStream, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ uint dwFlags, /* [in] */ ref IPropertyStore pProps, /* [annotation][out] _Out_ */ out MF_OBJECT_TYPE pObjectType, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        
        [PreserveSig]
        HRESULT BeginCreateObjectFromURL(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ uint dwFlags, /* [in] */ ref IPropertyStore pProps, /* [annotation][out] _Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknownCancelCookie, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndCreateObjectFromURL(/* [in] */ IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out MF_OBJECT_TYPE pObjectType, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        
        [PreserveSig]
        HRESULT BeginCreateObjectFromByteStream(/* [in] */ IMFByteStream pByteStream, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ uint dwFlags, /* [in] */ ref IPropertyStore pProps, /* [annotation][out] _Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknownCancelCookie, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndCreateObjectFromByteStream(/* [in] */ IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out MF_OBJECT_TYPE pObjectType, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        
        [PreserveSig]
        HRESULT CancelObjectCreation(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pIUnknownCancelCookie);
    }
}
