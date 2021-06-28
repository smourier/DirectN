// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12video.h(1047,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("304fdb32-bede-410a-8545-943ac6a46138"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VideoProcessor : ID3D12Pageable
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
        
        // ID3D12VideoProcessor
        [PreserveSig]
        uint GetNodeMask();
        
        [PreserveSig]
        uint GetNumInputStreamDescs();
        
        [PreserveSig]
        HRESULT GetInputStreamDescs(int NumInputStreamDescs, /* _Out_writes_(NumInputStreamDescs) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC[] pInputStreamDescs);
        
        [PreserveSig]
        void GetOutputStreamDesc(out D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC size);
    }
}
