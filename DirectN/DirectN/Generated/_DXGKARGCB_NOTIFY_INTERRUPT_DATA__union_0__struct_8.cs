// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(1067,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_8
    {
        public uint VidPnTargetId;
        public uint PhysicalAdapterMask;
        public uint MultiPlaneOverlayVsyncInfoCount;
        public IntPtr pMultiPlaneOverlayVsyncInfo;
        public ulong GpuFrequency;
        public ulong GpuClockCounter;
    }
}
