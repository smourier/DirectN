// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_PATCH
    {
        public _DXGKARG_PATCH__union_0 __union_0;
        public uint DmaBufferSegmentId;
        public long DmaBufferPhysicalAddress;
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
