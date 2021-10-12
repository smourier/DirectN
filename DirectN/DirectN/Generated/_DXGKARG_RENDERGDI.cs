// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(5121,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_RENDERGDI
    {
        public IntPtr pCommand;
        public uint CommandLength;
        public IntPtr pDmaBuffer;
        public ulong DmaBufferGpuVirtualAddress;
        public uint DmaSize;
        public IntPtr pDmaBufferPrivateData;
        public uint DmaBufferPrivateDataSize;
        public IntPtr pAllocationList;
        public uint AllocationListSize;
        public uint MultipassOffset;
    }
}
