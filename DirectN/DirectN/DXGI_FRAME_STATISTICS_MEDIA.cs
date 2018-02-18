using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_FRAME_STATISTICS_MEDIA
    {
        public int PresentCount;
        public int PresentRefreshCount;
        public int SyncRefreshCount;
        public long SyncQPCTime;
        public long SyncGPUTime;
        public DXGI_FRAME_PRESENTATION_MODE CompositionMode;
        public int ApprovedPresentDuration;
    }
}
