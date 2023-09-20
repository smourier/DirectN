// generated from <Windows SDK Path>\shared\d3d9types.h
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DPRESENTSTATS_32
    {
        public uint PresentCount;
        public uint PresentRefreshCount;
        public uint SyncRefreshCount;
        public long SyncQPCTime;
        public long SyncGPUTime;
    }

    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DPRESENTSTATS_64
    {
        public uint PresentCount;
        public uint PresentRefreshCount;
        public uint SyncRefreshCount;
        public long SyncQPCTime;
        public long SyncGPUTime;
    }
}
