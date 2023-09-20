// generated from <Windows SDK Path>\um\audioenginebaseapo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0e5ed805-aba6-49c3-8f9a-2b8c889c4fa8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioProcessingObjectConfiguration
    {
        [PreserveSig]
        HRESULT LockForProcess(/* [annotation][in] _In_ */ uint u32NumInputConnections, /* [annotation][in] _In_ */ ref APO_CONNECTION_DESCRIPTOR ppInputConnections, /* [annotation][in] _In_ */ uint u32NumOutputConnections, /* [annotation][in] _In_ */ ref APO_CONNECTION_DESCRIPTOR ppOutputConnections);
        
        [PreserveSig]
        HRESULT UnlockForProcess();
    }
}
