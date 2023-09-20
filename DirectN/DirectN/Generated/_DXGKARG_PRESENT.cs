// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;
using PHYSICAL_ADDRESS = System.Int64;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_PRESENT
    {
        public IntPtr pDmaBuffer;
        public uint DmaSize;
        public IntPtr pDmaBufferPrivateData;
        public uint DmaBufferPrivateDataSize;
        public _DXGKARG_PRESENT__union_0 __union_4;
        public IntPtr pPatchLocationListOut;
        public uint PatchLocationListOutSize;
        public uint MultipassOffset;
        public uint Color;
        public tagRECT DstRect;
        public tagRECT SrcRect;
        public uint SubRectCnt;
        public IntPtr pDstSubRects;
        public D3DDDI_FLIPINTERVAL_TYPE FlipInterval;
        public _DXGK_PRESENTFLAGS Flags;
        public uint DmaBufferSegmentId;
        public PHYSICAL_ADDRESS DmaBufferPhysicalAddress;
        public uint Reserved;
        public ulong DmaBufferGpuVirtualAddress;
        public uint NumSrcAllocations;
        public uint NumDstAllocations;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateDriverData;
    }
}
