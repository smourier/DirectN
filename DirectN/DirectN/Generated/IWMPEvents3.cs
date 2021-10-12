// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmp.h(13674,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1f504270-a66b-4223-8e96-26a06c63d69f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPEvents3 : IWMPEvents2
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
        new void PlaylistChange(/* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object Playlist, /* [in] */ WMPPlaylistChangeEventType change);
        
        [PreserveSig]
        new void CurrentPlaylistChange(/* [in] */ WMPPlaylistChangeEventType change);
        
        [PreserveSig]
        new void CurrentPlaylistItemAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName);
        
        [PreserveSig]
        new void MediaChange(/* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object Item);
        
        [PreserveSig]
        new void CurrentMediaItemAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName);
        
        [PreserveSig]
        new void CurrentItemChange(/* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object pdispMedia);
        
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
        new void MediaError(/* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object pMediaObject);
        
        [PreserveSig]
        new void OpenPlaylistSwitch(/* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object pItem);
        
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
        new void DeviceConnect(/* [in] */ IWMPSyncDevice pDevice);
        
        [PreserveSig]
        new void DeviceDisconnect(/* [in] */ IWMPSyncDevice pDevice);
        
        [PreserveSig]
        new void DeviceStatusChange(/* [in] */ IWMPSyncDevice pDevice, /* [in] */ WMPDeviceStatus NewStatus);
        
        [PreserveSig]
        new void DeviceSyncStateChange(/* [in] */ IWMPSyncDevice pDevice, /* [in] */ WMPSyncState NewState);
        
        [PreserveSig]
        new void DeviceSyncError(/* [in] */ IWMPSyncDevice pDevice, /* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object pMedia);
        
        [PreserveSig]
        new void CreatePartnershipComplete(/* [in] */ IWMPSyncDevice pDevice, /* [in] */ HRESULT hrResult);
        
        // IWMPEvents3
        [PreserveSig]
        void CdromRipStateChange(/* [in] */ IWMPCdromRip pCdromRip, /* [in] */ WMPRipState wmprs);
        
        [PreserveSig]
        void CdromRipMediaError(/* [in] */ IWMPCdromRip pCdromRip, /* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object pMedia);
        
        [PreserveSig]
        void CdromBurnStateChange(/* [in] */ IWMPCdromBurn pCdromBurn, /* [in] */ WMPBurnState wmpbs);
        
        [PreserveSig]
        void CdromBurnMediaError(/* [in] */ IWMPCdromBurn pCdromBurn, /* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object pMedia);
        
        [PreserveSig]
        void CdromBurnError(/* [in] */ IWMPCdromBurn pCdromBurn, /* [in] */ HRESULT hrError);
        
        [PreserveSig]
        void LibraryConnect(/* [in] */ IWMPLibrary pLibrary);
        
        [PreserveSig]
        void LibraryDisconnect(/* [in] */ IWMPLibrary pLibrary);
        
        [PreserveSig]
        void FolderScanStateChange(/* [in] */ WMPFolderScanState wmpfss);
        
        [PreserveSig]
        void StringCollectionChange(/* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object pdispStringCollection, /* [in] */ WMPStringCollectionChangeEventType change, /* [in] */ int lCollectionIndex);
        
        [PreserveSig]
        void MediaCollectionMediaAdded(/* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object pdispMedia);
        
        [PreserveSig]
        void MediaCollectionMediaRemoved(/* [in] */ [MarshalAs(UnmanagedType.IDispatch)] object pdispMedia);
    }
}
