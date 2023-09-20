// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a868a2-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaEventSink
    {
        [PreserveSig]
        HRESULT Notify(/* [in] */ int EventCode, /* [in] */ IntPtr EventParam1, /* [in] */ IntPtr EventParam2);
    }
}
