// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\audioenginebaseapo.h(459,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0e5ed805-aba6-49c3-8f9a-2b8c889c4fa8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioProcessingObjectConfiguration
    {
        [PreserveSig]
        HRESULT LockForProcess(/* [annotation][in] _In_ */ uint u32NumInputConnections, /* [annotation][in] _In_ */ ref APO_CONNECTION_DESCRIPTOR ppInputConnections, /* [annotation][in] _In_ */ uint u32NumOutputConnections, /* [annotation][in] _In_ */ ref APO_CONNECTION_DESCRIPTOR ppOutputConnections);
        
        [PreserveSig]
        HRESULT UnlockForProcess();
    }
}
