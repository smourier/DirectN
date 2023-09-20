// generated from <Windows SDK Path>\shared\dxgi1_3.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_FRAME_STATISTICS_MEDIA
    {
        public uint PresentCount;
        public uint PresentRefreshCount;
        public uint SyncRefreshCount;
        public long SyncQPCTime;
        public long SyncGPUTime;
        public DXGI_FRAME_PRESENTATION_MODE CompositionMode;
        public uint ApprovedPresentDuration;
    }
}
