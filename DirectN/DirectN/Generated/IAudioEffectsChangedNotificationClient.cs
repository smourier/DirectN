// generated from <Windows SDK Path>\um\audioclient.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a5ded44f-3c5d-4b2b-bd1e-5dc1ee20bbf6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEffectsChangedNotificationClient
    {
        [PreserveSig]
        HRESULT OnAudioEffectsChanged();
    }
}
