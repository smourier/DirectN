// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(17558,5)
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
