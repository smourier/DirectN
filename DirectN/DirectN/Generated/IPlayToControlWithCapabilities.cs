// generated from <Windows SDK Path>\um\mfsharingengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("aa9dd80f-c50a-4220-91c1-332287f82a34"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPlayToControlWithCapabilities : IPlayToControl
    {
        // IPlayToControl
        [PreserveSig]
        new HRESULT Connect(/* [in] __RPC__in_opt */ IMFSharingEngineClassFactory pFactory);
        
        [PreserveSig]
        new HRESULT Disconnect();
        
        // IPlayToControlWithCapabilities
        [PreserveSig]
        HRESULT GetCapabilities(/* [out] __RPC__out */ out PLAYTO_SOURCE_CREATEFLAGS pCapabilities);
    }
}
