// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmcodecdsp.h(2351,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9bca9884-0604-4c2a-87da-793ff4d586c3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMSampleExtensionSupport
    {
        [PreserveSig]
        HRESULT SetUseSampleExtensions(bool fUseExtensions);
    }
}
