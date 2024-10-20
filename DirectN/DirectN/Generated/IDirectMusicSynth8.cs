// generated from <Windows SDK Path>\um\dmusics.h
using System;
using System.Runtime.InteropServices;
using LPDMUS_SYNTHSTATS = DirectN._DMUS_SYNTHSTATS;

namespace DirectN
{
    [ComImport, Guid("53cab625-2711-4c9f-9de7-1b7f925f6fc8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectMusicSynth8 : IDirectMusicSynth
    {
        // IDirectMusicSynth
        [PreserveSig]
        new HRESULT Open(ref _DMUS_PORTPARAMS8 pPortParams);
        
        [PreserveSig]
        new HRESULT Close();
        
        [PreserveSig]
        new HRESULT SetNumChannelGroups(uint dwGroups);
        
        [PreserveSig]
        new HRESULT Download(IntPtr phDownload, IntPtr pvData, ref bool pbFree);
        
        [PreserveSig]
        new HRESULT Unload(IntPtr hDownload, IntPtr lpFreeHandle, IntPtr hUserData);
        
        [PreserveSig]
        new HRESULT PlayBuffer(long rt, IntPtr pbBuffer, uint cbBuffer);
        
        [PreserveSig]
        new HRESULT GetRunningStats(ref LPDMUS_SYNTHSTATS pStats);
        
        [PreserveSig]
        new HRESULT GetPortCaps(ref _DMUS_PORTCAPS pCaps);
        
        [PreserveSig]
        new HRESULT SetMasterClock(IReferenceClock pClock);
        
        [PreserveSig]
        new HRESULT GetLatencyClock(out IReferenceClock ppClock);
        
        [PreserveSig]
        new HRESULT Activate(bool fEnable);
        
        [PreserveSig]
        new HRESULT SetSynthSink(IDirectMusicSynthSink pSynthSink);
        
        [PreserveSig]
        new HRESULT Render(ref short pBuffer, uint dwLength, long llPosition);
        
        [PreserveSig]
        new HRESULT SetChannelPriority(uint dwChannelGroup, uint dwChannel, uint dwPriority);
        
        [PreserveSig]
        new HRESULT GetChannelPriority(uint dwChannelGroup, uint dwChannel, ref uint pdwPriority);
        
        [PreserveSig]
        new HRESULT GetFormat(ref tWAVEFORMATEX pWaveFormatEx, ref uint pdwWaveFormatExSize);
        
        [PreserveSig]
        new HRESULT GetAppend(ref uint pdwAppend);
        
        // IDirectMusicSynth8
        [PreserveSig]
        HRESULT PlayVoice(long rt, uint dwVoiceId, uint dwChannelGroup, uint dwChannel, uint dwDLId, int prPitch, /* PREL not defined here */ int vrVolume, /* VREL not defined here */ ulong stVoiceStart, ulong stLoopStart, ulong stLoopEnd);
        
        [PreserveSig]
        HRESULT StopVoice(long rt, uint dwVoiceId);
        
        [PreserveSig]
        HRESULT GetVoiceState(uint[] dwVoice, uint cbVoice, _DMUS_VOICE_STATE[] dwVoiceState);
        
        [PreserveSig]
        HRESULT Refresh(uint dwDownloadID, uint dwFlags);
        
        [PreserveSig]
        HRESULT AssignChannelToBuses(uint dwChannelGroup, uint dwChannel, ref uint pdwBuses, uint cBuses);
    }
}
