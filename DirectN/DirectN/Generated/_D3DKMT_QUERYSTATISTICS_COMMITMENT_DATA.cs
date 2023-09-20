// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_COMMITMENT_DATA
    {
        public ulong TotalBytesEvictedFromProcess;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public ulong[] BytesBySegmentPreference;
    }
}
