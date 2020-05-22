// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmdt.h(1764,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXGKMDT_OPM_OUTPUT_ID
    {
        public _DXGKMDT_OPM_RANDOM_NUMBER rnRandomNumber;
        public uint ulStatusFlags;
        public ulong OutputId;
    }
}
