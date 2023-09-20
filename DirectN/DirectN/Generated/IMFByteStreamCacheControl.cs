// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f5042ea4-7a96-4a75-aa7b-2be1ef7f88d5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFByteStreamCacheControl
    {
        [PreserveSig]
        HRESULT StopBackgroundTransfer();
    }
}
