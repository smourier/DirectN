// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmdxva.h(103,5)
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [Guid("28580dda-d98e-48d0-b7ae-69e473a02825"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPlayerTimestampHook
    {
        [PreserveSig]
        HRESULT MapTimestamp(/* [in] */ long rtIn, /* [out] */ out REFERENCE_TIME prtOut);
    }
}
