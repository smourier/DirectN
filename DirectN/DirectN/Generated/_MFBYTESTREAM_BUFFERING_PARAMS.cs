// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(11586,24)
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
