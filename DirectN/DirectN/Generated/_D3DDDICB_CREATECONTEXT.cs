// generated from <Windows SDK Path>\um\d3dumddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDICB_CREATECONTEXT
    {
        public uint NodeOrdinal;
        public uint EngineAffinity;
        public _D3DDDI_CREATECONTEXTFLAGS Flags;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public IntPtr hContext;
        public IntPtr pCommandBuffer;
        public uint CommandBufferSize;
        public IntPtr pAllocationList;
        public uint AllocationListSize;
        public IntPtr pPatchLocationList;
        public uint PatchLocationListSize;
        public ulong CommandBuffer;
    }
}
