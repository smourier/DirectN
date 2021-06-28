// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(22946,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_DECODER_CAPS
    {
        public uint dwSize;
        public uint dwAudioCaps;
        public double dFwdMaxRateVideo;
        public double dFwdMaxRateAudio;
        public double dFwdMaxRateSP;
        public double dBwdMaxRateVideo;
        public double dBwdMaxRateAudio;
        public double dBwdMaxRateSP;
        public uint dwRes1;
        public uint dwRes2;
        public uint dwRes3;
        public uint dwRes4;
    }
}
