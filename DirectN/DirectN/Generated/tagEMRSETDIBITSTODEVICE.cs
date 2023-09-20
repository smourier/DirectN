// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRSETDIBITSTODEVICE
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public int xDest;
        public int yDest;
        public int xSrc;
        public int ySrc;
        public int cxSrc;
        public int cySrc;
        public uint offBmiSrc;
        public uint cbBmiSrc;
        public uint offBitsSrc;
        public uint cbBitsSrc;
        public uint iUsageSrc;
        public uint iStartScan;
        public uint cScans;
    }
}
