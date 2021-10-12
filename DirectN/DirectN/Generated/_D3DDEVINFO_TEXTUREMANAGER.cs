// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dcaps.h(572,9)
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
