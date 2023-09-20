// generated from <Windows SDK Path>\um\wmpservices.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cfccfa72-c343-48c3-a2de-b7a4402e39f2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPUserEventSink
    {
        [PreserveSig]
        HRESULT NotifyUserEvent(/* [in] */ int EventCode);
    }
}
