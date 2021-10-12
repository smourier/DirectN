// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(16292,5)
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
