﻿// generated from <Windows SDK Path>\um\audioclient.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("87ce5498-68d6-44e5-9215-6da47ef883d8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISimpleAudioVolume
    {
        [PreserveSig]
        HRESULT SetMasterVolume(/* [annotation][in] _In_ */ float fLevel, /* [unique][in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);
        
        [PreserveSig]
        HRESULT GetMasterVolume(/* [annotation][out] _Out_ */ out float pfLevel);
        
        [PreserveSig]
        HRESULT SetMute(/* [annotation][in] _In_ */ int bMute, /* [unique][in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);
        
        [PreserveSig]
        HRESULT GetMute(/* [annotation][out] _Out_ */ out bool pbMute);
    }
}
