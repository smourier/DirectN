// generated from <Windows SDK Path>\um\mftransform.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFT_INPUT_STREAM_INFO
    {
        public long hnsMaxLatency;
        public uint dwFlags;
        public uint cbSize;
        public uint cbMaxLookahead;
        public uint cbAlignment;
    }
}
