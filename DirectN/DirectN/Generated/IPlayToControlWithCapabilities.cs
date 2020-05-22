// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfsharingengine.h(1051,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("aa9dd80f-c50a-4220-91c1-332287f82a34"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
