// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfcaptureengine.h(1849,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f9e4219e-6197-4b5e-b888-bee310ab2c59"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCaptureSink2 : IMFCaptureSink
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
        
        // IMFCaptureSink2
        [PreserveSig]
        HRESULT SetOutputMediaType(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ IMFMediaType pMediaType, /* [annotation][in] _In_opt_ */ IMFAttributes pEncodingAttributes);
    }
}
