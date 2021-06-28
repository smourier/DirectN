// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(6114,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1f2a94c9-a3df-430d-9d0f-acd85ddc29af"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimedText
    {
        [PreserveSig]
        HRESULT RegisterNotifications(/* [annotation][in] _In_opt_ */ IMFTimedTextNotify notify);
        
        [PreserveSig]
        HRESULT SelectTrack(/* [annotation][in] _In_ */ uint trackId, /* [annotation][in] _In_ */ bool selected);
        
        [PreserveSig]
        HRESULT AddDataSource(/* [annotation][in] _In_ */ IMFByteStream byteStream, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string label, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string language, /* [annotation][in] _In_ */ MF_TIMED_TEXT_TRACK_KIND kind, /* [annotation][in] _In_ */ bool isDefault, /* [annotation][in] _Out_ */ ref uint trackId);
        
        [PreserveSig]
        HRESULT AddDataSourceFromUrl(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string url, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string label, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string language, /* [annotation][in] _In_ */ MF_TIMED_TEXT_TRACK_KIND kind, /* [annotation][in] _In_ */ bool isDefault, /* [annotation][in] _Out_ */ ref uint trackId);
        
        [PreserveSig]
        HRESULT AddTrack(/* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string label, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string language, /* [annotation][in] _In_ */ MF_TIMED_TEXT_TRACK_KIND kind, /* [annotation][out] _COM_Outptr_ */ out IMFTimedTextTrack track);
        
        [PreserveSig]
        HRESULT RemoveTrack(/* [annotation][in] _In_ */ IMFTimedTextTrack track);
        
        [PreserveSig]
        HRESULT GetCueTimeOffset(/* [annotation][out] _Out_ */ out double offset);
        
        [PreserveSig]
        HRESULT SetCueTimeOffset(/* [annotation][in] _In_ */ double offset);
        
        [PreserveSig]
        HRESULT GetTracks(/* [annotation][out] _COM_Outptr_ */ out IMFTimedTextTrackList tracks);
        
        [PreserveSig]
        HRESULT GetActiveTracks(/* [annotation][out] _COM_Outptr_ */ out IMFTimedTextTrackList activeTracks);
        
        [PreserveSig]
        HRESULT GetTextTracks(/* [annotation][out] _COM_Outptr_ */ out IMFTimedTextTrackList textTracks);
        
        [PreserveSig]
        HRESULT GetMetadataTracks(/* [annotation][out] _COM_Outptr_ */ out IMFTimedTextTrackList metadataTracks);
        
        [PreserveSig]
        HRESULT SetInBandEnabled(/* [annotation][in] _In_ */ bool enabled);
        
        [PreserveSig]
        bool IsInBandEnabled();
    }
}
