// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mftransform.h(678,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d818fbd8-fc46-42f2-87ac-1ea2d1f9bf32"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFDeviceTransform
    {
        [PreserveSig]
        HRESULT InitializeTransform(/* [annotation][in] _In_ */ IMFAttributes pAttributes);
        
        [PreserveSig]
        HRESULT GetInputAvailableType(/* [annotation][in] _In_ */ uint dwInputStreamID, /* [annotation][in] _In_ */ uint dwTypeIndex, /* [annotation][out] _COM_Outptr_ */ out IMFMediaType pMediaType);
        
        [PreserveSig]
        HRESULT GetInputCurrentType(/* [annotation][in] _In_ */ uint dwInputStreamID, /* [annotation][out] _COM_Outptr_ */ out IMFMediaType pMediaType);
        
        [PreserveSig]
        HRESULT GetInputStreamAttributes(/* [annotation][in] _In_ */ uint dwInputStreamID, /* [annotation][out] _COM_Outptr_ */ out IMFAttributes ppAttributes);
        
        [PreserveSig]
        HRESULT GetOutputAvailableType(/* [annotation][in] _In_ */ uint dwOutputStreamID, /* [annotation][in] _In_ */ uint dwTypeIndex, /* [annotation][out] _COM_Outptr_ */ out IMFMediaType pMediaType);
        
        [PreserveSig]
        HRESULT GetOutputCurrentType(/* [annotation][in] _In_ */ uint dwOutputStreamID, /* [annotation][out] _COM_Outptr_ */ out IMFMediaType pMediaType);
        
        [PreserveSig]
        HRESULT GetOutputStreamAttributes(/* [annotation][in] _In_ */ uint dwOutputStreamID, /* [annotation][out] _COM_Outptr_ */ out IMFAttributes ppAttributes);
        
        [PreserveSig]
        HRESULT GetStreamCount(/* [annotation][out] _Out_ */ out uint pcInputStreams, /* [annotation][out] _Out_ */ out uint pcOutputStreams);
        
        [PreserveSig]
        HRESULT GetStreamIDs(/* [annotation][in] _In_ */ uint dwInputIDArraySize, /* [annotation][out] _Out_ */ out uint pdwInputStreamIds, /* [annotation][in] _In_ */ uint dwOutputIDArraySize, /* [annotation][out] _Out_ */ out uint pdwOutputStreamIds);
        
        [PreserveSig]
        HRESULT ProcessEvent(/* [annotation][in] _In_ */ uint dwInputStreamID, /* [annotation][in] _In_ */ IMFMediaEvent pEvent);
        
        [PreserveSig]
        HRESULT ProcessInput(/* [annotation][in] _In_ */ uint dwInputStreamID, /* [annotation][in] _In_ */ IMFSample pSample, /* [annotation][in] _In_ */ uint dwFlags);
        
        [PreserveSig]
        HRESULT ProcessMessage(/* [annotation][in] _In_ */ _MFT_MESSAGE_TYPE eMessage, /* [annotation][in] _In_ */ IntPtr ulParam);
        
        [PreserveSig]
        HRESULT ProcessOutput(/* [annotation][in] _In_ */ uint dwFlags, /* [annotation][in] _In_ */ uint cOutputBufferCount, /* [size_is][annotation][out][in] _Inout_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] _MFT_OUTPUT_DATA_BUFFER[] pOutputSample, /* [annotation][out] _Out_ */ out uint pdwStatus);
        
        [PreserveSig]
        HRESULT SetInputStreamState(/* [annotation][in] _In_ */ uint dwStreamID, /* [annotation][in] _In_ */ IMFMediaType pMediaType, /* [annotation][in] _In_ */ _DeviceStreamState value, /* [annotation][in] _In_ */ uint dwFlags);
        
        [PreserveSig]
        HRESULT GetInputStreamState(/* [annotation][in] _In_ */ uint dwStreamID, /* [annotation][out] _Out_ */ out _DeviceStreamState value);
        
        [PreserveSig]
        HRESULT SetOutputStreamState(/* [annotation][in] _In_ */ uint dwStreamID, /* [annotation][in] _In_ */ IMFMediaType pMediaType, /* [annotation][in] _In_ */ _DeviceStreamState value, /* [annotation][in] _In_ */ uint dwFlags);
        
        [PreserveSig]
        HRESULT GetOutputStreamState(/* [annotation][in] _In_ */ uint dwStreamID, /* [annotation][out] _Out_ */ out _DeviceStreamState value);
        
        [PreserveSig]
        HRESULT GetInputStreamPreferredState(/* [annotation][in] _In_ */ uint dwStreamID, /* [annotation][out] _Out_ */ out _DeviceStreamState value, /* [annotation][out] _COM_Outptr_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        HRESULT FlushInputStream(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwFlags);
        
        [PreserveSig]
        HRESULT FlushOutputStream(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwFlags);
    }
}
