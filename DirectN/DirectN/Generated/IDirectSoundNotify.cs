// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b0210783-89cd-11d0-af08-00a0c925cd16"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSoundNotify
    {
        [PreserveSig]
        HRESULT SetNotificationPositions(int dwPositionNotifies, /* _In_reads_(dwPositionNotifies) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] _DSBPOSITIONNOTIFY[] pcPositionNotifies);
    }
}
