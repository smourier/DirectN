// generated from <Windows SDK Path>\um\audioclientactivationparams.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct AUDIOCLIENT_PROCESS_LOOPBACK_PARAMS
    {
        public uint TargetProcessId;
        public PROCESS_LOOPBACK_MODE ProcessLoopbackMode;
    }
}
