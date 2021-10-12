// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(12708,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_VIDEO_ENCODER_RATE_CONTROL_0080_2
    {
        public D3D12DDI_VIDEO_ENCODER_RATE_CONTROL_MODE_0080 Mode;
        public D3D12DDI_VIDEO_ENCODER_RATE_CONTROL_FLAGS_0080 Flags;
        public D3D12DDI_VIDEO_ENCODER_RATE_CONTROL_CONFIGURATION_PARAMS_0080_2 ConfigParams;
        public DXGI_RATIONAL TargetFrameRate;
    }
}
