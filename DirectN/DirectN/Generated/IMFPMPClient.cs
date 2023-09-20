// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6c4e655d-ead8-4421-b6b9-54dcdbbdf820"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPMPClient
    {
        [PreserveSig]
        HRESULT SetPMPHost(/* [in] */ IMFPMPHost pPMPHost);
    }
}
