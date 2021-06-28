// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(2992,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ba2743a1-07e0-48ef-84b6-9a2ed023ca6c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineWebSupport
    {
        [PreserveSig]
        bool ShouldDelayTheLoadEvent();
        
        [PreserveSig]
        HRESULT ConnectWebAudio(/* [annotation][in] _In_ */ uint dwSampleRate, /* [annotation][out] _COM_Outptr_ */ out IAudioSourceProvider ppSourceProvider);
        
        [PreserveSig]
        HRESULT DisconnectWebAudio();
    }
}
