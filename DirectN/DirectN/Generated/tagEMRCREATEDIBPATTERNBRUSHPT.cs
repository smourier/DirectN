// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\wingdi.h(6051,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRCREATEDIBPATTERNBRUSHPT
    {
        public tagEMR emr;
        public uint ihBrush;
        public uint iUsage;
        public uint offBmi;
        public uint cbBmi;
        public uint offBits;
        public uint cbBits;
    }
}
