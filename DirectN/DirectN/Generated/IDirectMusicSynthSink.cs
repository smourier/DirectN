// generated from <Windows SDK Path>\um\dmusics.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTSOUND = DirectN.IDirectSound;
using LPDIRECTSOUNDBUFFER = DirectN.IDirectSoundBuffer;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("09823663-5c85-11d2-afa6-00aa0024d8b6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectMusicSynthSink
    {
        [PreserveSig]
        HRESULT Init(IDirectMusicSynth pSynth);
        
        [PreserveSig]
        HRESULT SetMasterClock(IReferenceClock pClock);
        
        [PreserveSig]
        HRESULT GetLatencyClock(out IReferenceClock ppClock);
        
        [PreserveSig]
        HRESULT Activate(bool fEnable);
        
        [PreserveSig]
        HRESULT SampleToRefTime(long llSampleTime, ref REFERENCE_TIME prfTime);
        
        [PreserveSig]
        HRESULT RefTimeToSample(long rfTime, ref long pllSampleTime);
        
        [PreserveSig]
        HRESULT SetDirectSound(LPDIRECTSOUND pDirectSound, LPDIRECTSOUNDBUFFER pDirectSoundBuffer);
        
        [PreserveSig]
        HRESULT GetDesiredBufferSize(ref uint pdwBufferSizeInSamples);
    }
}
