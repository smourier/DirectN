// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(13025,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e5b7ca9a-0f1c-4f66-9002-74ec50d8b304"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPlayerHook
    {
        [PreserveSig]
        HRESULT PreDecode();
    }
}
