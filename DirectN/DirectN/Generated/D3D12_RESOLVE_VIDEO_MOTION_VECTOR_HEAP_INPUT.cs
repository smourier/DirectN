// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12video.h(3043,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT
    {
        public IntPtr pMotionVectorHeap;
        public uint PixelWidth;
        public uint PixelHeight;
    }
}
