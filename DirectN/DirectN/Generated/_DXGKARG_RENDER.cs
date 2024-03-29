﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

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
        public long DmaBufferPhysicalAddress;
    }
}
