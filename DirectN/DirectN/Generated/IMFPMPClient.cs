// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(15266,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6c4e655d-ead8-4421-b6b9-54dcdbbdf820"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPMPClient
    {
        [PreserveSig]
        HRESULT SetPMPHost(/* [in] */ IMFPMPHost pPMPHost);
    }
}
