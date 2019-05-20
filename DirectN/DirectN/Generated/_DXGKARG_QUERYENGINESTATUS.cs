// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(7130,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_QUERYENGINESTATUS
    {
        public uint NodeOrdinal;
        public uint EngineOrdinal;
        public _DXGK_ENGINESTATUS EngineStatus;
    }
}
