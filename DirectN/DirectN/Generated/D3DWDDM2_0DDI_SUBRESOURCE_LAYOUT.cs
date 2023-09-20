// generated from <Windows SDK Path>\um\d3d10umddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDI_SUBRESOURCE_LAYOUT
    {
        public ulong BaseOffset;
        public D3DWDDM2_0DDI_SUBRESOURCE_PRESWIZZLE_OFFSETS PreswizzleOffsets;
        public ulong RowPitch;
        public ulong DepthPitch;
    }
}
