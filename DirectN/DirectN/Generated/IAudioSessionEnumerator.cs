// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\audiopolicy.h(997,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e2f5bb11-0570-40ca-acdd-3aa01277dee8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSessionEnumerator
    {
        [PreserveSig]
        HRESULT GetCount(/* [out] */ out int SessionCount);
        
        [PreserveSig]
        HRESULT GetSession(/* [in] */ int SessionCount, /* [out] */ out IAudioSessionControl Session);
    }
}
