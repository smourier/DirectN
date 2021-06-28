// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(21136,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDVD_MUA_MixingInfo
    {
        public bool fMixTo0;
        public bool fMixTo1;
        public bool fMix0InPhase;
        public bool fMix1InPhase;
        public uint dwSpeakerPosition;
    }
}
