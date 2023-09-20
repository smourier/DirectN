// generated from <Windows SDK Path>\um\audiopolicy.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("641dd20b-4d41-49cc-aba3-174b9477bb08"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSessionNotification
    {
        [PreserveSig]
        HRESULT OnSessionCreated(/* [in] */ IAudioSessionControl NewSession);
    }
}
