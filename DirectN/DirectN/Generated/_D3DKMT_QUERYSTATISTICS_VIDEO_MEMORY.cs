// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3789,9)
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
