// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputForceFeedbackEnvelope
    {
        public ulong attackDuration;
        public ulong sustainDuration;
        public ulong releaseDuration;
        public float attackGain;
        public float sustainGain;
        public float releaseGain;
        public uint playCount;
        public ulong repeatDelay;
    }
}
