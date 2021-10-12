// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audiopolicy.h(974,5)
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
