// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(5041,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SIGNALMONITOREDFENCE
    {
        public _DXGK_KERNEL_SUBMISSION_TYPE KernelSubmissionType;
        public IntPtr pDmaBuffer;
        public ulong DmaBufferGpuVirtualAddress;
        public uint DmaSize;
        public IntPtr pDmaBufferPrivateData;
        public uint DmaBufferPrivateDataSize;
        public uint MultipassOffset;
        public ulong MonitoredFenceGpuVa;
        public ulong MonitoredFenceValue;
        public IntPtr MonitoredFenceCpuVa;
        public IntPtr hHwQueue;
    }
}
