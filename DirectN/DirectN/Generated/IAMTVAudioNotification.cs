// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(12114,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("83ec1c33-23d1-11d1-99e6-00a0c9560266"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMTVAudioNotification
    {
        [PreserveSig]
        HRESULT OnEvent(/* [in] */ tagAMTVAudioEventType Event);
    }
}
