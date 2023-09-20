// generated from <Windows SDK Path>\um\opmapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _OPM_OUTPUT_ID_DATA
    {
        public _OPM_RANDOM_NUMBER rnRandomNumber;
        public uint ulStatusFlags;
        public ulong OutputId;
    }
}
