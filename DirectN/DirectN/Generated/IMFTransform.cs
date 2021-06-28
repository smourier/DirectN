// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mftransform.h(241,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bf94c121-5b05-4e6f-8000-ba598961414d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTransform
    {
        [PreserveSig]
        HRESULT GetStreamLimits(/* [out] __RPC__out */ out uint pdwInputMinimum, /* [out] __RPC__out */ out uint pdwInputMaximum, /* [out] __RPC__out */ out uint pdwOutputMinimum, /* [out] __RPC__out */ out uint pdwOutputMaximum);
        
        [PreserveSig]
        HRESULT GetStreamCount(/* [out] __RPC__out */ out uint pcInputStreams, /* [out] __RPC__out */ out uint pcOutputStreams);
        
        [PreserveSig]
        HRESULT GetStreamIDs(int dwInputIDArraySize, /* [size_is][out] __RPC__out_ecount_full(dwInputIDArraySize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pdwInputIDs, int dwOutputIDArraySize, /* [size_is][out] __RPC__out_ecount_full(dwOutputIDArraySize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] pdwOutputIDs);
        
        [PreserveSig]
        HRESULT GetInputStreamInfo(uint dwInputStreamID, /* [out] __RPC__out */ out _MFT_INPUT_STREAM_INFO pStreamInfo);
        
        [PreserveSig]
        HRESULT GetOutputStreamInfo(uint dwOutputStreamID, /* [out] __RPC__out */ out _MFT_OUTPUT_STREAM_INFO pStreamInfo);
        
        [PreserveSig]
        HRESULT GetAttributes(/* [out] __RPC__deref_out_opt */ out IMFAttributes pAttributes);
        
        [PreserveSig]
        HRESULT GetInputStreamAttributes(uint dwInputStreamID, /* [out] __RPC__deref_out_opt */ out IMFAttributes pAttributes);
        
        [PreserveSig]
        HRESULT GetOutputStreamAttributes(uint dwOutputStreamID, /* [out] __RPC__deref_out_opt */ out IMFAttributes pAttributes);
        
        [PreserveSig]
        HRESULT DeleteInputStream(uint dwStreamID);
        
        [PreserveSig]
        HRESULT AddInputStreams(uint cStreams, /* [in] __RPC__in */ ref uint adwStreamIDs);
        
        [PreserveSig]
        HRESULT GetInputAvailableType(uint dwInputStreamID, uint dwTypeIndex, /* [out] __RPC__deref_out_opt */ out IMFMediaType ppType);
        
        [PreserveSig]
        HRESULT GetOutputAvailableType(uint dwOutputStreamID, uint dwTypeIndex, /* [out] __RPC__deref_out_opt */ out IMFMediaType ppType);
        
        [PreserveSig]
        HRESULT SetInputType(uint dwInputStreamID, /* [in] __RPC__in_opt */ IMFMediaType pType, uint dwFlags);
        
        [PreserveSig]
        HRESULT SetOutputType(uint dwOutputStreamID, /* [in] __RPC__in_opt */ IMFMediaType pType, uint dwFlags);
        
        [PreserveSig]
        HRESULT GetInputCurrentType(uint dwInputStreamID, /* [out] __RPC__deref_out_opt */ out IMFMediaType ppType);
        
        [PreserveSig]
        HRESULT GetOutputCurrentType(uint dwOutputStreamID, /* [out] __RPC__deref_out_opt */ out IMFMediaType ppType);
        
        [PreserveSig]
        HRESULT GetInputStatus(uint dwInputStreamID, /* [out] __RPC__out */ out uint pdwFlags);
        
        [PreserveSig]
        HRESULT GetOutputStatus(/* [out] __RPC__out */ out uint pdwFlags);
        
        [PreserveSig]
        HRESULT SetOutputBounds(long hnsLowerBound, long hnsUpperBound);
        
        [PreserveSig]
        HRESULT ProcessEvent(uint dwInputStreamID, /* [in] __RPC__in_opt */ IMFMediaEvent pEvent);
        
        [PreserveSig]
        HRESULT ProcessMessage(_MFT_MESSAGE_TYPE eMessage, IntPtr ulParam);
        
        [PreserveSig]
        HRESULT ProcessInput(uint dwInputStreamID, IMFSample pSample, uint dwFlags);
        
        [PreserveSig]
        HRESULT ProcessOutput(uint dwFlags, uint cOutputBufferCount, /* [size_is][out][in] */ [In, Out, MarshalAs(UnmanagedType.LPArray)] _MFT_OUTPUT_DATA_BUFFER[] pOutputSamples, /* [out] */ out uint pdwStatus);
    }
}
