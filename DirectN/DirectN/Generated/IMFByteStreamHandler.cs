// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(12772,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bb420aa4-765b-4a1f-91fe-d6a8a143924c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFByteStreamHandler
    {
        [PreserveSig]
        HRESULT BeginCreateObject(/* [in] */ IMFByteStream pByteStream, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [in] */ uint dwFlags, /* [in] */ IPropertyStore pProps, /* [annotation][out] _Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknownCancelCookie, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndCreateObject(/* [in] */ IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out MF_OBJECT_TYPE pObjectType, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
        
        [PreserveSig]
        HRESULT CancelObjectCreation(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pIUnknownCancelCookie);
        
        [PreserveSig]
        HRESULT GetMaxNumberOfBytesRequiredForResolution(/* [annotation][out] _Out_ */ out ulong pqwBytes);
    }
}
