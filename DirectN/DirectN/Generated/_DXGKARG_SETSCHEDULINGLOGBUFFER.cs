// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
