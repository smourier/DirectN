// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dcomptypes.h(143,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagCOMPOSITION_STATS
    {
        public uint presentCount;
        public uint refreshCount;
        public uint virtualRefreshCount;
        public ulong time;
    }
}
