// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\dxgi1_4.h(1201,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXGI_QUERY_VIDEO_MEMORY_INFO
    {
        public ulong Budget;
        public ulong CurrentUsage;
        public ulong AvailableForReservation;
        public ulong CurrentReservation;
    }
}
