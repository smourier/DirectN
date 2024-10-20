// generated from <Windows SDK Path>\shared\d3dukmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_NATIVE_FENCE_LOG_ENTRY
    {
        public ulong FenceValue;
        public uint hNativeFence;
        public uint OperationType;
        public ulong Reserved0;
        public ulong FenceObservedGpuTimestamp;
        public ulong Reserved1;
        public ulong FenceEndGpuTimestamp;
    }
}
