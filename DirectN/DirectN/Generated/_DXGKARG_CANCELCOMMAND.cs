// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(3973,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CANCELCOMMAND
    {
        public IntPtr hContext;
        public IntPtr pDmaBuffer;
        public uint DmaBufferSize;
        public uint DmaBufferSubmissionStartOffset;
        public uint DmaBufferSubmissionEndOffset;
        public IntPtr pDmaBufferPrivateData;
        public uint DmaBufferPrivateDataSize;
        public uint DmaBufferPrivateDataSubmissionStartOffset;
        public uint DmaBufferPrivateDataSubmissionEndOffset;
        public IntPtr pAllocationList;
        public uint AllocationListSize;
        public IntPtr pPatchLocationList;
        public uint PatchLocationListSize;
        public uint PatchLocationListSubmissionStart;
        public uint PatchLocationListSubmissionLength;
        public ulong DmaBufferVirtualAddress;
        public uint DmaBufferUmdPrivateDataSize;
    }
}
