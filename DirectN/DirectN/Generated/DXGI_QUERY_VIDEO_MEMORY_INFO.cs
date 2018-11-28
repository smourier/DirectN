using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DXGI_QUERY_VIDEO_MEMORY_INFO
    {
        public long Budget;
        public long CurrentUsage;
        public long AvailableForReservation;
        public long CurrentReservation;
    }
}
