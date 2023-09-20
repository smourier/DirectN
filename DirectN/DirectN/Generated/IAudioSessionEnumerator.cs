// generated from <Windows SDK Path>\um\audiopolicy.h
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
