// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfcaptureengine.h(1020,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d2d43cc8-48bb-4aa7-95db-10c06977e777"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCapturePhotoSink : IMFCaptureSink
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
        
        // IMFCapturePhotoSink
        [PreserveSig]
        HRESULT SetOutputFileName(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string fileName);
        
        [PreserveSig]
        HRESULT SetSampleCallback(/* [annotation][in] _In_ */ IMFCaptureEngineOnSampleCallback pCallback);
        
        [PreserveSig]
        HRESULT SetOutputByteStream(/* [annotation][in] _In_ */ IMFByteStream pByteStream);
    }
}
