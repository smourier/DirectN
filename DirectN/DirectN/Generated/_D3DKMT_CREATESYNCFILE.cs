// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATESYNCFILE
    {
        public uint hDevice;
        public uint hMonitoredFence;
        public ulong FenceValue;
        public ulong hSyncFile;
    }
}
