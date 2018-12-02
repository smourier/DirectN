// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(2556,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("2f69d622-20b5-41e9-afdf-89ced1dda04e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineExtension
    {
        [PreserveSig]
        HRESULT CanPlayType(/* [annotation][in] _In_ */ bool AudioOnly, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.BStr)] string MimeType, /* [annotation][out] _Out_ */ out MF_MEDIA_ENGINE_CANPLAY pAnswer);
        
        [PreserveSig]
        HRESULT BeginCreateObject(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.BStr)] string bstrURL, /* [annotation][in] _In_opt_ */ IMFByteStream pByteStream, /* [annotation][in] _In_ */ MF_OBJECT_TYPE type, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknownCancelCookie, /* [annotation][in] _In_ */ IMFAsyncCallback pCallback, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT CancelObjectCreation(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pIUnknownCancelCookie);
        
        [PreserveSig]
        HRESULT EndCreateObject(/* [annotation][in] _In_ */ IMFAsyncResult pResult, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppObject);
    }
}
