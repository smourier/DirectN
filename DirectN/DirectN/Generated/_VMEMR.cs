// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dmemmgr.h(108,9)
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
