// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmp.h(12176,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1e7601fa-47ea-4107-9ea9-9004ed9684ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPEvents2 : IWMPEvents
    {
        // IWMPEvents
        [PreserveSig]
        new void OpenStateChange(/* [in] */ int NewState);
        
        [PreserveSig]
        new void PlayStateChange(/* [in] */ int NewState);
        
        [PreserveSig]
        new void AudioLanguageChange(/* [in] */ int LangID);
        
        [PreserveSig]
        new void StatusChange();
        
        [PreserveSig]
        new void ScriptCommand(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string scType, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string Param);
        
        [PreserveSig]
        new void NewStream();
        
        [PreserveSig]
        new void Disconnect(/* [in] */ int Result);
        
        [PreserveSig]
        new void Buffering(/* [in] */ bool Start);
        
        [PreserveSig]
        new void Error();
        
        [PreserveSig]
        new void Warning(/* [in] */ int WarningType, /* [in] */ int Param, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string Description);
        
        [PreserveSig]
        new void EndOfStream(/* [in] */ int Result);
        
        [PreserveSig]
        new void PositionChange(/* [in] */ double oldPosition, /* [in] */ double newPosition);
        
        [PreserveSig]
        new void MarkerHit(/* [in] */ int MarkerNum);
        
        [PreserveSig]
        new void DurationUnitChange(/* [in] */ int NewDurationUnit);
        
        [PreserveSig]
        new void CdromMediaChange(/* [in] */ int CdromNum);
        
        [PreserveSig]
        new void PlaylistChange(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object Playlist, /* [in] */ WMPPlaylistChangeEventType change);
        
        [PreserveSig]
        new void CurrentPlaylistChange(/* [in] */ WMPPlaylistChangeEventType change);
        
        [PreserveSig]
        new void CurrentPlaylistItemAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName);
        
        [PreserveSig]
        new void MediaChange(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object Item);
        
        [PreserveSig]
        new void CurrentMediaItemAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName);
        
        [PreserveSig]
        new void CurrentItemChange(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pdispMedia);
        
        [PreserveSig]
        new void MediaCollectionChange();
        
        [PreserveSig]
        new void MediaCollectionAttributeStringAdded(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribVal);
        
        [PreserveSig]
        new void MediaCollectionAttributeStringRemoved(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribVal);
        
        [PreserveSig]
        new void MediaCollectionAttributeStringChanged(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrOldAttribVal, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrNewAttribVal);
        
        [PreserveSig]
        new void PlaylistCollectionChange();
        
        [PreserveSig]
        new void PlaylistCollectionPlaylistAdded(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPlaylistName);
        
        [PreserveSig]
        new void PlaylistCollectionPlaylistRemoved(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPlaylistName);
        
        [PreserveSig]
        new void PlaylistCollectionPlaylistSetAsDeleted(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPlaylistName, /* [in] */ bool varfIsDeleted);
        
        [PreserveSig]
        new void ModeChange(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string ModeName, /* [in] */ bool NewValue);
        
        [PreserveSig]
        new void MediaError(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pMediaObject);
        
        [PreserveSig]
        new void OpenPlaylistSwitch(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pItem);
        
        [PreserveSig]
        new void DomainChange(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string strDomain);
        
        [PreserveSig]
        new void SwitchedToPlayerApplication();
        
        [PreserveSig]
        new void SwitchedToControl();
        
        [PreserveSig]
        new void PlayerDockedStateChange();
        
        [PreserveSig]
        new void PlayerReconnect();
        
        [PreserveSig]
        new void Click(/* [in] */ short nButton, /* [in] */ short nShiftState, /* [in] */ int fX, /* [in] */ int fY);
        
        [PreserveSig]
        new void DoubleClick(/* [in] */ short nButton, /* [in] */ short nShiftState, /* [in] */ int fX, /* [in] */ int fY);
        
        [PreserveSig]
        new void KeyDown(/* [in] */ short nKeyCode, /* [in] */ short nShiftState);
        
        [PreserveSig]
        new void KeyPress(/* [in] */ short nKeyAscii);
        
        [PreserveSig]
        new void KeyUp(/* [in] */ short nKeyCode, /* [in] */ short nShiftState);
        
        [PreserveSig]
        new void MouseDown(/* [in] */ short nButton, /* [in] */ short nShiftState, /* [in] */ int fX, /* [in] */ int fY);
        
        [PreserveSig]
        new void MouseMove(/* [in] */ short nButton, /* [in] */ short nShiftState, /* [in] */ int fX, /* [in] */ int fY);
        
        [PreserveSig]
        new void MouseUp(/* [in] */ short nButton, /* [in] */ short nShiftState, /* [in] */ int fX, /* [in] */ int fY);
        
        // IWMPEvents2
        [PreserveSig]
        void DeviceConnect(/* [in] */ IWMPSyncDevice pDevice);
        
        [PreserveSig]
        void DeviceDisconnect(/* [in] */ IWMPSyncDevice pDevice);
        
        [PreserveSig]
        void DeviceStatusChange(/* [in] */ IWMPSyncDevice pDevice, /* [in] */ WMPDeviceStatus NewStatus);
        
        [PreserveSig]
        void DeviceSyncStateChange(/* [in] */ IWMPSyncDevice pDevice, /* [in] */ WMPSyncState NewState);
        
        [PreserveSig]
        void DeviceSyncError(/* [in] */ IWMPSyncDevice pDevice, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pMedia);
        
        [PreserveSig]
        void CreatePartnershipComplete(/* [in] */ IWMPSyncDevice pDevice, /* [in] */ HRESULT hrResult);
    }
}
