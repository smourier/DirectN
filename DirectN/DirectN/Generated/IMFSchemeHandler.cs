// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(12786,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6d4c7b74-52a0-4bb7-b0db-55f29f47a668"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSchemeHandler
    {
        [PreserveSig]
        HRESULT BeginCreateObject(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ uint dwFlags, /* [in] */ ref IPropertyStore pProps, /* [annotation][out] _Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknownCancelCookie, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndCreateObject(/* [in] */ IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out MF_OBJECT_TYPE pObjectType, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        
        [PreserveSig]
        HRESULT CancelObjectCreation(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pIUnknownCancelCookie);
    }
}
