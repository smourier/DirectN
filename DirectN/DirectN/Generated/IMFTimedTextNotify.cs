﻿// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("df6b87b6-ce12-45db-aba7-432fe054e57d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimedTextNotify
    {
        [PreserveSig]
        void TrackAdded(/* [annotation][in] _In_ */ uint trackId);
        
        [PreserveSig]
        void TrackRemoved(/* [annotation][in] _In_ */ uint trackId);
        
        [PreserveSig]
        void TrackSelected(/* [annotation][in] _In_ */ uint trackId, /* [annotation][in] _In_ */ bool selected);
        
        [PreserveSig]
        void TrackReadyStateChanged(/* [annotation][in] _In_ */ uint trackId);
        
        [PreserveSig]
        void Error(/* [annotation][in] _In_ */ MF_TIMED_TEXT_ERROR_CODE errorCode, /* [annotation][in] _In_ */ HRESULT extendedErrorCode, /* [annotation][in] _In_ */ uint sourceTrackId);
        
        [PreserveSig]
        void Cue(/* [annotation][in] _In_ */ MF_TIMED_TEXT_CUE_EVENT cueEvent, /* [annotation][in] _In_ */ double currentTime, /* [annotation][in] _In_opt_ */ IMFTimedTextCue cue);
        
        [PreserveSig]
        void Reset();
    }
}
