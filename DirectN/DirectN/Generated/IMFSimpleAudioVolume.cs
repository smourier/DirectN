// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("089edf13-cf71-4338-8d13-9e569dbdc319"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSimpleAudioVolume
    {
        [PreserveSig]
        HRESULT SetMasterVolume(/* [in] */ float fLevel);
        
        [PreserveSig]
        HRESULT GetMasterVolume(/* [out] __RPC__out */ out float pfLevel);
        
        [PreserveSig]
        HRESULT SetMute(/* [in] */ int bMute);
        
        [PreserveSig]
        HRESULT GetMute(/* [out] __RPC__out */ out bool pbMute);
    }
}
