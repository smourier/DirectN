// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_SUPPORT_0095
    {
        public bool Use128SuperBlocks;
        public D3D12DDI_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES_0095 TilesConfiguration;
        public D3D12DDI_VIDEO_ENCODER_AV1_FRAME_SUBREGION_LAYOUT_CONFIG_VALIDATION_0095_FLAGS ValidationFlags;
        public uint MinTileRows;
        public uint MaxTileRows;
        public uint MinTileCols;
        public uint MaxTileCols;
        public uint MinTileWidth;
        public uint MaxTileWidth;
        public uint MinTileArea;
        public uint MaxTileArea;
        public uint TileSizeBytesMinus1;
    }
}
