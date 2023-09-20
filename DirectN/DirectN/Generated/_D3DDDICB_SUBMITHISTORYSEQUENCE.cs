// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SUBMITHISTORYSEQUENCE
    {
        public IntPtr hHwQueue;
        public ulong HwQueueProgressFenceId;
        public uint NumHistoryBuffers;
        public IntPtr HistoryBufferAddresses;
        public IntPtr HistoryBufferSizes;
        public uint PrecisionBits;
        public D3DDDI_MARKERLOGTYPE MarkerLogType;
        public uint RenderCBSequence;
        public _D3DDDICB_SUBMITHISTORYSEQUENCE__union_0 __union_8;
        public _D3DDDICB_SUBMITHISTORYSEQUENCE__union_1 __union_9;
        public uint TimestampArrayStride;
        public uint HistorySequenceCompletionSyncObject;
        public ulong HistorySequenceCompletionFenceValue;
    }
}
