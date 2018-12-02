// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(6447,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e93dcf6c-4b07-4e1e-8123-aa16ed6eadf5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaTypeHandler
    {
        [PreserveSig]
        HRESULT IsMediaTypeSupported(/* [in] */ ref IMFMediaType pMediaType, /* optional(IMFMediaType) */ out IntPtr ppMediaType);
        
        [PreserveSig]
        HRESULT GetMediaTypeCount(/* [out] __RPC__out */ out uint pdwTypeCount);
        
        [PreserveSig]
        HRESULT GetMediaTypeByIndex(/* [in] */ uint dwIndex, /* [annotation][out] _Outptr_ */ out IntPtr ppType);
        
        [PreserveSig]
        HRESULT SetCurrentMediaType(/* [in] */ ref IMFMediaType pMediaType);
        
        [PreserveSig]
        HRESULT GetCurrentMediaType(/* [annotation][out] _Outptr_ */ out IntPtr ppMediaType);
        
        [PreserveSig]
        HRESULT GetMajorType(/* [out] __RPC__out */ out Guid pguidMajorType);
    }
}
