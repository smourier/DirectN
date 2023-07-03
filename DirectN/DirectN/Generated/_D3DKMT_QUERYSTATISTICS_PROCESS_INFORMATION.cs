// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3636,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_PROCESS_INFORMATION
    {
        public uint NodeCount;
        public uint VidPnSourceCount;
        public _D3DKMT_QUERYSTATISTICS_SYSTEM_MEMORY SystemMemory;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)] 
        public ulong[] Reserved;
    }
}
