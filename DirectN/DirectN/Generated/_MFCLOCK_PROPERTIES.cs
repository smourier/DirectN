// generated from <Windows SDK Path>\um\mfidl.h
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
