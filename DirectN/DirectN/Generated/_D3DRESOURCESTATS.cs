// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3d9types.h(1898,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DRESOURCESTATS
    {
        public bool bThrashing;
        public uint ApproxBytesDownloaded;
        public uint NumEvicts;
        public uint NumVidCreates;
        public uint LastPri;
        public uint NumUsed;
        public uint NumUsedInVidMem;
        public uint WorkingSet;
        public uint WorkingSetBytes;
        public uint TotalManaged;
        public uint TotalBytes;
    }
}
