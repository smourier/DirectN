// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(4209,9)
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
        public uint FirstAPISequenceNumberHigh;
        public uint CompletedAPISequenceNumberLow0Size;
        public uint CompletedAPISequenceNumberLow1Size;
        public uint BegunAPISequenceNumberLow0Size;
        public uint BegunAPISequenceNumberLow1Size;
        public IntPtr pCompletedAPISequenceNumberLow0;
        public IntPtr pCompletedAPISequenceNumberLow1;
        public IntPtr pBegunAPISequenceNumberLow0;
        public IntPtr pBegunAPISequenceNumberLow1;
    }
}
