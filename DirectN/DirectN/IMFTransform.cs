using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bf94c121-5b05-4e6f-8000-ba598961414d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFTransform
    {
        [PreserveSig]
        HRESULT GetStreamLimits(out int pdwInputMinimum, out int pdwInputMaximum, out int pdwOutputMinimum, out int pdwOutputMaximum);

        [PreserveSig]
        HRESULT GetStreamCount(out int pcInputStreams, out int pcOutputStreams);

        [PreserveSig]
        HRESULT GetStreamIDs(int dwInputIDArraySize, [In, Out] int[] pdwInputIDs, int dwOutputIDArraySize, [In, Out] int[] pdwOutputIDs);

        [PreserveSig]
        HRESULT GetInputStreamInfo(int dwInputStreamID, out MFT_INPUT_STREAM_INFO pStreamInfo);

        [PreserveSig]
        HRESULT GetOutputStreamInfo(int dwOutputStreamID, out MFT_OUTPUT_STREAM_INFO pStreamInfo);

        [PreserveSig]
        HRESULT GetAttributes(out IMFAttributes pAttributes);

        [PreserveSig]
        HRESULT GetInputStreamAttributes(int dwInputStreamID, out IMFAttributes pAttributes);

        [PreserveSig]
        HRESULT GetOutputStreamAttributes(int dwOutputStreamID, out IMFAttributes pAttributes);

        [PreserveSig]
        HRESULT DeleteInputStream(int dwStreamID);

        [PreserveSig]
        HRESULT AddInputStreams(int cStreams, int[] adwStreamIDs);

        [PreserveSig]
        HRESULT GetInputAvailableType(int dwInputStreamID, int dwTypeIndex, out IMFMediaType ppType);

        [PreserveSig]
        HRESULT GetOutputAvailableType(int dwOutputStreamID, int dwTypeIndex, out IMFMediaType ppType);

        [PreserveSig]
        HRESULT SetInputType(int dwInputStreamID, IMFMediaType pType, MFT_SET_TYPE_FLAGS dwFlags);

        [PreserveSig]
        HRESULT SetOutputType(int dwOutputStreamID, IMFMediaType pType, MFT_SET_TYPE_FLAGS dwFlags);

        [PreserveSig]
        HRESULT GetInputCurrentType(int dwInputStreamID, out IMFMediaType ppType);

        [PreserveSig]
        HRESULT GetOutputCurrentType(int dwOutputStreamID, out IMFMediaType ppType);

        [PreserveSig]
        HRESULT GetInputStatus(int dwInputStreamID, out int pdwFlags);

        [PreserveSig]
        HRESULT GetOutputStatus(out int pdwFlags);

        [PreserveSig]
        HRESULT SetOutputBounds(long hnsLowerBound, long hnsUpperBound);

        [PreserveSig]
        HRESULT ProcessEvent(int dwInputStreamID, IMFMediaEvent pEvent);

        [PreserveSig]
        HRESULT ProcessMessage(MFT_MESSAGE_TYPE eMessage, IntPtr ulParam);

        [PreserveSig]
        HRESULT ProcessInput(int dwInputStreamID, IMFSample pSample, int dwFlags);

        [PreserveSig]
        HRESULT ProcessOutput(MFT_PROCESS_OUTPUT_FLAGS dwFlags, int cOutputBufferCount, MFT_OUTPUT_DATA_BUFFER[] pOutputSamples, out int pdwStatus);
    }
}
