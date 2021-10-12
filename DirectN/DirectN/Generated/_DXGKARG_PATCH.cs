// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(3793,9)
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_PATCH
    {
        public _DXGKARG_PATCH__union_0 __union_0;
        public uint DmaBufferSegmentId;
        public PHYSICAL_ADDRESS DmaBufferPhysicalAddress;
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
        public uint SubmissionFenceId;
        public _DXGK_PATCHFLAGS Flags;
        public uint EngineOrdinal;
    }
}
