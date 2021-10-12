// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(6407,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("22b35d96-876a-44c0-b25e-fb8c9c7f1c4a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VideoEncoderHeap : ID3D12Pageable
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
        
        // ID3D12VideoEncoderHeap
        [PreserveSig]
        uint GetNodeMask();
        
        [PreserveSig]
        D3D12_VIDEO_ENCODER_HEAP_FLAGS GetEncoderHeapFlags();
        
        [PreserveSig]
        D3D12_VIDEO_ENCODER_CODEC GetCodec();
        
        [PreserveSig]
        HRESULT GetCodecProfile(/* _Out_ */ D3D12_VIDEO_ENCODER_PROFILE_DESC dstProfile);
        
        [PreserveSig]
        HRESULT GetCodecLevel(/* _Out_ */ D3D12_VIDEO_ENCODER_LEVEL_SETTING dstLevel);
        
        [PreserveSig]
        uint GetResolutionListCount();
        
        [PreserveSig]
        HRESULT GetResolutionList(int ResolutionsListCount, /* _Out_writes_(ResolutionsListCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC[] pResolutionList);
    }
}
