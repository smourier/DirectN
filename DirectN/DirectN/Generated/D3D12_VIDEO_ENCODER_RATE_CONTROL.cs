// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(5624,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL
    {
        public D3D12_VIDEO_ENCODER_RATE_CONTROL_MODE Mode;
        public D3D12_VIDEO_ENCODER_RATE_CONTROL_FLAGS Flags;
        public D3D12_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS ConfigParams;
        public DXGI_RATIONAL TargetFrameRate;
    }
}
