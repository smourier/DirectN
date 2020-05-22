// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\audioclient.h(439,5)
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [Guid("726778cd-f60a-4eda-82de-e47610cd78aa"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioClient2 : IAudioClient
    {
        // IAudioClient
        [PreserveSig]
        new HRESULT Initialize(/* [annotation][in] _In_ */ _AUDCLNT_SHAREMODE ShareMode, /* [annotation][in] _In_ */ uint StreamFlags, /* [annotation][in] _In_ */ long hnsBufferDuration, /* [annotation][in] _In_ */ long hnsPeriodicity, /* [annotation][in] _In_ */ ref tWAVEFORMATEX pFormat, /* optional(LPCGUID) */ IntPtr AudioSessionGuid);
        
        [PreserveSig]
        new HRESULT GetBufferSize(/* [annotation][out] _Out_ */ out uint pNumBufferFrames);
        
        [PreserveSig]
        new HRESULT GetStreamLatency(/* [annotation][out] _Out_ */ out REFERENCE_TIME phnsLatency);
        
        [PreserveSig]
        new HRESULT GetCurrentPadding(/* [annotation][out] _Out_ */ out uint pNumPaddingFrames);
        
        [PreserveSig]
        new HRESULT IsFormatSupported(/* [annotation][in] _In_ */ _AUDCLNT_SHAREMODE ShareMode, /* [annotation][in] _In_ */ ref tWAVEFORMATEX pFormat, /* optional(tWAVEFORMATEX) */ IntPtr ppClosestMatch);
        
        [PreserveSig]
        new HRESULT GetMixFormat(/* [annotation][out] _Out_ */ out IntPtr ppDeviceFormat);
        
        [PreserveSig]
        new HRESULT GetDevicePeriod(/* optional(REFERENCE_TIME) */ IntPtr phnsDefaultDevicePeriod, /* optional(REFERENCE_TIME) */ IntPtr phnsMinimumDevicePeriod);
        
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
        HRESULT IsOffloadCapable(/* [annotation][in] _In_ */ _AUDIO_STREAM_CATEGORY Category, /* [annotation][out] _Out_ */ out bool pbOffloadCapable);
        
        [PreserveSig]
        HRESULT SetClientProperties(/* [annotation][in] _In_ */ ref AudioClientProperties pProperties);
        
        [PreserveSig]
        HRESULT GetBufferSizeLimits(/* [annotation][in] _In_ */ ref tWAVEFORMATEX pFormat, /* [annotation][in] _In_ */ bool bEventDriven, /* [annotation][out] _Out_ */ out REFERENCE_TIME phnsMinBufferDuration, /* [annotation][out] _Out_ */ out REFERENCE_TIME phnsMaxBufferDuration);
    }
}
