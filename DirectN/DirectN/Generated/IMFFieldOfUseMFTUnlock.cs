// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(16071,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("508e71d3-ec66-4fc3-8775-b4b9ed6ba847"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFFieldOfUseMFTUnlock
    {
        [PreserveSig]
        HRESULT Unlock(/* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkMFT);
    }
}
