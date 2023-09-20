// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
