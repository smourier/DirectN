// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(3669,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("92980b30-c1de-11d2-abf5-00a0c905f375"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMemAllocatorNotifyCallbackTemp
    {
        [PreserveSig]
        HRESULT NotifyRelease();
    }
}
