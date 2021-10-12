// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(130,9)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_RENDER
    {
        public IntPtr pCommand;
        public uint CommandLength;
        public IntPtr pDmaBuffer;
        public uint DmaSize;
        public IntPtr pDmaBufferPrivateData;
        public uint DmaBufferPrivateDataSize;
        public IntPtr pAllocationList;
        public uint AllocationListSize;
        public IntPtr pPatchLocationListIn;
        public uint PatchLocationListInSize;
        public IntPtr pPatchLocationListOut;
        public uint PatchLocationListOutSize;
        public uint MultipassOffset;
        public uint DmaBufferSegmentId;
        public PHYSICAL_ADDRESS DmaBufferPhysicalAddress;
    }
}
