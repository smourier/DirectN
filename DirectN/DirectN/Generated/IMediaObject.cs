// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mediaobj.h(310,5)
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [Guid("d8ad0f58-5494-4102-97c5-ec798e59bcf4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaObject
    {
        [PreserveSig]
        HRESULT GetStreamCount(/* [annotation][out] _Out_ */ out uint pcInputStreams, /* [annotation][out] _Out_ */ out uint pcOutputStreams);
        
        [PreserveSig]
        HRESULT GetInputStreamInfo(uint dwInputStreamIndex, /* [annotation][out] _Out_ */ out uint pdwFlags);
        
        [PreserveSig]
        HRESULT GetOutputStreamInfo(uint dwOutputStreamIndex, /* [annotation][out] _Out_ */ out uint pdwFlags);
        
        [PreserveSig]
        HRESULT GetInputType(uint dwInputStreamIndex, uint dwTypeIndex, /* optional(_DMOMediaType) */ IntPtr pmt);
        
        [PreserveSig]
        HRESULT GetOutputType(uint dwOutputStreamIndex, uint dwTypeIndex, /* optional(_DMOMediaType) */ IntPtr pmt);
        
        [PreserveSig]
        HRESULT SetInputType(uint dwInputStreamIndex, /* optional(_DMOMediaType) */ IntPtr pmt, uint dwFlags);
        
        [PreserveSig]
        HRESULT SetOutputType(uint dwOutputStreamIndex, /* optional(_DMOMediaType) */ IntPtr pmt, uint dwFlags);
        
        [PreserveSig]
        HRESULT GetInputCurrentType(uint dwInputStreamIndex, /* [annotation][out] _Out_ */ out _DMOMediaType pmt);
        
        [PreserveSig]
        HRESULT GetOutputCurrentType(uint dwOutputStreamIndex, /* [annotation][out] _Out_ */ out _DMOMediaType pmt);
        
        [PreserveSig]
        HRESULT GetInputSizeInfo(uint dwInputStreamIndex, /* [annotation][out] _Out_ */ out uint pcbSize, /* [annotation][out] _Out_ */ out uint pcbMaxLookahead, /* [annotation][out] _Out_ */ out uint pcbAlignment);
        
        [PreserveSig]
        HRESULT GetOutputSizeInfo(uint dwOutputStreamIndex, /* [annotation][out] _Out_ */ out uint pcbSize, /* [annotation][out] _Out_ */ out uint pcbAlignment);
        
        [PreserveSig]
        HRESULT GetInputMaxLatency(uint dwInputStreamIndex, /* [annotation][out] _Out_ */ out REFERENCE_TIME prtMaxLatency);
        
        [PreserveSig]
        HRESULT SetInputMaxLatency(uint dwInputStreamIndex, long rtMaxLatency);
        
        [PreserveSig]
        HRESULT Flush();
        
        [PreserveSig]
        HRESULT Discontinuity(uint dwInputStreamIndex);
        
        [PreserveSig]
        HRESULT AllocateStreamingResources();
        
        [PreserveSig]
        HRESULT FreeStreamingResources();
        
        [PreserveSig]
        HRESULT GetInputStatus(uint dwInputStreamIndex, /* [annotation][out] _Out_ */ out uint dwFlags);
        
        [PreserveSig]
        HRESULT ProcessInput(uint dwInputStreamIndex, IMediaBuffer pBuffer, uint dwFlags, long rtTimestamp, long rtTimelength);
        
        [PreserveSig]
        HRESULT ProcessOutput(uint dwFlags, int cOutputBufferCount, /* [annotation][size_is][out][in] _Out_writes_(cOutputBufferCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] _DMO_OUTPUT_DATA_BUFFER[] pOutputBuffers, /* [annotation][out] _Out_ */ out uint pdwStatus);
        
        [PreserveSig]
        HRESULT Lock(int bLock);
    }
}
