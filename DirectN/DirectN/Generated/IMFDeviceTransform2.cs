// generated from <Windows SDK Path>\um\mftransform.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f5980fed-b521-488f-909f-1a5fcecedb14"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFDeviceTransform2 : IMFDeviceTransform
    {
        // IMFDeviceTransform
        [PreserveSig]
        new HRESULT InitializeTransform(/* [annotation][in] _In_ */ IMFAttributes pAttributes);
        
        [PreserveSig]
        new HRESULT GetInputAvailableType(/* [annotation][in] _In_ */ uint dwInputStreamID, /* [annotation][in] _In_ */ uint dwTypeIndex, /* [annotation][out] _COM_Outptr_ */ out IMFMediaType pMediaType);
        
        [PreserveSig]
        new HRESULT GetInputCurrentType(/* [annotation][in] _In_ */ uint dwInputStreamID, /* [annotation][out] _COM_Outptr_ */ out IMFMediaType pMediaType);
        
        [PreserveSig]
        new HRESULT GetInputStreamAttributes(/* [annotation][in] _In_ */ uint dwInputStreamID, /* [annotation][out] _COM_Outptr_ */ out IMFAttributes ppAttributes);
        
        [PreserveSig]
        new HRESULT GetOutputAvailableType(/* [annotation][in] _In_ */ uint dwOutputStreamID, /* [annotation][in] _In_ */ uint dwTypeIndex, /* [annotation][out] _COM_Outptr_ */ out IMFMediaType pMediaType);
        
        [PreserveSig]
        new HRESULT GetOutputCurrentType(/* [annotation][in] _In_ */ uint dwOutputStreamID, /* [annotation][out] _COM_Outptr_ */ out IMFMediaType pMediaType);
        
        [PreserveSig]
        new HRESULT GetOutputStreamAttributes(/* [annotation][in] _In_ */ uint dwOutputStreamID, /* [annotation][out] _COM_Outptr_ */ out IMFAttributes ppAttributes);
        
        [PreserveSig]
        new HRESULT GetStreamCount(/* [annotation][out] _Out_ */ out uint pcInputStreams, /* [annotation][out] _Out_ */ out uint pcOutputStreams);
        
        [PreserveSig]
        new HRESULT GetStreamIDs(/* [annotation][in] _In_ */ uint dwInputIDArraySize, /* [annotation][out] _Out_ */ out uint pdwInputStreamIds, /* [annotation][in] _In_ */ uint dwOutputIDArraySize, /* [annotation][out] _Out_ */ out uint pdwOutputStreamIds);
        
        [PreserveSig]
        new HRESULT ProcessEvent(/* [annotation][in] _In_ */ uint dwInputStreamID, /* [annotation][in] _In_ */ IMFMediaEvent pEvent);
        
        [PreserveSig]
        new HRESULT ProcessInput(/* [annotation][in] _In_ */ uint dwInputStreamID, /* [annotation][in] _In_ */ IMFSample pSample, /* [annotation][in] _In_ */ uint dwFlags);
        
        [PreserveSig]
        new HRESULT ProcessMessage(/* [annotation][in] _In_ */ _MFT_MESSAGE_TYPE eMessage, /* [annotation][in] _In_ */ IntPtr ulParam);
        
        [PreserveSig]
        new HRESULT ProcessOutput(/* [annotation][in] _In_ */ uint dwFlags, /* [annotation][in] _In_ */ uint cOutputBufferCount, /* [size_is][annotation][out][in] _Inout_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] _MFT_OUTPUT_DATA_BUFFER[] pOutputSample, /* [annotation][out] _Out_ */ out uint pdwStatus);
        
        [PreserveSig]
        new HRESULT SetInputStreamState(/* [annotation][in] _In_ */ uint dwStreamID, /* [annotation][in] _In_ */ IMFMediaType pMediaType, /* [annotation][in] _In_ */ _DeviceStreamState value, /* [annotation][in] _In_ */ uint dwFlags);
        
        [PreserveSig]
        new HRESULT GetInputStreamState(/* [annotation][in] _In_ */ uint dwStreamID, /* [annotation][out] _Out_ */ out _DeviceStreamState value);
        
        [PreserveSig]
        new HRESULT SetOutputStreamState(/* [annotation][in] _In_ */ uint dwStreamID, /* [annotation][in] _In_ */ IMFMediaType pMediaType, /* [annotation][in] _In_ */ _DeviceStreamState value, /* [annotation][in] _In_ */ uint dwFlags);
        
        [PreserveSig]
        new HRESULT GetOutputStreamState(/* [annotation][in] _In_ */ uint dwStreamID, /* [annotation][out] _Out_ */ out _DeviceStreamState value);
        
        [PreserveSig]
        new HRESULT GetInputStreamPreferredState(/* [annotation][in] _In_ */ uint dwStreamID, /* [annotation][out] _Out_ */ out _DeviceStreamState value, /* [annotation][out] _COM_Outptr_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        new HRESULT FlushInputStream(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwFlags);
        
        [PreserveSig]
        new HRESULT FlushOutputStream(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwFlags);
        
        // IMFDeviceTransform2
        [PreserveSig]
        HRESULT GetTransformAttributes(/* [annotation][out] _COM_Outptr_ */ out IMFAttributes ppAttributes);
    }
}
