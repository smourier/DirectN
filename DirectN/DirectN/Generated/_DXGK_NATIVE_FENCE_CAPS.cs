// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_NATIVE_FENCE_CAPS
    {
        public uint MonitoredValueStride;
        public byte MapToGpuSystemProcess;
        public ulong MinimumAddress;
        public ulong MaximumAddress;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)] 
        public byte[] Reserved;
    }
}
