// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
