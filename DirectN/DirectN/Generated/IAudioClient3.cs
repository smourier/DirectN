// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audioclient.h(702,5)
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [Guid("7ed4ee07-8e67-4cd4-8c1a-2b7a5987ad42"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioClient3 : IAudioClient2
    {
        // IAudioClient
        [PreserveSig]
        new HRESULT Initialize(/* [annotation][in] _In_ */ _AUDCLNT_SHAREMODE ShareMode, /* [annotation][in] _In_ */ uint StreamFlags, /* [annotation][in] _In_ */ long hnsBufferDuration, /* [annotation][in] _In_ */ long hnsPeriodicity, /* [annotation][in] _In_ */ ref tWAVEFORMATEX pFormat, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid AudioSessionGuid);
        
        [PreserveSig]
        new HRESULT GetBufferSize(/* [annotation][out] _Out_ */ out uint pNumBufferFrames);
        
        [PreserveSig]
        new HRESULT GetStreamLatency(/* [annotation][out] _Out_ */ out REFERENCE_TIME phnsLatency);
        
        [PreserveSig]
        new HRESULT GetCurrentPadding(/* [annotation][out] _Out_ */ out uint pNumPaddingFrames);
        
        [PreserveSig]
        new HRESULT IsFormatSupported(/* [annotation][in] _In_ */ _AUDCLNT_SHAREMODE ShareMode, /* [annotation][in] _In_ */ ref tWAVEFORMATEX pFormat, /* optional(tWAVEFORMATEX) */ out IntPtr ppClosestMatch);
        
        [PreserveSig]
        new HRESULT GetMixFormat(/* [annotation][out] _Out_ */ out IntPtr ppDeviceFormat);
        
        [PreserveSig]
        new HRESULT GetDevicePeriod(/* [annotation][out] _Out_opt_ */ out REFERENCE_TIME phnsDefaultDevicePeriod, /* [annotation][out] _Out_opt_ */ out REFERENCE_TIME phnsMinimumDevicePeriod);
        
        [PreserveSig]
        new HRESULT Start();
        
        [PreserveSig]
        new HRESULT Stop();
        
        [PreserveSig]
        new HRESULT Reset();
        
        [PreserveSig]
        new HRESULT SetEventHandle(/* [in] */ IntPtr eventHandle);
        
        [PreserveSig]
        new HRESULT GetService(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        // IAudioClient2
        [PreserveSig]
        new HRESULT IsOffloadCapable(/* [annotation][in] _In_ */ _AUDIO_STREAM_CATEGORY Category, /* [annotation][out] _Out_ */ out bool pbOffloadCapable);
        
        [PreserveSig]
        new HRESULT SetClientProperties(/* [annotation][in] _In_ */ ref AudioClientProperties pProperties);
        
        [PreserveSig]
        new HRESULT GetBufferSizeLimits(/* [annotation][in] _In_ */ ref tWAVEFORMATEX pFormat, /* [annotation][in] _In_ */ bool bEventDriven, /* [annotation][out] _Out_ */ out REFERENCE_TIME phnsMinBufferDuration, /* [annotation][out] _Out_ */ out REFERENCE_TIME phnsMaxBufferDuration);
        
        // IAudioClient3
        [PreserveSig]
        HRESULT GetSharedModeEnginePeriod(/* [annotation][in] _In_ */ ref tWAVEFORMATEX pFormat, /* [annotation][out] _Out_ */ out uint pDefaultPeriodInFrames, /* [annotation][out] _Out_ */ out uint pFundamentalPeriodInFrames, /* [annotation][out] _Out_ */ out uint pMinPeriodInFrames, /* [annotation][out] _Out_ */ out uint pMaxPeriodInFrames);
        
        [PreserveSig]
        HRESULT GetCurrentSharedModeEnginePeriod(/* [unique][annotation][out] _Out_ */ out IntPtr ppFormat, /* [annotation][out] _Out_ */ out uint pCurrentPeriodInFrames);
        
        [PreserveSig]
        HRESULT InitializeSharedAudioStream(/* [annotation][in] _In_ */ uint StreamFlags, /* [annotation][in] _In_ */ uint PeriodInFrames, /* [annotation][in] _In_ */ ref tWAVEFORMATEX pFormat, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid AudioSessionGuid);
    }
}
