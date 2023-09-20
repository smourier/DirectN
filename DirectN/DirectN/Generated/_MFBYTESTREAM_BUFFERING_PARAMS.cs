// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFBYTESTREAM_BUFFERING_PARAMS
    {
        public ulong cbTotalFileSize;
        public ulong cbPlayableDataSize;
        public IntPtr prgBuckets;
        public uint cBuckets;
        public ulong qwNetBufferingTime;
        public ulong qwExtraBufferingTimeDuringSeek;
        public ulong qwPlayDuration;
        public float dRate;
    }
}
