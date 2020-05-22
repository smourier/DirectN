// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxcore_interface.h(78,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DXCoreAdapterMemoryBudget
    {
        public int budget;
        public int currentUsage;
        public int availableForReservation;
        public int currentReservation;
    }
}
