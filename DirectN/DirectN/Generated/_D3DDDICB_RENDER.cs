// generated from <Windows SDK Path>\um\d3dumddi.h
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
        public _D3DDDICB_RENDER__union_0 __union_20;
        public _D3DDDICB_RENDER__union_1 __union_21;
    }
}
