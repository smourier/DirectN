// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(12357,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8b4f173b-2fea-4b80-8f58-4307191ab95d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12Device5 : ID3D12Device4
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* _Out_writes_bytes_opt_( *pDataSize ) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* _In_reads_bytes_opt_( DataSize ) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);
        
        // ID3D12Device
        [PreserveSig]
        new uint GetNodeCount();
        
        [PreserveSig]
        new HRESULT CreateCommandQueue(/* _In_ */ ref D3D12_COMMAND_QUEUE_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppCommandQueue);
        
        [PreserveSig]
        new HRESULT CreateCommandAllocator(/* _In_ */ D3D12_COMMAND_LIST_TYPE type, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppCommandAllocator);
        
        [PreserveSig]
        new HRESULT CreateGraphicsPipelineState(/* _In_ */ ref D3D12_GRAPHICS_PIPELINE_STATE_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineState);
        
        [PreserveSig]
        new HRESULT CreateComputePipelineState(/* _In_ */ ref D3D12_COMPUTE_PIPELINE_STATE_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineState);
        
        [PreserveSig]
        new HRESULT CreateCommandList(/* _In_ */ uint nodeMask, /* _In_ */ D3D12_COMMAND_LIST_TYPE type, /* _In_ */ ID3D12CommandAllocator pCommandAllocator, /* _In_opt_ */ ID3D12PipelineState pInitialState, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppCommandList);
        
        [PreserveSig]
        new HRESULT CheckFeatureSupport(D3D12_FEATURE Feature, /* _Inout_updates_bytes_(FeatureSupportDataSize) */ out IntPtr pFeatureSupportData, uint FeatureSupportDataSize);
        
        [PreserveSig]
        new HRESULT CreateDescriptorHeap(/* _In_ */ ref D3D12_DESCRIPTOR_HEAP_DESC pDescriptorHeapDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvHeap);
        
        [PreserveSig]
        new uint GetDescriptorHandleIncrementSize(/* _In_ */ D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType);
        
        [PreserveSig]
        new HRESULT CreateRootSignature(/* _In_ */ uint nodeMask, /* _In_reads_(blobLengthInBytes) */ out IntPtr pBlobWithRootSignature, /* _In_ */ ulong blobLengthInBytes, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvRootSignature);
        
        [PreserveSig]
        new void CreateConstantBufferView(/* _In_opt_ */ ref D3D12_CONSTANT_BUFFER_VIEW_DESC pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        new void CreateShaderResourceView(/* _In_opt_ */ ID3D12Resource pResource, /* _In_opt_ */ ref D3D12_SHADER_RESOURCE_VIEW_DESC pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        new void CreateUnorderedAccessView(/* _In_opt_ */ ID3D12Resource pResource, /* _In_opt_ */ ID3D12Resource pCounterResource, /* _In_opt_ */ ref D3D12_UNORDERED_ACCESS_VIEW_DESC pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        new void CreateRenderTargetView(/* _In_opt_ */ ID3D12Resource pResource, /* _In_opt_ */ ref D3D12_RENDER_TARGET_VIEW_DESC pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        new void CreateDepthStencilView(/* _In_opt_ */ ID3D12Resource pResource, /* _In_opt_ */ ref D3D12_DEPTH_STENCIL_VIEW_DESC pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        new void CreateSampler(/* _In_ */ ref D3D12_SAMPLER_DESC pDesc, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor);
        
        [PreserveSig]
        new void CopyDescriptors(/* _In_ */ uint NumDestDescriptorRanges, /* _In_reads_(NumDestDescriptorRanges) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_CPU_DESCRIPTOR_HANDLE[] pDestDescriptorRangeStarts, /* _In_reads_opt_(NumDestDescriptorRanges) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pDestDescriptorRangeSizes, /* _In_ */ uint NumSrcDescriptorRanges, /* _In_reads_(NumSrcDescriptorRanges) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D12_CPU_DESCRIPTOR_HANDLE[] pSrcDescriptorRangeStarts, /* _In_reads_opt_(NumSrcDescriptorRanges) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] uint[] pSrcDescriptorRangeSizes, /* _In_ */ D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);
        
        [PreserveSig]
        new void CopyDescriptorsSimple(/* _In_ */ uint NumDescriptors, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart, /* _In_ */ D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType);
        
        [PreserveSig]
        new D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo(/* _In_ */ uint visibleMask, /* _In_ */ uint numResourceDescs, /* _In_reads_(numResourceDescs) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D12_RESOURCE_DESC[] pResourceDescs);
        
        [PreserveSig]
        new D3D12_HEAP_PROPERTIES GetCustomHeapProperties(/* _In_ */ uint nodeMask, D3D12_HEAP_TYPE heapType);
        
        [PreserveSig]
        new HRESULT CreateCommittedResource(/* _In_ */ ref D3D12_HEAP_PROPERTIES pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, /* _In_ */ ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialResourceState, /* _In_opt_ */ ref D3D12_CLEAR_VALUE pOptimizedClearValue, [MarshalAs(UnmanagedType.LPStruct)] Guid riidResource, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource);
        
        [PreserveSig]
        new HRESULT CreateHeap(/* _In_ */ ref D3D12_HEAP_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvHeap);
        
        [PreserveSig]
        new HRESULT CreatePlacedResource(/* _In_ */ ID3D12Heap pHeap, ulong HeapOffset, /* _In_ */ ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialState, /* _In_opt_ */ ref D3D12_CLEAR_VALUE pOptimizedClearValue, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource);
        
        [PreserveSig]
        new HRESULT CreateReservedResource(/* _In_ */ ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialState, /* _In_opt_ */ ref D3D12_CLEAR_VALUE pOptimizedClearValue, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource);
        
        [PreserveSig]
        new HRESULT CreateSharedHandle(/* _In_ */ ID3D12DeviceChild pObject, /* _In_opt_ */ ref _SECURITY_ATTRIBUTES pAttributes, uint Access, /* _In_opt_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name, /* _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object pHandle);
        
        [PreserveSig]
        new HRESULT OpenSharedHandle(/* _In_ */ IntPtr NTHandle, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);
        
        [PreserveSig]
        new HRESULT OpenSharedHandleByName(/* _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name, uint Access, /* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object pNTHandle);
        
        [PreserveSig]
        new HRESULT MakeResident(uint NumObjects, /* _In_reads_(NumObjects) */ out ID3D12Pageable[] ppObjects);
        
        [PreserveSig]
        new HRESULT Evict(uint NumObjects, /* _In_reads_(NumObjects) */ out ID3D12Pageable[] ppObjects);
        
        [PreserveSig]
        new HRESULT CreateFence(ulong InitialValue, D3D12_FENCE_FLAGS Flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppFence);
        
        [PreserveSig]
        new HRESULT GetDeviceRemovedReason();
        
        [PreserveSig]
        new void GetCopyableFootprints(/* _In_ */ ref D3D12_RESOURCE_DESC pResourceDesc, /* _In_range_(0,D3D12_REQ_SUBRESOURCES) */ uint FirstSubresource, /* _In_range_(0,D3D12_REQ_SUBRESOURCES-FirstSubresource) */ uint NumSubresources, ulong BaseOffset, /* _Out_writes_opt_(NumSubresources) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D12_PLACED_SUBRESOURCE_FOOTPRINT[] pLayouts, /* _Out_writes_opt_(NumSubresources) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] pNumRows, /* _Out_writes_opt_(NumSubresources) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ulong[] pRowSizeInBytes, /* _Out_opt_ */ out ulong pTotalBytes);
        
        [PreserveSig]
        new HRESULT CreateQueryHeap(/* _In_ */ ref D3D12_QUERY_HEAP_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvHeap);
        
        [PreserveSig]
        new HRESULT SetStablePowerState(bool Enable);
        
        [PreserveSig]
        new HRESULT CreateCommandSignature(/* _In_ */ ref D3D12_COMMAND_SIGNATURE_DESC pDesc, /* _In_opt_ */ ID3D12RootSignature pRootSignature, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvCommandSignature);
        
        [PreserveSig]
        new void GetResourceTiling(/* _In_ */ ID3D12Resource pTiledResource, /* _Out_opt_ */ out uint pNumTilesForEntireResource, /* _Out_opt_ */ out D3D12_PACKED_MIP_INFO pPackedMipDesc, /* _Out_opt_ */ out D3D12_TILE_SHAPE pStandardTileShapeForNonPackedMips, /* _Inout_opt_ */ ref uint pNumSubresourceTilings, /* _In_ */ uint FirstSubresourceTilingToGet, /* _Out_writes_(*pNumSubresourceTilings) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D12_SUBRESOURCE_TILING[] pSubresourceTilingsForNonPackedMips);
        
        [PreserveSig]
        new _LUID GetAdapterLuid();
        
        // ID3D12Device1
        [PreserveSig]
        new HRESULT CreatePipelineLibrary(/* _In_reads_(BlobLength) */ out IntPtr pLibraryBlob, ulong BlobLength, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineLibrary);
        
        [PreserveSig]
        new HRESULT SetEventOnMultipleFenceCompletion(/* _In_reads_(NumFences) */ out ID3D12Fence[] ppFences, /* _In_reads_(NumFences) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ulong[] pFenceValues, uint NumFences, D3D12_MULTIPLE_FENCE_WAIT_FLAGS Flags, IntPtr hEvent);
        
        [PreserveSig]
        new HRESULT SetResidencyPriority(uint NumObjects, /* _In_reads_(NumObjects) */ out ID3D12Pageable[] ppObjects, /* _In_reads_(NumObjects) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_RESIDENCY_PRIORITY[] pPriorities);
        
        // ID3D12Device2
        [PreserveSig]
        new HRESULT CreatePipelineState(ref D3D12_PIPELINE_STATE_STREAM_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppPipelineState);
        
        // ID3D12Device3
        [PreserveSig]
        new HRESULT OpenExistingHeapFromAddress(/* _In_ */ IntPtr pAddress, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvHeap);
        
        [PreserveSig]
        new HRESULT OpenExistingHeapFromFileMapping(/* _In_ */ IntPtr hFileMapping, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvHeap);
        
        [PreserveSig]
        new HRESULT EnqueueMakeResident(D3D12_RESIDENCY_FLAGS Flags, uint NumObjects, /* _In_reads_(NumObjects) */ out ID3D12Pageable[] ppObjects, /* _In_ */ ID3D12Fence pFenceToSignal, ulong FenceValueToSignal);
        
        // ID3D12Device4
        [PreserveSig]
        new HRESULT CreateCommandList1(/* _In_ */ uint nodeMask, /* _In_ */ D3D12_COMMAND_LIST_TYPE type, /* _In_ */ D3D12_COMMAND_LIST_FLAGS flags, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppCommandList);
        
        [PreserveSig]
        new HRESULT CreateProtectedResourceSession(/* _In_ */ ref D3D12_PROTECTED_RESOURCE_SESSION_DESC pDesc, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppSession);
        
        [PreserveSig]
        new HRESULT CreateCommittedResource1(/* _In_ */ ref D3D12_HEAP_PROPERTIES pHeapProperties, D3D12_HEAP_FLAGS HeapFlags, /* _In_ */ ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialResourceState, /* _In_opt_ */ ref D3D12_CLEAR_VALUE pOptimizedClearValue, /* _In_opt_ */ ID3D12ProtectedResourceSession pProtectedSession, [MarshalAs(UnmanagedType.LPStruct)] Guid riidResource, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource);
        
        [PreserveSig]
        new HRESULT CreateHeap1(/* _In_ */ ref D3D12_HEAP_DESC pDesc, /* _In_opt_ */ ID3D12ProtectedResourceSession pProtectedSession, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvHeap);
        
        [PreserveSig]
        new HRESULT CreateReservedResource1(/* _In_ */ ref D3D12_RESOURCE_DESC pDesc, D3D12_RESOURCE_STATES InitialState, /* _In_opt_ */ ref D3D12_CLEAR_VALUE pOptimizedClearValue, /* _In_opt_ */ ID3D12ProtectedResourceSession pProtectedSession, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvResource);
        
        [PreserveSig]
        new D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo1(uint visibleMask, uint numResourceDescs, /* _In_reads_(numResourceDescs) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D12_RESOURCE_DESC[] pResourceDescs, /* _Out_writes_opt_(numResourceDescs) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D12_RESOURCE_ALLOCATION_INFO1[] pResourceAllocationInfo1);
        
        // ID3D12Device5
        [PreserveSig]
        HRESULT CreateLifetimeTracker(/* _In_ */ ID3D12LifetimeOwner pOwner, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvTracker);
        
        [PreserveSig]
        void RemoveDevice();
        
        [PreserveSig]
        HRESULT EnumerateMetaCommands(/* _Inout_ */ ref uint pNumMetaCommands, /* _Out_writes_opt_(*pNumMetaCommands) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_META_COMMAND_DESC[] pDescs);
        
        [PreserveSig]
        HRESULT EnumerateMetaCommandParameters(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid CommandId, /* _In_ */ D3D12_META_COMMAND_PARAMETER_STAGE Stage, /* _Out_opt_ */ out uint pTotalStructureSizeInBytes, /* _Inout_ */ ref uint pParameterCount, /* _Out_writes_opt_(*pParameterCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D12_META_COMMAND_PARAMETER_DESC[] pParameterDescs);
        
        [PreserveSig]
        HRESULT CreateMetaCommand(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid CommandId, /* _In_ */ uint NodeMask, /* _In_reads_bytes_opt_(CreationParametersDataSizeInBytes) */ out IntPtr pCreationParametersData, /* _In_ */ ulong CreationParametersDataSizeInBytes, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppMetaCommand);
        
        [PreserveSig]
        HRESULT CreateStateObject(ref D3D12_STATE_OBJECT_DESC pDesc, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppStateObject);
        
        [PreserveSig]
        void GetRaytracingAccelerationStructurePrebuildInfo(/* _In_ */ ref D3D12_BUILD_RAYTRACING_ACCELERATION_STRUCTURE_INPUTS pDesc, /* _Out_ */ out D3D12_RAYTRACING_ACCELERATION_STRUCTURE_PREBUILD_INFO pInfo);
        
        [PreserveSig]
        D3D12_DRIVER_MATCHING_IDENTIFIER_STATUS CheckDriverMatchingIdentifier(/* _In_ */ D3D12_SERIALIZED_DATA_TYPE SerializedDataType, /* _In_ */ ref D3D12_SERIALIZED_DATA_DRIVER_MATCHING_IDENTIFIER pIdentifierToCheck);
    }
}
