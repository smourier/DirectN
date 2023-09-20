// generated from <Windows SDK Path>\um\mfmp2dlna.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFMPEG2DLNASINKSTATS
    {
        public ulong cBytesWritten;
        public bool fPAL;
        public uint fccVideo;
        public uint dwVideoWidth;
        public uint dwVideoHeight;
        public ulong cVideoFramesReceived;
        public ulong cVideoFramesEncoded;
        public ulong cVideoFramesSkipped;
        public ulong cBlackVideoFramesEncoded;
        public ulong cVideoFramesDuplicated;
        public uint cAudioSamplesPerSec;
        public uint cAudioChannels;
        public ulong cAudioBytesReceived;
        public ulong cAudioFramesEncoded;
    }
}
