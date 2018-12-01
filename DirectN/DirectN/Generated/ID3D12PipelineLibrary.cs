// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(8414,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c64226a8-9201-46af-b4cc-53fb9ff7414f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12PipelineLibrary : ID3D12DeviceChild
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* _Out_writes_bytes_opt_( *pDataSize ) */ [MarshalAs(UnmanagedType.IUnknown)] out object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* _In_reads_bytes_opt_( DataSize ) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        // ID3D12DeviceChild
        [PreserveSig]
        new HRESULT GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDevice);
        
        // ID3D12PipelineLibrary
        [PreserveSig]
        HRESULT StorePipeline(/* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string pName, /* _In_ */ ID3D12PipelineState pPipeline);
        
        [PreserveSig]
        HRESULT LoadGraphicsPipeline(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pName, /* _In_ */ ref D3D12_GRAPHICS_PIPELINE_STATE_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineState);
        
        [PreserveSig]
        HRESULT LoadComputePipeline(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pName, /* _In_ */ ref D3D12_COMPUTE_PIPELINE_STATE_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineState);
        
        [PreserveSig]
        IntPtr GetSerializedSize();
        
        [PreserveSig]
        HRESULT Serialize(/* _Out_writes_(DataSizeInBytes) */ [MarshalAs(UnmanagedType.IUnknown)] out object pData, IntPtr DataSizeInBytes);
    }
}
