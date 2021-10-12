// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmp.h(12541,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("19a6627b-da9e-47c1-bb23-00b5e668236a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
        void Buffering(/* [in] */ bool Start);
        
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
        void PlaylistChange(/* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object Playlist, /* [in] */ WMPPlaylistChangeEventType change);
        
        [PreserveSig]
        void CurrentPlaylistChange(/* [in] */ WMPPlaylistChangeEventType change);
        
        [PreserveSig]
        void CurrentPlaylistItemAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName);
        
        [PreserveSig]
        void MediaChange(/* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object Item);
        
        [PreserveSig]
        void CurrentMediaItemAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName);
        
        [PreserveSig]
        void CurrentItemChange(/* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object pdispMedia);
        
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
        void PlaylistCollectionPlaylistSetAsDeleted(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPlaylistName, /* [in] */ bool varfIsDeleted);
        
        [PreserveSig]
        void ModeChange(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string ModeName, /* [in] */ bool NewValue);
        
        [PreserveSig]
        void MediaError(/* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object pMediaObject);
        
        [PreserveSig]
        void OpenPlaylistSwitch(/* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object pItem);
        
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
