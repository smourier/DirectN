// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12umddi.h(10720,9)
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
