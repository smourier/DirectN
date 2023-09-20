// generated from <Windows SDK Path>\um\d3dcaps.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DDEVINFO_TEXTUREMANAGER
    {
        public bool bThrashing;
        public uint dwApproxBytesDownloaded;
        public uint dwNumEvicts;
        public uint dwNumVidCreates;
        public uint dwNumTexturesUsed;
        public uint dwNumUsedTexInVid;
        public uint dwWorkingSet;
        public uint dwWorkingSetBytes;
        public uint dwTotalManaged;
        public uint dwTotalBytes;
        public uint dwLastPri;
    }
}
