// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dcaps.h(586,9)
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
