// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wingdi.h(1054,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagMETAHEADER
    {
        public ushort mtType;
        public ushort mtHeaderSize;
        public ushort mtVersion;
        public uint mtSize;
        public ushort mtNoObjects;
        public uint mtMaxRecord;
        public ushort mtNoParameters;
    }
}
