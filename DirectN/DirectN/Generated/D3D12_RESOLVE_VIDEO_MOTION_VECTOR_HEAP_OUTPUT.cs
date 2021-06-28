// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d12video.h(3037,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_OUTPUT
    {
        public IntPtr pMotionVectorTexture2D;
        public D3D12_RESOURCE_COORDINATE MotionVectorCoordinate;
    }
}
