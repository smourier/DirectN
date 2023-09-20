// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRBITBLT
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public int xDest;
        public int yDest;
        public int cxDest;
        public int cyDest;
        public uint dwRop;
        public int xSrc;
        public int ySrc;
        public tagXFORM xformSrc;
        public uint crBkColorSrc;
        public uint iUsageSrc;
        public uint offBmiSrc;
        public uint cbBmiSrc;
        public uint offBitsSrc;
        public uint cbBitsSrc;
    }
}
