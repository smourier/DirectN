// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(6133,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRALPHABLEND
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
        public int cxSrc;
        public int cySrc;
    }
}
