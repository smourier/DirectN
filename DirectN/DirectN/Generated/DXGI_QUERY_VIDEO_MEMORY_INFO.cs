// generated from <Windows SDK Path>\shared\dxgi1_4.h
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
