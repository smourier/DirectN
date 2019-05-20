// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(16960,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4a724bca-ff6a-4c07-8e0d-7a358421cf06"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSignedLibrary
    {
        [PreserveSig]
        HRESULT GetProcedureAddress(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStr)] string name, /* [annotation] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object address);
    }
}
