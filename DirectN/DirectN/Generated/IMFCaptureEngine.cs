// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfcaptureengine.h(1480,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a6bba433-176b-48b2-b375-53aa03473207"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCaptureEngine
    {
        [PreserveSig]
        HRESULT Initialize(/* [annotation][in] _In_ */ IMFCaptureEngineOnEventCallback pEventCallback, /* [annotation][in] _In_opt_ */ IMFAttributes pAttributes, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pAudioSource, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pVideoSource);
        
        [PreserveSig]
        HRESULT StartPreview();
        
        [PreserveSig]
        HRESULT StopPreview();
        
        [PreserveSig]
        HRESULT StartRecord();
        
        [PreserveSig]
        HRESULT StopRecord(/* [annotation][in] _In_ */ bool bFinalize, /* [annotation][in] _In_ */ bool bFlushUnprocessedSamples);
        
        [PreserveSig]
        HRESULT TakePhoto();
        
        [PreserveSig]
        HRESULT GetSink(/* [annotation][in] _In_ */ MF_CAPTURE_ENGINE_SINK_TYPE mfCaptureEngineSinkType, /* [annotation][out] _Out_ */ out IMFCaptureSink ppSink);
        
        [PreserveSig]
        HRESULT GetSource(/* [annotation][out] _Out_ */ out IMFCaptureSource ppSource);
    }
}
