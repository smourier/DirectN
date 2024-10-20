// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputForceFeedbackMotorInfo
    {
        public GameInputFeedbackAxes supportedAxes;
        public GameInputLocation location;
        public uint locationId;
        public uint maxSimultaneousEffects;
        public bool isConstantEffectSupported;
        public bool isRampEffectSupported;
        public bool isSineWaveEffectSupported;
        public bool isSquareWaveEffectSupported;
        public bool isTriangleWaveEffectSupported;
        public bool isSawtoothUpWaveEffectSupported;
        public bool isSawtoothDownWaveEffectSupported;
        public bool isSpringEffectSupported;
        public bool isFrictionEffectSupported;
        public bool isDamperEffectSupported;
        public bool isInertiaEffectSupported;
    }
}
