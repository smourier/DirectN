// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(11618,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("19a6627b-da9e-47c1-bb23-00b5e668236a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPEvents
    {
        [PreserveSig]
        void OpenStateChange(/* [in] */ int NewState);
        
        [PreserveSig]
        void PlayStateChange(/* [in] */ int NewState);
        
        [PreserveSig]
        void AudioLanguageChange(/* [in] */ int LangID);
        
        [PreserveSig]
        void StatusChange();
        
        [PreserveSig]
        void ScriptCommand(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string scType, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string Param);
        
        [PreserveSig]
        void NewStream();
        
        [PreserveSig]
        void Disconnect(/* [in] */ int Result);
        
        [PreserveSig]
        void Buffering(/* [in] */ short Start);
        
        [PreserveSig]
        void Error();
        
        [PreserveSig]
        void Warning(/* [in] */ int WarningType, /* [in] */ int Param, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string Description);
        
        [PreserveSig]
        void EndOfStream(/* [in] */ int Result);
        
        [PreserveSig]
        void PositionChange(/* [in] */ double oldPosition, /* [in] */ double newPosition);
        
        [PreserveSig]
        void MarkerHit(/* [in] */ int MarkerNum);
        
        [PreserveSig]
        void DurationUnitChange(/* [in] */ int NewDurationUnit);
        
        [PreserveSig]
        void CdromMediaChange(/* [in] */ int CdromNum);
        
        [PreserveSig]
        void PlaylistChange(/* [in] */ ref IDispatch Playlist, /* [in] */ WMPPlaylistChangeEventType change);
        
        [PreserveSig]
        void CurrentPlaylistChange(/* [in] */ WMPPlaylistChangeEventType change);
        
        [PreserveSig]
        void CurrentPlaylistItemAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName);
        
        [PreserveSig]
        void MediaChange(/* [in] */ ref IDispatch Item);
        
        [PreserveSig]
        void CurrentMediaItemAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName);
        
        [PreserveSig]
        void CurrentItemChange(/* [in] */ ref IDispatch pdispMedia);
        
        [PreserveSig]
        void MediaCollectionChange();
        
        [PreserveSig]
        void MediaCollectionAttributeStringAdded(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribVal);
        
        [PreserveSig]
        void MediaCollectionAttributeStringRemoved(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribVal);
        
        [PreserveSig]
        void MediaCollectionAttributeStringChanged(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrOldAttribVal, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrNewAttribVal);
        
        [PreserveSig]
        void PlaylistCollectionChange();
        
        [PreserveSig]
        void PlaylistCollectionPlaylistAdded(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPlaylistName);
        
        [PreserveSig]
        void PlaylistCollectionPlaylistRemoved(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPlaylistName);
        
        [PreserveSig]
        void PlaylistCollectionPlaylistSetAsDeleted(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPlaylistName, /* [in] */ short varfIsDeleted);
        
        [PreserveSig]
        void ModeChange(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string ModeName, /* [in] */ short NewValue);
        
        [PreserveSig]
        void MediaError(/* [in] */ ref IDispatch pMediaObject);
        
        [PreserveSig]
        void OpenPlaylistSwitch(/* [in] */ ref IDispatch pItem);
        
        [PreserveSig]
        void DomainChange(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string strDomain);
        
        [PreserveSig]
        void SwitchedToPlayerApplication();
        
        [PreserveSig]
        void SwitchedToControl();
        
        [PreserveSig]
        void PlayerDockedStateChange();
        
        [PreserveSig]
        void PlayerReconnect();
        
        [PreserveSig]
        void Click(/* [in] */ short nButton, /* [in] */ short nShiftState, /* [in] */ int fX, /* [in] */ int fY);
        
        [PreserveSig]
        void DoubleClick(/* [in] */ short nButton, /* [in] */ short nShiftState, /* [in] */ int fX, /* [in] */ int fY);
        
        [PreserveSig]
        void KeyDown(/* [in] */ short nKeyCode, /* [in] */ short nShiftState);
        
        [PreserveSig]
        void KeyPress(/* [in] */ short nKeyAscii);
        
        [PreserveSig]
        void KeyUp(/* [in] */ short nKeyCode, /* [in] */ short nShiftState);
        
        [PreserveSig]
        void MouseDown(/* [in] */ short nButton, /* [in] */ short nShiftState, /* [in] */ int fX, /* [in] */ int fY);
        
        [PreserveSig]
        void MouseMove(/* [in] */ short nButton, /* [in] */ short nShiftState, /* [in] */ int fX, /* [in] */ int fY);
        
        [PreserveSig]
        void MouseUp(/* [in] */ short nButton, /* [in] */ short nShiftState, /* [in] */ int fX, /* [in] */ int fY);
    }
}
