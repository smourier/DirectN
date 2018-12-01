// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audioenginebaseapo.h(709,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("98f37dac-d0b6-49f5-896a-aa4d169a4c48"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioDeviceModulesClient
    {
        [PreserveSig]
        HRESULT SetAudioDeviceModulesManager(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pAudioDeviceModulesManager);
    }
}
