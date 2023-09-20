// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("20bc074b-7a8d-4609-8c3b-64a0a3b5d7ce"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFDXGIDeviceManagerSource
    {
        [PreserveSig]
        HRESULT GetManager(/* [out] __RPC__deref_out_opt */ out IMFDXGIDeviceManager ppManager);
    }
}
