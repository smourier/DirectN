﻿// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7a3bac98-0e76-49fb-8c20-8a86fd98eaf2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineAudioEndpointId
    {
        [PreserveSig]
        HRESULT SetAudioEndpointId(/* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pszEndpointId);
        
        [PreserveSig]
        HRESULT GetAudioEndpointId(/* [annotation][out] _Outptr_ */ out IntPtr ppszEndpointId);
    }
}
