// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(3276,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYSTATISTICS_NODE_INFORMATION
    {
        public _D3DKMT_QUERYSTATISTICS_PROCESS_NODE_INFORMATION GlobalInformation;
        public _D3DKMT_QUERYSTATISTICS_PROCESS_NODE_INFORMATION SystemInformation;
        public _D3DKMT_NODE_PERFDATA NodePerfData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public uint[] Reserved;
    }
}
