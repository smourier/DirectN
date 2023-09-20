// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c004f646-be2c-48f3-93a2-a0983eba1108"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPMPClientApp
    {
        [PreserveSig]
        HRESULT SetPMPHost(/* [in] */ IMFPMPHostApp pPMPHost);
    }
}
