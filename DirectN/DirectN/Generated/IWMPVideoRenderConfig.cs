// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmprealestate.h(846,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6d6cf803-1ec0-4c8d-b3ca-f18e27282074"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPVideoRenderConfig
    {
        [PreserveSig]
        HRESULT put_presenterActivate(/* [in] */ IMFActivate pActivate);
    }
}
