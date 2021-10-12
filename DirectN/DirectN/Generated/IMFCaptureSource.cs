// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfcaptureengine.h(1248,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("439a42a8-0d2c-4505-be83-f79b2a05d5c4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCaptureSource
    {
        [PreserveSig]
        HRESULT GetCaptureDeviceSource(/* [annotation][in] _In_ */ MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, /* [annotation][out] _Out_opt_ */ out IMFMediaSource ppMediaSource);
        
        [PreserveSig]
        HRESULT GetCaptureDeviceActivate(/* [annotation][in] _In_ */ MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType, /* [annotation][out] _Out_opt_ */ out IMFActivate ppActivate);
        
        [PreserveSig]
        HRESULT GetService(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidService, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnknown);
        
        [PreserveSig]
        HRESULT AddEffect(/* [annotation][in] _In_ */ uint dwSourceStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);
        
        [PreserveSig]
        HRESULT RemoveEffect(/* [annotation][in] _In_ */ uint dwSourceStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnknown);
        
        [PreserveSig]
        HRESULT RemoveAllEffects(/* [annotation][in] _In_ */ uint dwSourceStreamIndex);
        
        [PreserveSig]
        HRESULT GetAvailableDeviceMediaType(/* [annotation][in] _In_ */ uint dwSourceStreamIndex, /* [annotation][in] _In_ */ uint dwMediaTypeIndex, /* [annotation][out] _Out_opt_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        HRESULT SetCurrentDeviceMediaType(/* [annotation][in] _In_ */ uint dwSourceStreamIndex, /* [annotation][in] _In_ */ IMFMediaType pMediaType);
        
        [PreserveSig]
        HRESULT GetCurrentDeviceMediaType(/* [annotation][in] _In_ */ uint dwSourceStreamIndex, /* [annotation][out] _Out_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        HRESULT GetDeviceStreamCount(/* [annotation][out] _Out_ */ out uint pdwStreamCount);
        
        [PreserveSig]
        HRESULT GetDeviceStreamCategory(/* [annotation][in] _In_ */ uint dwSourceStreamIndex, /* [annotation][out] _Out_ */ out MF_CAPTURE_ENGINE_STREAM_CATEGORY pStreamCategory);
        
        [PreserveSig]
        HRESULT GetMirrorState(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][out] _Out_ */ out bool pfMirrorState);
        
        [PreserveSig]
        HRESULT SetMirrorState(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ bool fMirrorState);
        
        [PreserveSig]
        HRESULT GetStreamIndexFromFriendlyName(/* [annotation][in] _In_ */ uint uifriendlyName, /* [annotation][out] _Out_ */ out uint pdwActualStreamIndex);
    }
}
