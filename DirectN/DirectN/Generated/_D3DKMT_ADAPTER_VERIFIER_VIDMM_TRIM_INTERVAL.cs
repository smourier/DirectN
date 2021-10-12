// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(3042,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ADAPTER_VERIFIER_VIDMM_TRIM_INTERVAL
    {
        public ulong MinimumTrimInterval;
        public ulong MaximumTrimInterval;
        public ulong IdleTrimInterval;
    }
}
