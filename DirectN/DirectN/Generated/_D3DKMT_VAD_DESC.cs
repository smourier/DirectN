// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
