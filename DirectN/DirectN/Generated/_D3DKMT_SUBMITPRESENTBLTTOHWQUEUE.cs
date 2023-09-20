// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_SUBMITPRESENTBLTTOHWQUEUE
    {
        public uint hHwQueue;
        public ulong HwQueueProgressFenceId;
        public _D3DKMT_PRESENT PrivatePresentData;
    }
}
