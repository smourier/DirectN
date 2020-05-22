// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(16162,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8e1c39a1-de53-11cf-aa63-0080c744528d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMOpenProgress
    {
        [PreserveSig]
        HRESULT QueryProgress(/* [annotation][out] _Out_ */ out long pllTotal, /* [annotation][out] _Out_ */ out long pllCurrent);
        
        [PreserveSig]
        HRESULT AbortOperation();
    }
}
