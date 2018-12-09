// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(17172,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b1a887b2-a4f0-407a-b02e-efbd23bbecdf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDRMTranscryptionManager
    {
        [PreserveSig]
        HRESULT CreateTranscryptor(/* [out] */ out IWMDRMTranscryptor ppTranscryptor);
    }
}
