// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioclient.h(1878,5)
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
