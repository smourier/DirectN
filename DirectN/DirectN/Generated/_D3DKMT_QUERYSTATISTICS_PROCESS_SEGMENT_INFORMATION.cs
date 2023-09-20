// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_PROCESS_SEGMENT_INFORMATION
    {
        public ulong BytesCommitted;
        public ulong MaximumWorkingSet;
        public ulong MinimumWorkingSet;
        public uint NbReferencedAllocationEvictedInPeriod;
        public uint Padding;
        public _D3DKMT_QUERYSTATISTICS_VIDEO_MEMORY VideoMemory;
        public _D3DKMT_QUERYSTATISTICS_PROCESS_SEGMENT_POLICY _Policy;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public ulong[] Reserved;
    }
}
