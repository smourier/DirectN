// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawi.h(233,9)
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
