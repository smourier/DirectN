// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputRawDeviceReportItemInfo
    {
        public uint bitOffset;
        public uint bitSize;
        public long logicalMin;
        public long logicalMax;
        public double physicalMin;
        public double physicalMax;
        public GameInputRawDevicePhysicalUnitKind physicalUnits;
        public uint rawPhysicalUnits;
        public int rawPhysicalUnitsExponent;
        public GameInputRawDeviceReportItemFlags flags;
        public uint usageCount;
        public IntPtr usages;
        public IntPtr collection;
        public IntPtr itemString;
    }
}
