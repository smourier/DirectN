// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(7747,5)
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;
using SECURITY_ATTRIBUTES = DirectN._SECURITY_ATTRIBUTES;

namespace DirectN
{
    [Guid("189819f1-1db6-4b57-be54-1821339b85f7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Device : ID3D12Object
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* _In_reads_bytes_opt_( DataSize ) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        // ID3D12Device
        [PreserveSig]
        uint GetNodeCount();
        
        [PreserveSig]
        HRESULT CreateCommandQueue(/* _In_ */ ref D3D12_COMMAND_QUEUE_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppCommandQueue);
        
        [PreserveSig]
        HRESULT CreateCommandAllocator(/* _In_ */ D3D12_COMMAND_LIST_TYPE type, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppCommandAllocator);
        
        [PreserveSig]
        HRESULT CreateGraphicsPipelineState(/* _In_ */ ref D3D12_GRAPHICS_PIPELINE_STATE_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineState);
        
        [PreserveSig]
        HRESULT CreateComputePipelineState(/* _In_ */ ref D3D12_COMPUTE_PIPELINE_STATE_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineState);
        
        [PreserveSig]
        HRESULT CreateCommandList(/* _In_ */ uint nodeMask, /* _In_ */ D3D12_COMMAND_LIST_TYPE type, /* _In_ */ ID3D12CommandAllocator pCommandAllocator, /* _In_opt_ */ ID3D12PipelineState pInitialState, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppCommandList);
        
        [PreserveSig]
        HRESULT CheckFeatureSupport(D3D12_FEATURE Feature, /* _Inout_updates_bytes_(FeatureSupportDataSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pFeatureSupportData, uint FeatureSupportDataSize);
        
        [PreserveSig]
        HRESULT CreateDescriptorHeap(/* _In_ */ ref D3D12_DESCRIPTOR_HEAP_DESC pDescriptorHeapDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvHeap);
        
        [PreserveSig]
        uint GetDescriptorHandleIncrementSize(/* _In_ */ D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType);
        
        [PreserveSig]
        HRESULT CreateRootSignature(/* _In_ */ uint nodeMask, /* _In_reads_(blobLengthInBytes) */ [MarshalAs(UnmanagedType.IUnknown)] object pBlobWithRootSignature, /* _In_ */ IntPtr blobLengthInBytes, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvRootSignature);
        
        [PreserveSig]
        void CreateConstantBufferView(/* optional(D3D12_CONSTANT_BUFFER_VIEW_DESC) */ IntPtr pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        void CreateShaderResourceView(/* _In_opt_ */ ID3D12Resource pResource, /* optional(D3D12_SHADER_RESOURCE_VIEW_DESC) */ IntPtr pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        void CreateUnorderedAccessView(/* _In_opt_ */ ID3D12Resource pResource, /* _In_opt_ */ ID3D12Resource pCounterResource, /* optional(D3D12_UNORDERED_ACCESS_VIEW_DESC) */ IntPtr pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        void CreateRenderTargetView(/* _In_opt_ */ ID3D12Resource pResource, /* optional(D3D12_RENDER_TARGET_VIEW_DESC) */ IntPtr pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        void CreateDepthStencilView(/* _In_opt_ */ ID3D12Resource pResource, /* optional(D3D12_DEPTH_STENCIL_VIEW_DESC) */ IntPtr pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        void CreateSampler(/* _In_ */ ref D3D12_SAMPLER_DESC pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        void CopyDescriptors(/* _In_ */ uint NumDestDescriptorRanges, /* _In_reads_(NumDestDescriptorRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_CPU_DESCRIPTOR_HANDLE[] pDestDescriptorRangeStarts, /* _In_reads_opt_(NumDestDescriptorRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pDestDescriptorRangeSizes, /* _In_ */ uint NumSrcDescriptorRanges, /* _In_reads_(NumSrcDescriptorRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D12_CPU_DESCRIPTOR_HANDLE[] pSrcDescriptorRangeStarts, /* _In_reads_opt_(NumSrcDescriptorRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] pSrcDescriptorRangeSizes, /* _In_ */ D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);
        
        [PreserveSig]
        void CopyDescriptorsSimple(/* _In_ */ uint NumDescriptors, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, /* _In_ */ D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);
        
        [PreserveSig]
        D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo(/* _In_ */ uint visibleMask, /* _In_ */ uint numResourceDescs, /* _In_reads_(numResourceDescs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D12_RESOURCE_DESC[] pResourceDescs);
        
        [PreserveSig]
        D3D12_HEAP_PROPERTIES GetCustomHeapProperties(/* _In_ */ uint nodeMask, D3D12_HEAP_TYPE heapType);
        
        [PreserveSig]
        HRESULT CreateCommittedResource(/* _In_ */ ref D3D12_HEAP_PROPERTIES pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, /* _In_ */ ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialResourceState, /* optional(D3D12_CLEAR_VALUE) */ IntPtr pOptimizedClearValue, [MarshalAs(UnmanagedType.LPStruct)] Guid riidResource, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource);
        
        [PreserveSig]
        HRESULT CreateHeap(/* _In_ */ ref D3D12_HEAP_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvHeap);
        
        [PreserveSig]
        HRESULT CreatePlacedResource(/* _In_ */ ID3D12Heap pHeap, ulong HeapOffset, /* _In_ */ ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialState, /* optional(D3D12_CLEAR_VALUE) */ IntPtr pOptimizedClearValue, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource);
        
        [PreserveSig]
        HRESULT CreateReservedResource(/* _In_ */ ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialState, /* optional(D3D12_CLEAR_VALUE) */ IntPtr pOptimizedClearValue, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource);
        
        [PreserveSig]
        HRESULT CreateSharedHandle(/* _In_ */ ID3D12DeviceChild pObject, /* optional(SECURITY_ATTRIBUTES) */ IntPtr pAttributes, uint Access, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name, /* _Out_ */ out IntPtr pHandle);
        
        [PreserveSig]
        HRESULT OpenSharedHandle(/* _In_ */ IntPtr NTHandle, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);
        
        [PreserveSig]
        HRESULT OpenSharedHandleByName(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name, uint Access, /* [annotation][out] _Out_ */ out IntPtr pNTHandle);
        
        [PreserveSig]
        HRESULT MakeResident(uint NumObjects, /* _In_reads_(NumObjects) */ out IntPtr ppObjects);
        
        [PreserveSig]
        HRESULT Evict(uint NumObjects, /* _In_reads_(NumObjects) */ out IntPtr ppObjects);
        
        [PreserveSig]
        HRESULT CreateFence(ulong InitialValue, D3D12_FENCE_FLAGS Flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppFence);
        
        [PreserveSig]
        HRESULT GetDeviceRemovedReason();
        
        [PreserveSig]
        void GetCopyableFootprints(/* _In_ */ ref D3D12_RESOURCE_DESC pResourceDesc, /* _In_range_(0,D3D12_REQ_SUBRESOURCES) */ uint FirstSubresource, /* _In_range_(0,D3D12_REQ_SUBRESOURCES-FirstSubresource) */ uint NumSubresources, ulong BaseOffset, /* _Out_writes_opt_(NumSubresources) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D12_PLACED_SUBRESOURCE_FOOTPRINT[] pLayouts, /* _Out_writes_opt_(NumSubresources) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] pNumRows, /* _Out_writes_opt_(NumSubresources) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ulong[] pRowSizeInBytes, /* _Out_opt_ */ out ulong pTotalBytes);
        
        [PreserveSig]
        HRESULT CreateQueryHeap(/* _In_ */ ref D3D12_QUERY_HEAP_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvHeap);
        
        [PreserveSig]
        HRESULT SetStablePowerState(bool Enable);
        
        [PreserveSig]
        HRESULT CreateCommandSignature(/* _In_ */ ref D3D12_COMMAND_SIGNATURE_DESC pDesc, /* _In_opt_ */ ID3D12RootSignature pRootSignature, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvCommandSignature);
        
        [PreserveSig]
        void GetResourceTiling(/* _In_ */ ID3D12Resource pTiledResource, /* _Out_opt_ */ out uint pNumTilesForEntireResource, /* _Out_opt_ */ out D3D12_PACKED_MIP_INFO pPackedMipDesc, /* _Out_opt_ */ out D3D12_TILE_SHAPE pStandardTileShapeForNonPackedMips, /* optional(UINT) */ IntPtr pNumSubresourceTilings, /* _In_ */ uint FirstSubresourceTilingToGet, /* _Out_writes_(*pNumSubresourceTilings) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D12_SUBRESOURCE_TILING[] pSubresourceTilingsForNonPackedMips);
        
        [PreserveSig]
        LUID GetAdapterLuid();
    }
}
