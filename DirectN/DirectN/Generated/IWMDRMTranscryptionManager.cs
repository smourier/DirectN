// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(18338,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b1a887b2-a4f0-407a-b02e-efbd23bbecdf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDRMTranscryptionManager
    {
        [PreserveSig]
        HRESULT CreateTranscryptor(/* [out] */ out IWMDRMTranscryptor ppTranscryptor);
    }
}
