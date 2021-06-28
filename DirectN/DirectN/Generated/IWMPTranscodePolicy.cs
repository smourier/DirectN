// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmpservices.h(786,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b64cbac3-401c-4327-a3e8-b9feb3a8c25c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPTranscodePolicy
    {
        [PreserveSig]
        HRESULT allowTranscode(/* [out] */ out bool pvbAllow);
    }
}
