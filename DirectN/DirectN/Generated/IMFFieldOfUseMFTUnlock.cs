// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("508e71d3-ec66-4fc3-8775-b4b9ed6ba847"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFFieldOfUseMFTUnlock
    {
        [PreserveSig]
        HRESULT Unlock(/* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkMFT);
    }
}
