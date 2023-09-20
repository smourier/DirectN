// generated from <Windows SDK Path>\um\mfcaptureengine.h
using System;
using System.Runtime.InteropServices;
using COLORREF = System.UInt32;

namespace DirectN
{
    [ComImport, Guid("77346cfd-5b49-4d73-ace0-5b52a859f2e0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCapturePreviewSink : IMFCaptureSink
    {
        // IMFCaptureSink
        [PreserveSig]
        new HRESULT GetOutputMediaType(/* [annotation][in] _In_ */ uint dwSinkStreamIndex, /* [annotation][out] _Out_opt_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        new HRESULT GetService(/* [annotation][in] _In_ */ uint dwSinkStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidService, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnknown);
        
        [PreserveSig]
        new HRESULT AddStream(/* [annotation][in] _In_ */ uint dwSourceStreamIndex, /* [annotation][in] _In_ */ IMFMediaType pMediaType, /* [annotation][in] _In_opt_ */ IMFAttributes pAttributes, /* optional(DWORD) */ IntPtr pdwSinkStreamIndex);
        
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
        HRESULT UpdateVideo(/* optional(MFVideoNormalizedRect) */ IntPtr pSrc, /* optional(tagRECT) */ IntPtr pDst, /* optional(COLORREF) */ IntPtr pBorderClr);
        
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
