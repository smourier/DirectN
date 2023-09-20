// generated from <Windows SDK Path>\um\audioclient.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c789d381-a28c-4168-b28f-d3a837924dc3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioClientDuckingControl
    {
        [PreserveSig]
        HRESULT SetDuckingOptionsForCurrentStream(/* [in] */ AUDIO_DUCKING_OPTIONS options);
    }
}
