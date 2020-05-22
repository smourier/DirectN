// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wingdi.h(798,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagBITMAPCOREHEADER
    {
        public uint bcSize;
        public ushort bcWidth;
        public ushort bcHeight;
        public ushort bcPlanes;
        public ushort bcBitCount;
    }
}
