// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using DXGKDDI_MONITOR_ACQUIREMONITORSOURCEMODESET = System.IntPtr;
using DXGKDDI_MONITOR_GETMONITORDESCRIPTORSET = System.IntPtr;
using DXGKDDI_MONITOR_GETMONITORFREQUENCYRANGESET = System.IntPtr;
using DXGKDDI_MONITOR_RELEASEMONITORSOURCEMODESET = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MONITOR_INTERFACE
    {
        public _DXGK_MONITOR_INTERFACE_VERSION Version;
        public IntPtr pfnAcquireMonitorSourceModeSet;
        public IntPtr pfnReleaseMonitorSourceModeSet;
        public IntPtr pfnGetMonitorFrequencyRangeSet;
        public IntPtr pfnGetMonitorDescriptorSet;
    }
}
