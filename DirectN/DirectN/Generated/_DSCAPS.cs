// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DSCAPS
    {
        public uint dwSize;
        public uint dwFlags;
        public uint dwMinSecondarySampleRate;
        public uint dwMaxSecondarySampleRate;
        public uint dwPrimaryBuffers;
        public uint dwMaxHwMixingAllBuffers;
        public uint dwMaxHwMixingStaticBuffers;
        public uint dwMaxHwMixingStreamingBuffers;
        public uint dwFreeHwMixingAllBuffers;
        public uint dwFreeHwMixingStaticBuffers;
        public uint dwFreeHwMixingStreamingBuffers;
        public uint dwMaxHw3DAllBuffers;
        public uint dwMaxHw3DStaticBuffers;
        public uint dwMaxHw3DStreamingBuffers;
        public uint dwFreeHw3DAllBuffers;
        public uint dwFreeHw3DStaticBuffers;
        public uint dwFreeHw3DStreamingBuffers;
        public uint dwTotalHwMemBytes;
        public uint dwFreeHwMemBytes;
        public uint dwMaxContigFreeHwMemBytes;
        public uint dwUnlockTransferRateHwBuffers;
        public uint dwPlayCpuOverheadSwBuffers;
        public uint dwReserved1;
        public uint dwReserved2;
    }
}
