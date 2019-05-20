// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12video.h(1246,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_PROCESS_TRANSFORM
    {
        public tagRECT SourceRectangle;
        public tagRECT DestinationRectangle;
        public D3D12_VIDEO_PROCESS_ORIENTATION Orientation;
    }
}
