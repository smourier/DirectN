// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(2150,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_MULTISAMPLE_QUALITY_LEVELS
    {
        public DXGI_FORMAT Format;
        public uint SampleCount;
        public D3D12_MULTISAMPLE_QUALITY_LEVEL_FLAGS Flags;
        public uint NumQualityLevels;
    }
}
