// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2e0d212d-8df9-44a6-a770-bb289b182737"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VideoEncoder : ID3D12Pageable
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        // ID3D12DeviceChild
        [PreserveSig]
        new HRESULT GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDevice);
        
        // ID3D12Pageable
        
        // ID3D12VideoEncoder
        [PreserveSig]
        uint GetNodeMask();
        
        [PreserveSig]
        D3D12_VIDEO_ENCODER_FLAGS GetEncoderFlags();
        
        [PreserveSig]
        D3D12_VIDEO_ENCODER_CODEC GetCodec();
        
        [PreserveSig]
        HRESULT GetCodecProfile(/* _Inout_ */ D3D12_VIDEO_ENCODER_PROFILE_DESC dstProfile);
        
        [PreserveSig]
        HRESULT GetCodecConfiguration(/* _Inout_ */ D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION dstCodecConfig);
        
        [PreserveSig]
        DXGI_FORMAT GetInputFormat();
        
        [PreserveSig]
        D3D12_VIDEO_ENCODER_MOTION_ESTIMATION_PRECISION_MODE GetMaxMotionEstimationPrecision();
    }
}
