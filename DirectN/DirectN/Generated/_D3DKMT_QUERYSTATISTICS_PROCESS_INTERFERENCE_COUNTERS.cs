// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(3683,9)
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
