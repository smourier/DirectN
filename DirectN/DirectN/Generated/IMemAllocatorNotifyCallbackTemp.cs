// generated from <Windows SDK Path>\um\strmif.h
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
