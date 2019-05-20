// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\dxgi1_3.h(1662,9)
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
