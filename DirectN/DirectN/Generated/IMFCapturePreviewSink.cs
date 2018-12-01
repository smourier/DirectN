// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfcaptureengine.h(771,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("77346cfd-5b49-4d73-ace0-5b52a859f2e0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCapturePreviewSink : IMFCaptureSink
    {
        // IMFCaptureSink
        [PreserveSig]
        new HRESULT GetOutputMediaType(/* [annotation][in] _In_ */ uint dwSinkStreamIndex, /* [annotation][out] _Out_opt_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        new HRESULT GetService(/* [annotation][in] _In_ */ uint dwSinkStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidService, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnknown);
        
        [PreserveSig]
        new HRESULT AddStream(/* [annotation][in] _In_ */ uint dwSourceStreamIndex, /* [annotation][in] _In_ */ IMFMediaType pMediaType, /* [annotation][in] _In_opt_ */ IMFAttributes pAttributes, /* [annotation][out] _Out_opt_ */ out uint pdwSinkStreamIndex);
        
        [PreserveSig]
        new HRESULT Prepare();
        
        [PreserveSig]
        new HRESULT RemoveAllStreams();
        
        // IMFCapturePreviewSink
        [PreserveSig]
        HRESULT SetRenderHandle(/* [annotation][in] _In_ */ IntPtr handle);
        
        [PreserveSig]
        HRESULT SetRenderSurface(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pSurface);
        
        [PreserveSig]
        HRESULT UpdateVideo(/* [annotation][in] _In_opt_ */ ref MFVideoNormalizedRect pSrc, /* [annotation][in] _In_opt_ */ ref tagRECT pDst, /* [annotation][in] _In_opt_ */ ref uint pBorderClr);
        
        [PreserveSig]
        HRESULT SetSampleCallback(/* [annotation][in] _In_ */ uint dwStreamSinkIndex, /* [annotation][in] _In_ */ IMFCaptureEngineOnSampleCallback pCallback);
        
        [PreserveSig]
        HRESULT GetMirrorState(/* [annotation][out] _Out_ */ out bool pfMirrorState);
        
        [PreserveSig]
        HRESULT SetMirrorState(/* [annotation][in] _In_ */ bool fMirrorState);
        
        [PreserveSig]
        HRESULT GetRotation(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][out] _Out_ */ out uint pdwRotationValue);
        
        [PreserveSig]
        HRESULT SetRotation(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwRotationValue);
        
        [PreserveSig]
        HRESULT SetCustomSink(/* [annotation][in] _In_ */ IMFMediaSink pMediaSink);
    }
}
