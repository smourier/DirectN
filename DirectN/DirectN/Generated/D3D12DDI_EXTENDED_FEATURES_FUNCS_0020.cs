// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_ENABLE_EXTENDED_FEATURE_0020 = System.IntPtr;
using PFND3D12DDI_GET_SUPPORTED_EXTENDED_FEATURE_VERSIONS_0020 = System.IntPtr;
using PFND3D12DDI_GET_SUPPORTED_EXTENDED_FEATURES_0020 = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_EXTENDED_FEATURES_FUNCS_0020
    {
        public IntPtr pfnGetSupportedExtendedFeatures;
        public IntPtr pfnGetSupportedExtendedFeatureVersions;
        public IntPtr pfnEnableExtendedFeature;
    }
}
