// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(5375,9)
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
