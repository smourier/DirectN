// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmcodecdsp.h(3685,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagAecQualityMetrics_Struct
    {
        public long i64Timestamp;
        public byte ConvergenceFlag;
        public byte MicClippedFlag;
        public byte MicSilenceFlag;
        public byte PstvFeadbackFlag;
        public byte SpkClippedFlag;
        public byte SpkMuteFlag;
        public byte GlitchFlag;
        public byte DoubleTalkFlag;
        public uint uGlitchCount;
        public uint uMicClipCount;
        public float fDuration;
        public float fTSVariance;
        public float fTSDriftRate;
        public float fVoiceLevel;
        public float fNoiseLevel;
        public float fERLE;
        public float fAvgERLE;
        public uint dwReserved;
    }
}
