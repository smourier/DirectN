// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(2144,5)
using System;
using System.Runtime.InteropServices;
using D3D11_RECT = DirectN.tagRECT;

namespace DirectN
{
    [Guid("b4e3c01d-e79e-4637-91b2-510e9f4c9b8f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11DeviceContext3 : ID3D11DeviceContext2
    {
        // ID3D11DeviceContext1
        [PreserveSig]
        new void CopySubresourceRegion1(/* [annotation] _In_ */ ref ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* [annotation] _In_ */ uint DstX, /* [annotation] _In_ */ uint DstY, /* [annotation] _In_ */ uint DstZ, /* [annotation] _In_ */ ref ID3D11Resource pSrcResource, /* [annotation] _In_ */ uint SrcSubresource, /* optional(D3D11_BOX) */ IntPtr pSrcBox, /* [annotation] _In_ */ uint CopyFlags);
        
        [PreserveSig]
        new void UpdateSubresource1(/* [annotation] _In_ */ ref ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* optional(D3D11_BOX) */ IntPtr pDstBox, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pSrcData, /* [annotation] _In_ */ uint SrcRowPitch, /* [annotation] _In_ */ uint SrcDepthPitch, /* [annotation] _In_ */ uint CopyFlags);
        
        [PreserveSig]
        new void DiscardResource(/* [annotation] _In_ */ ref ID3D11Resource pResource);
        
        [PreserveSig]
        new void DiscardView(/* [annotation] _In_ */ ref ID3D11View pResourceView);
        
        [PreserveSig]
        new void VSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void HSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void DSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void GSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void PSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void CSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void VSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void HSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void DSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void GSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void PSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void CSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void SwapDeviceContextState(/* [annotation] _In_ */ ref ID3DDeviceContextState pState, /* optional(ID3DDeviceContextState) */ out IntPtr ppPreviousState);
        
        [PreserveSig]
        new void ClearView(/* [annotation] _In_ */ ref ID3D11View pView, /* [annotation] _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] Color, /* [annotation] _In_reads_opt_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D11_RECT[] pRect, uint NumRects);
        
        [PreserveSig]
        new void DiscardView1(/* [annotation] _In_ */ ref ID3D11View pResourceView, /* [annotation] _In_reads_opt_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D11_RECT[] pRects, uint NumRects);
        
        // ID3D11DeviceContext2
        [PreserveSig]
        new HRESULT UpdateTileMappings(/* [annotation] _In_ */ ref ID3D11Resource pTiledResource, /* [annotation] _In_ */ uint NumTiledResourceRegions, /* [annotation] _In_reads_opt_(NumTiledResourceRegions) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D11_TILED_RESOURCE_COORDINATE[] pTiledResourceRegionStartCoordinates, /* [annotation] _In_reads_opt_(NumTiledResourceRegions) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D11_TILE_REGION_SIZE[] pTiledResourceRegionSizes, /* optional(ID3D11Buffer) */ IntPtr pTilePool, /* [annotation] _In_ */ uint NumRanges, /* [annotation] _In_reads_opt_(NumRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] uint[] pRangeFlags, /* [annotation] _In_reads_opt_(NumRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] uint[] pTilePoolStartOffsets, /* [annotation] _In_reads_opt_(NumRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] uint[] pRangeTileCounts, /* [annotation] _In_ */ uint Flags);
        
        [PreserveSig]
        new HRESULT CopyTileMappings(/* [annotation] _In_ */ ref ID3D11Resource pDestTiledResource, /* [annotation] _In_ */ ref D3D11_TILED_RESOURCE_COORDINATE pDestRegionStartCoordinate, /* [annotation] _In_ */ ref ID3D11Resource pSourceTiledResource, /* [annotation] _In_ */ ref D3D11_TILED_RESOURCE_COORDINATE pSourceRegionStartCoordinate, /* [annotation] _In_ */ ref D3D11_TILE_REGION_SIZE pTileRegionSize, /* [annotation] _In_ */ uint Flags);
        
        [PreserveSig]
        new void CopyTiles(/* [annotation] _In_ */ ref ID3D11Resource pTiledResource, /* [annotation] _In_ */ ref D3D11_TILED_RESOURCE_COORDINATE pTileRegionStartCoordinate, /* [annotation] _In_ */ ref D3D11_TILE_REGION_SIZE pTileRegionSize, /* [annotation] _In_ */ ref ID3D11Buffer pBuffer, /* [annotation] _In_ */ ulong BufferStartOffsetInBytes, /* [annotation] _In_ */ uint Flags);
        
        [PreserveSig]
        new void UpdateTiles(/* [annotation] _In_ */ ref ID3D11Resource pDestTiledResource, /* [annotation] _In_ */ ref D3D11_TILED_RESOURCE_COORDINATE pDestTileRegionStartCoordinate, /* [annotation] _In_ */ ref D3D11_TILE_REGION_SIZE pDestTileRegionSize, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pSourceTileData, /* [annotation] _In_ */ uint Flags);
        
        [PreserveSig]
        new HRESULT ResizeTilePool(/* [annotation] _In_ */ ref ID3D11Buffer pTilePool, /* [annotation] _In_ */ ulong NewSizeInBytes);
        
        [PreserveSig]
        new void TiledResourceBarrier(/* optional(ID3D11DeviceChild) */ IntPtr pTiledResourceOrViewAccessBeforeBarrier, /* optional(ID3D11DeviceChild) */ IntPtr pTiledResourceOrViewAccessAfterBarrier);
        
        [PreserveSig]
        new bool IsAnnotationEnabled();
        
        [PreserveSig]
        new void SetMarkerInt(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pLabel, int Data);
        
        [PreserveSig]
        new void BeginEventInt(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pLabel, int Data);
        
        [PreserveSig]
        new void EndEvent();
        
        // ID3D11DeviceContext3
        [PreserveSig]
        void Flush1(D3D11_CONTEXT_TYPE ContextType, /* optional(HANDLE) */ IntPtr hEvent);
        
        [PreserveSig]
        void SetHardwareProtectionState(/* [annotation] _In_ */ bool HwProtectionEnable);
        
        [PreserveSig]
        void GetHardwareProtectionState(/* [annotation] _Out_ */ out bool pHwProtectionEnable);
    }
}
