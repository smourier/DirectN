// generated from <Windows SDK Path>\um\d3d12video.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_AV1_PICTURE_CONTROL_SUBREGIONS_LAYOUT_DATA_TILES
    {
        public ulong RowCount;
        public ulong ColCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public ulong[] RowHeights;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public ulong[] ColWidths;
        public ulong ContextUpdateTileId;
    }
}
