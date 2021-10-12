// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dshowasf.h(130,5)
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
