// generated from <Windows SDK Path>\shared\dcomptypes.h
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
