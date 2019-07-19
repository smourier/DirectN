// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\opmapi.h(362,9)
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
