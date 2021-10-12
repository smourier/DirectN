// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioclient.h(1772,5)
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
