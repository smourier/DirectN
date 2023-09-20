// generated from <Windows SDK Path>\um\dmemmgr.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _VMEMR
    {
        public IntPtr next;
        public IntPtr prev;
        public IntPtr pUp;
        public IntPtr pDown;
        public IntPtr pLeft;
        public IntPtr pRight;
        public ulong ptr;
        public uint size;
        public uint x;
        public uint y;
        public uint cx;
        public uint cy;
        public uint flags;
        public ulong pBits;
        public bool bDiscardable;
    }
}
