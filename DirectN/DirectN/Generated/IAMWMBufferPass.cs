// generated from <Windows SDK Path>\um\dshowasf.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6dd816d7-e740-4123-9e24-2444412644d8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMWMBufferPass
    {
        [PreserveSig]
        HRESULT SetNotify(/* [in] __RPC__in_opt */ IAMWMBufferPassCallback pCallback);
    }
}
