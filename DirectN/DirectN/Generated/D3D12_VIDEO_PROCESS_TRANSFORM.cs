// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12video.h(1215,9)
using System.Runtime.InteropServices;
using D3D12_RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_PROCESS_TRANSFORM
    {
        public D3D12_RECT SourceRectangle;
        public D3D12_RECT DestinationRectangle;
        public D3D12_VIDEO_PROCESS_ORIENTATION Orientation;
    }
}
