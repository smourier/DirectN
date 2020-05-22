// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(11090,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f5042ea4-7a96-4a75-aa7b-2be1ef7f88d5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFByteStreamCacheControl
    {
        [PreserveSig]
        HRESULT StopBackgroundTransfer();
    }
}
