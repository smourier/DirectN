// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(16334,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f6211f03-8d21-4e94-93e6-8510805f2d99"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDeviceRegistration
    {
        [PreserveSig]
        HRESULT RegisterDevice(/* [in] */ uint dwRegisterType, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pbCertificate, /* [in] */ uint cbCertificate, /* [in] */ _DRM_VAL16 SerialNumber, /* [out] */ out IWMRegisteredDevice ppDevice);
        
        [PreserveSig]
        HRESULT UnregisterDevice(/* [in] */ uint dwRegisterType, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pbCertificate, /* [in] */ uint cbCertificate, /* [in] */ _DRM_VAL16 SerialNumber);
        
        [PreserveSig]
        HRESULT GetRegistrationStats(/* [in] */ uint dwRegisterType, /* [out] */ out uint pcRegisteredDevices);
        
        [PreserveSig]
        HRESULT GetFirstRegisteredDevice(/* [in] */ uint dwRegisterType, /* [out] */ out IWMRegisteredDevice ppDevice);
        
        [PreserveSig]
        HRESULT GetNextRegisteredDevice(/* [out] */ out IWMRegisteredDevice ppDevice);
        
        [PreserveSig]
        HRESULT GetRegisteredDeviceByID(/* [in] */ uint dwRegisterType, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pbCertificate, /* [in] */ uint cbCertificate, /* [in] */ _DRM_VAL16 SerialNumber, /* [out] */ out IWMRegisteredDevice ppDevice);
    }
}
