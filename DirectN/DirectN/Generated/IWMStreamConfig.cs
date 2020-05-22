// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(6927,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("96406bdc-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMStreamConfig
    {
        [PreserveSig]
        HRESULT GetStreamType(/* [out] */ out Guid pguidStreamType);
        
        [PreserveSig]
        HRESULT GetStreamNumber(/* [out] */ out ushort pwStreamNum);
        
        [PreserveSig]
        HRESULT SetStreamNumber(/* [in] */ ushort wStreamNum);
        
        [PreserveSig]
        HRESULT GetStreamName(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszStreamName, /* [out][in] */ ref ushort pcchStreamName);
        
        [PreserveSig]
        HRESULT SetStreamName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszStreamName);
        
        [PreserveSig]
        HRESULT GetConnectionName(/* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszInputName, /* [out][in] */ ref ushort pcchInputName);
        
        [PreserveSig]
        HRESULT SetConnectionName(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszInputName);
        
        [PreserveSig]
        HRESULT GetBitrate(/* [out] */ out uint pdwBitrate);
        
        [PreserveSig]
        HRESULT SetBitrate(/* [in] */ uint pdwBitrate);
        
        [PreserveSig]
        HRESULT GetBufferWindow(/* [out] */ out uint pmsBufferWindow);
        
        [PreserveSig]
        HRESULT SetBufferWindow(/* [in] */ uint msBufferWindow);
    }
}
