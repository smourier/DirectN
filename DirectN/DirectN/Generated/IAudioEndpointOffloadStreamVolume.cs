﻿// generated from <Windows SDK Path>\um\audioengineendpoint.h
using System;
using System.Runtime.InteropServices;
using HNSTIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("64f1dd49-71ca-4281-8672-3a9eddd1d0b6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEndpointOffloadStreamVolume
    {
        [PreserveSig]
        HRESULT GetVolumeChannelCount(/* [out] */ out uint pu32ChannelCount);
        
        [PreserveSig]
        HRESULT SetChannelVolumes(/* [in] */ uint u32ChannelCount, /* [in] */ ref float pf32Volumes, /* [in] */ AUDIO_CURVE_TYPE u32CurveType, /* [in] */ ref HNSTIME pCurveDuration);
        
        [PreserveSig]
        HRESULT GetChannelVolumes(/* [in] */ uint u32ChannelCount, /* [out] */ out float pf32Volumes);
    }
}
