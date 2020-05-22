// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(15044,5)
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [Guid("62ea93ba-ec62-11d2-b770-00c04fb6bd3d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMLatency
    {
        [PreserveSig]
        HRESULT GetLatency(/* [annotation][in] _Out_ */ ref REFERENCE_TIME prtLatency);
    }
}
