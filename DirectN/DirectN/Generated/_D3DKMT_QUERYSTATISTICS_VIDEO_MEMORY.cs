// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_VIDEO_MEMORY
    {
        public uint AllocsCommitted;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public _D3DKMT_QUERYSTATISTICS_COUNTER[] AllocsResidentInP;
        public _D3DKMT_QUERYSTATISTICS_COUNTER AllocsResidentInNonPreferred;
        public ulong TotalBytesEvictedDueToPreparation;
    }
}
