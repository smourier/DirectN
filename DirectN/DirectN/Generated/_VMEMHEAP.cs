// generated from <Windows SDK Path>\um\dmemmgr.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VMEMHEAP
    {
        public uint dwFlags;
        public uint stride;
        public IntPtr freeList;
        public IntPtr allocList;
        public uint dwTotalSize;
        public ulong fpGARTLin;
        public ulong fpGARTDev;
        public uint dwCommitedSize;
        public uint dwCoalesceCount;
        public _HEAPALIGNMENT Alignment;
        public int ddsCapsEx;
        public int ddsCapsExAlt;
        public long liPhysAGPBase;
        public IntPtr hdevAGP;
        public IntPtr pvPhysRsrv;
        public IntPtr pAgpCommitMask;
        public uint dwAgpCommitMaskSize;
    }
}
