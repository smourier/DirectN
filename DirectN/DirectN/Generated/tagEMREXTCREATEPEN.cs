// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wingdi.h(5973,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMREXTCREATEPEN
    {
        public tagEMR emr;
        public uint ihPen;
        public uint offBmi;
        public uint cbBmi;
        public uint offBits;
        public uint cbBits;
        public tagEXTLOGPEN32 elp;
    }
}
