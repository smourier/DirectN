// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0ec870a6-5d7e-4c22-8cfc-5baae07616ed"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12CommandQueue : ID3D12Pageable
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
        
        // ID3D12CommandQueue
        [PreserveSig]
        void UpdateTileMappings(/* _In_ */ ID3D12Resource pResource, int NumResourceRegions, /* _In_reads_opt_(NumResourceRegions) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D12_TILED_RESOURCE_COORDINATE[] pResourceRegionStartCoordinates, /* _In_reads_opt_(NumResourceRegions) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D12_TILE_REGION_SIZE[] pResourceRegionSizes, /* _In_opt_ */ ID3D12Heap pHeap, int NumRanges, /* _In_reads_opt_(NumRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] D3D12_TILE_RANGE_FLAGS[] pRangeFlags, /* _In_reads_opt_(NumRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] uint[] pHeapRangeStartOffsets, /* _In_reads_opt_(NumRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] uint[] pRangeTileCounts, D3D12_TILE_MAPPING_FLAGS Flags);
        
        [PreserveSig]
        void CopyTileMappings(/* _In_ */ ID3D12Resource pDstResource, /* _In_ */ ref D3D12_TILED_RESOURCE_COORDINATE pDstRegionStartCoordinate, /* _In_ */ ID3D12Resource pSrcResource, /* _In_ */ ref D3D12_TILED_RESOURCE_COORDINATE pSrcRegionStartCoordinate, /* _In_ */ ref D3D12_TILE_REGION_SIZE pRegionSize, D3D12_TILE_MAPPING_FLAGS Flags);
        
        [PreserveSig]
        void ExecuteCommandLists(/* _In_ */ int NumCommandLists, /* _In_reads_(NumCommandLists) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ID3D12CommandList[] ppCommandLists);
        
        [PreserveSig]
        void SetMarker(uint Metadata, /* optional(void) */ IntPtr pData, uint Size);
        
        [PreserveSig]
        void BeginEvent(uint Metadata, /* optional(void) */ IntPtr pData, uint Size);
        
        [PreserveSig]
        void EndEvent();
        
        [PreserveSig]
        HRESULT Signal(ID3D12Fence pFence, ulong Value);
        
        [PreserveSig]
        HRESULT Wait(ID3D12Fence pFence, ulong Value);
        
        [PreserveSig]
        HRESULT GetTimestampFrequency(/* _Out_ */ out ulong pFrequency);
        
        [PreserveSig]
        HRESULT GetClockCalibration(/* _Out_ */ out ulong pGpuTimestamp, /* _Out_ */ out ulong pCpuTimestamp);
        
        [PreserveSig]
        void GetDesc(out D3D12_COMMAND_QUEUE_DESC size);
    }
}
