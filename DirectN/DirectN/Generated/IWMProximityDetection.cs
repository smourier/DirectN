// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsdkidl.h(16704,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6a9fd8ee-b651-4bf0-b849-7d4ece79a2b1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMProximityDetection
    {
        [PreserveSig]
        HRESULT StartDetection(/* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pbRegistrationMsg, /* [in] */ uint cbRegistrationMsg, /* [size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] byte[] pbLocalAddress, /* [in] */ uint cbLocalAddress, /* [in] */ uint dwExtraPortsAllowed, /* [out] */ out INSSBuffer ppRegistrationResponseMsg, /* [in] */ IWMStatusCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pvContext);
    }
}
