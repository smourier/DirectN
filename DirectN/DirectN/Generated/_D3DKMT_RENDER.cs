// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_RENDER
    {
        public _D3DKMT_RENDER__union_0 __union_0;
        public uint CommandOffset;
        public uint CommandLength;
        public uint AllocationCount;
        public uint PatchLocationCount;
        public IntPtr pNewCommandBuffer;
        public uint NewCommandBufferSize;
        public IntPtr pNewAllocationList;
        public uint NewAllocationListSize;
        public IntPtr pNewPatchLocationList;
        public uint NewPatchLocationListSize;
        public _D3DKMT_RENDERFLAGS Flags;
        public ulong PresentHistoryToken;
        public uint BroadcastContextCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public uint[] BroadcastContext;
        public uint QueuedBufferCount;
        public ulong NewCommandBuffer;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}
