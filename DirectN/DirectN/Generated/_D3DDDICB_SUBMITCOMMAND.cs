// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(3975,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_SUBMITCOMMAND
    {
        public ulong Commands;
        public uint CommandLength;
        public _D3DDDICB_SUBMITCOMMANDFLAGS Flags;
        public uint BroadcastContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public IntPtr[] BroadcastContext;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public uint NumPrimaries;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public uint[] WrittenPrimaries;
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
        public uint Reserved;
        public uint NumHistoryBuffers;
        public IntPtr HistoryBufferArray;
        public IntPtr pReserved;
    }
}
