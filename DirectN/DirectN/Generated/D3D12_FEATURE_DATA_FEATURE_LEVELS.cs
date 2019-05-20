// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12.h(2163,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_FEATURE_DATA_FEATURE_LEVELS
    {
        public uint NumFeatureLevels;
        public IntPtr pFeatureLevelsRequested;
        public D3D_FEATURE_LEVEL MaxSupportedFeatureLevel;
    }
}
