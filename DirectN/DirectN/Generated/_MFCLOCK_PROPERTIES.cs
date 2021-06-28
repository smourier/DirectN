// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(5171,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFCLOCK_PROPERTIES
    {
        public ulong qwCorrelationRate;
        public Guid guidClockId;
        public uint dwClockFlags;
        public ulong qwClockFrequency;
        public uint dwClockTolerance;
        public uint dwClockJitter;
    }
}
