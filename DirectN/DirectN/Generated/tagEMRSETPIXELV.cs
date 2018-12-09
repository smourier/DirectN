// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wingdi.h(5639,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRSETPIXELV
    {
        public tagEMR emr;
        public _POINTL ptlPixel;
        public uint crColor;
    }
}
