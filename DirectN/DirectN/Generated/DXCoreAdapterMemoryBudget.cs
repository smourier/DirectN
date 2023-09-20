// generated from <Windows SDK Path>\um\dxcore_interface.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXCoreAdapterMemoryBudget
    {
        public ulong budget;
        public ulong currentUsage;
        public ulong availableForReservation;
        public ulong currentReservation;
    }
}
