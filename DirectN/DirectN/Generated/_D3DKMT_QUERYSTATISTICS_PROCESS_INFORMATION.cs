// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
