// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(3655,9)
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
        public _D3DKMT_QUERYSTATISTICS_VIDEO_MEMORY VideoMemory;
        public _D3DKMT_QUERYSTATISTICS_PROCESS_SEGMENT_POLICY _Policy;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)] 
        public ulong[] Reserved;
    }
}
