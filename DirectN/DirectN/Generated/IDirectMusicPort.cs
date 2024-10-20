// generated from <Windows SDK Path>\um\dmusicc.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTMUSICBUFFER = DirectN.IDirectMusicBuffer;
using LPDIRECTSOUND = DirectN.IDirectSound;
using LPDIRECTSOUNDBUFFER = DirectN.IDirectSoundBuffer;
using LPDMUS_SYNTHSTATS = DirectN._DMUS_SYNTHSTATS;

namespace DirectN
{
    [ComImport, Guid("08f2d8c9-37c2-11d2-b9f9-0000f875ac12"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectMusicPort
    {
        [PreserveSig]
        HRESULT PlayBuffer(LPDIRECTMUSICBUFFER pBuffer);
        
        [PreserveSig]
        HRESULT SetReadNotificationHandle(IntPtr hEvent);
        
        [PreserveSig]
        HRESULT Read(LPDIRECTMUSICBUFFER pBuffer);
        
        [PreserveSig]
        HRESULT DownloadInstrument(IDirectMusicInstrument pInstrument, out IDirectMusicDownloadedInstrument ppDownloadedInstrument, ref _DMUS_NOTERANGE pNoteRanges, uint dwNumNoteRanges);
        
        [PreserveSig]
        HRESULT UnloadInstrument(IDirectMusicDownloadedInstrument pDownloadedInstrument);
        
        [PreserveSig]
        HRESULT GetLatencyClock(out IReferenceClock ppClock);
        
        [PreserveSig]
        HRESULT GetRunningStats(ref LPDMUS_SYNTHSTATS pStats);
        
        [PreserveSig]
        HRESULT Compact();
        
        [PreserveSig]
        HRESULT GetCaps(ref _DMUS_PORTCAPS pPortCaps);
        
        [PreserveSig]
        HRESULT DeviceIoControl(uint dwIoControlCode, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, ref uint lpBytesReturned, IntPtr lpOverlapped);
        
        [PreserveSig]
        HRESULT SetNumChannelGroups(uint dwChannelGroups);
        
        [PreserveSig]
        HRESULT GetNumChannelGroups(ref uint pdwChannelGroups);
        
        [PreserveSig]
        HRESULT Activate(bool fActive);
        
        [PreserveSig]
        HRESULT SetChannelPriority(uint dwChannelGroup, uint dwChannel, uint dwPriority);
        
        [PreserveSig]
        HRESULT GetChannelPriority(uint dwChannelGroup, uint dwChannel, ref uint pdwPriority);
        
        [PreserveSig]
        HRESULT SetDirectSound(LPDIRECTSOUND pDirectSound, LPDIRECTSOUNDBUFFER pDirectSoundBuffer);
        
        [PreserveSig]
        HRESULT GetFormat(ref tWAVEFORMATEX pWaveFormatEx, ref uint pdwWaveFormatExSize, ref uint pdwBufferSize);
    }
}
