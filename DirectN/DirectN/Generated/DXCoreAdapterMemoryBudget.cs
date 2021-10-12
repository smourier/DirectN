// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcore_interface.h(91,1)
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
