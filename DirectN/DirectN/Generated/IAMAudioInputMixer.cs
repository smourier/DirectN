// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("54c39221-8380-11d0-b3f0-00aa003761c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMAudioInputMixer
    {
        [PreserveSig]
        HRESULT put_Enable(/* [in] */ bool fEnable);
        
        [PreserveSig]
        HRESULT get_Enable(/* [annotation][out] _Out_ */ out bool pfEnable);
        
        [PreserveSig]
        HRESULT put_Mono(/* [in] */ bool fMono);
        
        [PreserveSig]
        HRESULT get_Mono(/* [annotation][out] _Out_ */ out bool pfMono);
        
        [PreserveSig]
        HRESULT put_MixLevel(/* [in] */ double Level);
        
        [PreserveSig]
        HRESULT get_MixLevel(/* [annotation][out] _Out_ */ out double pLevel);
        
        [PreserveSig]
        HRESULT put_Pan(/* [in] */ double Pan);
        
        [PreserveSig]
        HRESULT get_Pan(/* [annotation][out] _Out_ */ out double pPan);
        
        [PreserveSig]
        HRESULT put_Loudness(/* [in] */ bool fLoudness);
        
        [PreserveSig]
        HRESULT get_Loudness(/* [annotation][out] _Out_ */ out bool pfLoudness);
        
        [PreserveSig]
        HRESULT put_Treble(/* [in] */ double Treble);
        
        [PreserveSig]
        HRESULT get_Treble(/* [annotation][out] _Out_ */ out double pTreble);
        
        [PreserveSig]
        HRESULT get_TrebleRange(/* [annotation][out] _Out_ */ out double pRange);
        
        [PreserveSig]
        HRESULT put_Bass(/* [in] */ double Bass);
        
        [PreserveSig]
        HRESULT get_Bass(/* [annotation][out] _Out_ */ out double pBass);
        
        [PreserveSig]
        HRESULT get_BassRange(/* [annotation][out] _Out_ */ out double pRange);
    }
}
