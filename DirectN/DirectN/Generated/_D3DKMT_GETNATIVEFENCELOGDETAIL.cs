// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_GETNATIVEFENCELOGDETAIL
    {
        public uint hHwQueue;
        public _D3DKMT_GETNATIVEFENCELOGDETAIL_FLAGS Flags;
        public uint WaitLogNumberOfEntries;
        public uint SignalLogNumberOfEntries;
        public ulong WaitLogGpuBaseAddress;
        public ulong SignalLogGpuBaseAddress;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)] 
        public byte[] Reserved;
    }
}
