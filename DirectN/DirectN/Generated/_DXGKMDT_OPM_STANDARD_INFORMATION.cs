// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmdt.h(1732,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_STANDARD_INFORMATION
    {
        public _DXGKMDT_OPM_RANDOM_NUMBER rnRandomNumber;
        public uint ulStatusFlags;
        public uint ulInformation;
        public uint ulReserved;
        public uint ulReserved2;
    }
}
