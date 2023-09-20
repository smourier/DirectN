// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8822c32d-654e-4233-bf21-d7f2e67d30d4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimedTextTrack
    {
        [PreserveSig]
        uint GetId();
        
        [PreserveSig]
        HRESULT GetLabel(/* [annotation][out] _Outptr_ */ out IntPtr label);
        
        [PreserveSig]
        HRESULT SetLabel(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string label);
        
        [PreserveSig]
        HRESULT GetLanguage(/* [annotation][out] _Outptr_ */ out IntPtr language);
        
        [PreserveSig]
        MF_TIMED_TEXT_TRACK_KIND GetTrackKind();
        
        [PreserveSig]
        bool IsInBand();
        
        [PreserveSig]
        HRESULT GetInBandMetadataTrackDispatchType(/* [annotation][out] _Outptr_ */ out IntPtr dispatchType);
        
        [PreserveSig]
        bool IsActive();
        
        [PreserveSig]
        MF_TIMED_TEXT_ERROR_CODE GetErrorCode();
        
        [PreserveSig]
        HRESULT GetExtendedErrorCode();
        
        [PreserveSig]
        HRESULT GetDataFormat(/* [annotation][out] _Out_ */ out Guid format);
        
        [PreserveSig]
        MF_TIMED_TEXT_TRACK_READY_STATE GetReadyState();
        
        [PreserveSig]
        HRESULT GetCueList(/* [annotation][out] _COM_Outptr_ */ out IMFTimedTextCueList cues);
    }
}
