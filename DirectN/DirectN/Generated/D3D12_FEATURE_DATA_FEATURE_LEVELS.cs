// generated from <Windows SDK Path>\um\d3d12.h
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
