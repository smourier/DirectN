// generated from <Windows SDK Path>\um\audiopolicy.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c3b284d4-6d39-4359-b3cf-b56ddb3bb39c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioVolumeDuckNotification
    {
        [PreserveSig]
        HRESULT OnVolumeDuckNotification(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string sessionID, /* [in] */ uint countCommunicationSessions);
        
        [PreserveSig]
        HRESULT OnVolumeUnduckNotification(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string sessionID);
    }
}
