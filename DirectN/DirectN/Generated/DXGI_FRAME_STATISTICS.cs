// generated from <Windows SDK Path>\shared\dxgi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_FRAME_STATISTICS
    {
        public uint PresentCount;
        public uint PresentRefreshCount;
        public uint SyncRefreshCount;
        public long SyncQPCTime;
        public long SyncGPUTime;
    }
}
