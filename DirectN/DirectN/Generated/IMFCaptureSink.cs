// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfcaptureengine.h(412,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("72d6135b-35e9-412c-b926-fd5265f2a885"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCaptureSink
    {
        [PreserveSig]
        HRESULT GetOutputMediaType(/* [annotation][in] _In_ */ uint dwSinkStreamIndex, /* [annotation][out] _Out_opt_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        HRESULT GetService(/* [annotation][in] _In_ */ uint dwSinkStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidService, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnknown);
        
        [PreserveSig]
        HRESULT AddStream(/* [annotation][in] _In_ */ uint dwSourceStreamIndex, /* [annotation][in] _In_ */ IMFMediaType pMediaType, /* [annotation][in] _In_opt_ */ IMFAttributes pAttributes, /* [annotation][out] _Out_opt_ */ out uint pdwSinkStreamIndex);
        
        [PreserveSig]
        HRESULT Prepare();
        
        [PreserveSig]
        HRESULT RemoveAllStreams();
    }
}
