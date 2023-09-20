// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("059054b3-027c-494c-a27d-9113291cf87f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceOpenMonitor
    {
        [PreserveSig]
        HRESULT OnSourceEvent(/* [in] __RPC__in_opt */ IMFMediaEvent pEvent);
    }
}
