// generated from <Windows SDK Path>\um\wmsdkidl.h
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
