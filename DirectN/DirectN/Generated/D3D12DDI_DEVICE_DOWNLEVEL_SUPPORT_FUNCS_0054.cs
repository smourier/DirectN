// generated from <Windows SDK Path>\um\d3d12umddi.h
using System;
using System.Runtime.InteropServices;
using PFND3D12DDI_QUERY_CLOCK_CALIBRATION_0054 = System.IntPtr;
using PFND3D12DDI_QUERY_VIDEO_MEMORY_INFO_0054 = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12DDI_DEVICE_DOWNLEVEL_SUPPORT_FUNCS_0054
    {
        public IntPtr pfnQueryVideoMemoryInfo;
        public IntPtr pfnQueryClockCalibration;
    }
}
