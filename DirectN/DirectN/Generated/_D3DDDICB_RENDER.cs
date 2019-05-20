// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3dumddi.h(3553,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_RENDER
    {
        public uint CommandLength;
        public uint CommandOffset;
        public uint NumAllocations;
        public uint NumPatchLocations;
        public IntPtr pNewCommandBuffer;
        public uint NewCommandBufferSize;
        public IntPtr pNewAllocationList;
        public uint NewAllocationListSize;
        public IntPtr pNewPatchLocationList;
        public uint NewPatchLocationListSize;
        public _D3DDDICB_RENDERFLAGS Flags;
        public IntPtr hContext;
        public uint BroadcastContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public IntPtr[] BroadcastContext;
        public uint QueuedBufferCount;
        public ulong NewCommandBuffer;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
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
