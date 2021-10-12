// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(17941,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a73a0072-25a0-4c99-b4a5-ede8101a6c39"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDRMMessageParser
    {
        [PreserveSig]
        HRESULT ParseRegistrationReqMsg(/* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pbRegistrationReqMsg, /* [in] */ uint cbRegistrationReqMsg, /* [out] */ out INSSBuffer ppDeviceCert, /* [out] */ out _DRM_VAL16 pDeviceSerialNumber);
        
        [PreserveSig]
        HRESULT ParseLicenseRequestMsg(/* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pbLicenseRequestMsg, /* [in] */ uint cbLicenseRequestMsg, /* [out] */ out INSSBuffer ppDeviceCert, /* [out] */ out _DRM_VAL16 pDeviceSerialNumber, /* [out] */ out IntPtr pbstrAction);
    }
}
