// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(3677,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_PROCESS_SEGMENT_GROUP_INFORMATION
    {
        public ulong Budget;
        public ulong Requested;
        public ulong Usage;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)] 
        public ulong[] Demoted;
    }
}
