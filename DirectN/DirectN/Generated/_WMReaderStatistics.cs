// generated from <Windows SDK Path>\um\wmsdkidl.h
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
