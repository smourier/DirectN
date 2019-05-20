// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(4392,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_SETSCHEDULINGLOGBUFFER
    {
        public uint NodeOrdinal;
        public uint EngineOrdinal;
        public uint NumberOfEntries;
        public IntPtr LogBufferCpuVa;
        public ulong LogBufferGpuVa;
        public uint InterruptEntry;
    }
}
