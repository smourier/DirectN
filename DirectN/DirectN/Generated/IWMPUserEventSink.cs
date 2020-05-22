// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmpservices.h(875,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("cfccfa72-c343-48c3-a2de-b7a4402e39f2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPUserEventSink
    {
        [PreserveSig]
        HRESULT NotifyUserEvent(/* [in] */ int EventCode);
    }
}
