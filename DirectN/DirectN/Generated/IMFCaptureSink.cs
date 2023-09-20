// generated from <Windows SDK Path>\um\mfcaptureengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("72d6135b-35e9-412c-b926-fd5265f2a885"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCaptureSink
    {
        [PreserveSig]
        HRESULT GetOutputMediaType(/* [annotation][in] _In_ */ uint dwSinkStreamIndex, /* [annotation][out] _Out_opt_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        HRESULT GetService(/* [annotation][in] _In_ */ uint dwSinkStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidService, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnknown);
        
        [PreserveSig]
        HRESULT AddStream(/* [annotation][in] _In_ */ uint dwSourceStreamIndex, /* [annotation][in] _In_ */ IMFMediaType pMediaType, /* [annotation][in] _In_opt_ */ IMFAttributes pAttributes, /* optional(DWORD) */ IntPtr pdwSinkStreamIndex);
        
        [PreserveSig]
        HRESULT Prepare();
        
        [PreserveSig]
        HRESULT RemoveAllStreams();
    }
}
