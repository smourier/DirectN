// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12.h(8774,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("80eabf42-2568-4e5e-bd82-c37f86961dc3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12PipelineLibrary1 : ID3D12PipelineLibrary
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
        
        // ID3D12PipelineLibrary
        [PreserveSig]
        new HRESULT StorePipeline(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pName, /* _In_ */ ID3D12PipelineState pPipeline);
        
        [PreserveSig]
        new HRESULT LoadGraphicsPipeline(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pName, /* _In_ */ ref D3D12_GRAPHICS_PIPELINE_STATE_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineState);
        
        [PreserveSig]
        new HRESULT LoadComputePipeline(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pName, /* _In_ */ ref D3D12_COMPUTE_PIPELINE_STATE_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineState);
        
        [PreserveSig]
        new IntPtr GetSerializedSize();
        
        [PreserveSig]
        new HRESULT Serialize(/* _Out_writes_(DataSizeInBytes) */ IntPtr pData, IntPtr DataSizeInBytes);
        
        // ID3D12PipelineLibrary1
        [PreserveSig]
        HRESULT LoadPipeline(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pName, /* _In_ */ ref D3D12_PIPELINE_STATE_STREAM_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineState);
    }
}
