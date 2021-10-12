// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(7402,9)
using System;
using System.Runtime.InteropServices;
using DXGKDDI_MONITOR_ACQUIREMONITORSOURCEMODESET = System.IntPtr;
using DXGKDDI_MONITOR_GETADDITIONALMONITORMODESET = System.IntPtr;
using DXGKDDI_MONITOR_GETMONITORDESCRIPTORSET = System.IntPtr;
using DXGKDDI_MONITOR_GETMONITORFREQUENCYRANGESET = System.IntPtr;
using DXGKDDI_MONITOR_RELEASEADDITIONALMONITORMODESET = System.IntPtr;
using DXGKDDI_MONITOR_RELEASEMONITORSOURCEMODESET = System.IntPtr;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_MONITOR_INTERFACE_V2
    {
        public _DXGK_MONITOR_INTERFACE_VERSION Version;
        public IntPtr pfnAcquireMonitorSourceModeSet;
        public IntPtr pfnReleaseMonitorSourceModeSet;
        public IntPtr pfnGetMonitorFrequencyRangeSet;
        public IntPtr pfnGetMonitorDescriptorSet;
        public IntPtr pfnGetAdditionalMonitorModeSet;
        public IntPtr pfnReleaseAdditionalMonitorModeSet;
    }
}
