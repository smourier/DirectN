// generated from <Windows SDK Path>\um\dmusics.h
using System;
using System.Runtime.InteropServices;
using LPDMUS_SYNTHSTATS = DirectN._DMUS_SYNTHSTATS;

namespace DirectN
{
    [ComImport, Guid("09823661-5c85-11d2-afa6-00aa0024d8b6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectMusicSynth
    {
        [PreserveSig]
        HRESULT Open(ref _DMUS_PORTPARAMS8 pPortParams);
        
        [PreserveSig]
        HRESULT Close();
        
        [PreserveSig]
        HRESULT SetNumChannelGroups(uint dwGroups);
        
        [PreserveSig]
        HRESULT Download(IntPtr phDownload, IntPtr pvData, ref bool pbFree);
        
        [PreserveSig]
        HRESULT Unload(IntPtr hDownload, IntPtr lpFreeHandle, IntPtr hUserData);
        
        [PreserveSig]
        HRESULT PlayBuffer(long rt, IntPtr pbBuffer, uint cbBuffer);
        
        [PreserveSig]
        HRESULT GetRunningStats(ref LPDMUS_SYNTHSTATS pStats);
        
        [PreserveSig]
        HRESULT GetPortCaps(ref _DMUS_PORTCAPS pCaps);
        
        [PreserveSig]
        HRESULT SetMasterClock(IReferenceClock pClock);
        
        [PreserveSig]
        HRESULT GetLatencyClock(out IReferenceClock ppClock);
        
        [PreserveSig]
        HRESULT Activate(bool fEnable);
        
        [PreserveSig]
        HRESULT SetSynthSink(IDirectMusicSynthSink pSynthSink);
        
        [PreserveSig]
        HRESULT Render(ref short pBuffer, uint dwLength, long llPosition);
        
        [PreserveSig]
        HRESULT SetChannelPriority(uint dwChannelGroup, uint dwChannel, uint dwPriority);
        
        [PreserveSig]
        HRESULT GetChannelPriority(uint dwChannelGroup, uint dwChannel, ref uint pdwPriority);
        
        [PreserveSig]
        HRESULT GetFormat(ref tWAVEFORMATEX pWaveFormatEx, ref uint pdwWaveFormatExSize);
        
        [PreserveSig]
        HRESULT GetAppend(ref uint pdwAppend);
    }
}
