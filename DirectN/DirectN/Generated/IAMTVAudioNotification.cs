// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("83ec1c33-23d1-11d1-99e6-00a0c9560266"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMTVAudioNotification
    {
        [PreserveSig]
        HRESULT OnEvent(/* [in] */ tagAMTVAudioEventType Event);
    }
}
