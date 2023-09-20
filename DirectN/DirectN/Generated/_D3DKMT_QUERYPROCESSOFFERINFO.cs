// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYPROCESSOFFERINFO
    {
        public uint cbSize;
        public IntPtr hProcess;
        public ulong DecommitUniqueness;
        public ulong DecommittableBytes;
    }
}
