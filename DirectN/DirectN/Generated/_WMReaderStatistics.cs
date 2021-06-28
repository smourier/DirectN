// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(1496,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _WMReaderStatistics
    {
        public uint cbSize;
        public uint dwBandwidth;
        public uint cPacketsReceived;
        public uint cPacketsRecovered;
        public uint cPacketsLost;
        public ushort wQuality;
    }
}
