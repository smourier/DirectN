// generated from <Windows SDK Path>\um\d3dcaps.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDEVINFO_TEXTURING
    {
        public uint dwNumLoads;
        public uint dwApproxBytesLoaded;
        public uint dwNumPreLoads;
        public uint dwNumSet;
        public uint dwNumCreates;
        public uint dwNumDestroys;
        public uint dwNumSetPriorities;
        public uint dwNumSetLODs;
        public uint dwNumLocks;
        public uint dwNumGetDCs;
    }
}
