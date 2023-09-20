// generated from <Windows SDK Path>\um\ddrawi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _PROCESS_LIST
    {
        public IntPtr lpLink;
        public uint dwProcessId;
        public uint dwRefCnt;
        public uint dwAlphaDepth;
        public uint dwZDepth;
    }
}
