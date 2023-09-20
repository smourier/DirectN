// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_TRIMPROCESSCOMMITMENT
    {
        public uint cbSize;
        public IntPtr hProcess;
        public _D3DKMT_TRIMPROCESSCOMMITMENT_FLAGS Flags;
        public ulong DecommitRequested;
        public ulong NumBytesDecommitted;
    }
}
