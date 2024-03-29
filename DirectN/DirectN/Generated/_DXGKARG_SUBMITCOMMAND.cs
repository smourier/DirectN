﻿// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SUBMITCOMMAND
    {
        public _DXGKARG_SUBMITCOMMAND__union_0 __union_0;
        public uint DmaBufferSegmentId;
        public long DmaBufferPhysicalAddress;
        public uint DmaBufferSize;
        public uint DmaBufferSubmissionStartOffset;
        public uint DmaBufferSubmissionEndOffset;
        public IntPtr pDmaBufferPrivateData;
        public uint DmaBufferPrivateDataSize;
        public uint DmaBufferPrivateDataSubmissionStartOffset;
        public uint DmaBufferPrivateDataSubmissionEndOffset;
        public uint SubmissionFenceId;
        public uint VidPnSourceId;
        public D3DDDI_FLIPINTERVAL_TYPE FlipInterval;
        public _DXGK_SUBMITCOMMANDFLAGS Flags;
        public uint EngineOrdinal;
        public ulong DmaBufferVirtualAddress;
        public uint NodeOrdinal;
    }
}
