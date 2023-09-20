// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_PROCESS_INTERFERENCE_COUNTERS
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)] 
        public ulong[] InterferenceCount;
    }
}
