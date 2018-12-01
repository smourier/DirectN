// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmp2dlna.h(160,9)
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
