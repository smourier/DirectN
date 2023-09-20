// generated from <Windows SDK Path>\um\d3d12video.h
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
