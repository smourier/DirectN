// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12video.h(4602,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("db525ae4-6ad6-473c-baa7-59b2e37082e4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VideoProcessCommandList2 : ID3D12VideoProcessCommandList1
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
        
        // ID3D12CommandList
        [PreserveSig]
        new D3D12_COMMAND_LIST_TYPE GetType();
        
        // ID3D12VideoProcessCommandList
        [PreserveSig]
        new HRESULT Close();
        
        [PreserveSig]
        new HRESULT Reset(/* _In_ */ ID3D12CommandAllocator pAllocator);
        
        [PreserveSig]
        new void ClearState();
        
        [PreserveSig]
        new void ResourceBarrier(/* _In_ */ int NumBarriers, /* _In_reads_(NumBarriers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_RESOURCE_BARRIER[] pBarriers);
        
        [PreserveSig]
        new void DiscardResource(/* _In_ */ ID3D12Resource pResource, /* optional(D3D12_DISCARD_REGION) */ IntPtr pRegion);
        
        [PreserveSig]
        new void BeginQuery(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint Index);
        
        [PreserveSig]
        new void EndQuery(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint Index);
        
        [PreserveSig]
        new void ResolveQueryData(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint StartIndex, /* _In_ */ uint NumQueries, /* _In_ */ ID3D12Resource pDestinationBuffer, /* _In_ */ ulong AlignedDestinationBufferOffset);
        
        [PreserveSig]
        new void SetPredication(/* _In_opt_ */ ID3D12Resource pBuffer, /* _In_ */ ulong AlignedBufferOffset, /* _In_ */ D3D12_PREDICATION_OP Operation);
        
        [PreserveSig]
        new void SetMarker(uint Metadata, /* optional(void) */ IntPtr pData, uint Size);
        
        [PreserveSig]
        new void BeginEvent(uint Metadata, /* optional(void) */ IntPtr pData, uint Size);
        
        [PreserveSig]
        new void EndEvent();
        
        [PreserveSig]
        new void ProcessFrames(/* _In_ */ ID3D12VideoProcessor pVideoProcessor, /* _In_ */ ref D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS pOutputArguments, int NumInputStreams, /* _In_reads_(NumInputStreams) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS[] pInputArguments);
        
        [PreserveSig]
        new void WriteBufferImmediate(int Count, /* _In_reads_(Count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_WRITEBUFFERIMMEDIATE_PARAMETER[] pParams, /* _In_reads_opt_(Count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_WRITEBUFFERIMMEDIATE_MODE[] pModes);
        
        // ID3D12VideoProcessCommandList1
        [PreserveSig]
        new void ProcessFrames1(/* _In_ */ ID3D12VideoProcessor pVideoProcessor, /* _In_ */ ref D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS pOutputArguments, int NumInputStreams, /* _In_reads_(NumInputStreams) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D12_VIDEO_PROCESS_INPUT_STREAM_ARGUMENTS1[] pInputArguments);
        
        // ID3D12VideoProcessCommandList2
        [PreserveSig]
        void SetProtectedResourceSession(/* _In_opt_ */ ID3D12ProtectedResourceSession pProtectedResourceSession);
        
        [PreserveSig]
        void InitializeExtensionCommand(/* _In_ */ ID3D12VideoExtensionCommand pExtensionCommand, /* _In_reads_bytes_(InitializationParametersSizeInBytes) */ IntPtr pInitializationParameters, IntPtr InitializationParametersSizeInBytes);
        
        [PreserveSig]
        void ExecuteExtensionCommand(/* _In_ */ ID3D12VideoExtensionCommand pExtensionCommand, /* _In_reads_bytes_(ExecutionParametersSizeInBytes) */ IntPtr pExecutionParameters, IntPtr ExecutionParametersSizeInBytes);
    }
}
