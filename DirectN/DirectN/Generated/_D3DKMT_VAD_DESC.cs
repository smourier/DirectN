// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(2559,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_VAD_DESC
    {
        public uint VadIndex;
        public ulong VadAddress;
        public uint NumMappedRanges;
        public uint VadType;
        public ulong StartAddress;
        public ulong EndAddress;
    }
}
