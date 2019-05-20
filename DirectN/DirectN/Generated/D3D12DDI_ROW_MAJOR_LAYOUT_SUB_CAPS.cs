// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(259,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_ROW_MAJOR_LAYOUT_SUB_CAPS
    {
        public ushort MaxElementSize;
        public ushort BaseOffsetAlignment;
        public ushort PitchAlignment;
        public ushort DepthPitchAlignment;
    }
}
