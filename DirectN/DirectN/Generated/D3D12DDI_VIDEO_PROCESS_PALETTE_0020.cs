// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(4514,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_PROCESS_PALETTE_0020
    {
        public bool Enable;
        public uint NumEntries;
        public IntPtr pEntries;
    }
}
