// generated from <Windows SDK Path>\um\dmemmgr.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VMEML
    {
        public IntPtr next;
        public ulong ptr;
        public uint size;
        public bool bDiscardable;
    }
}
