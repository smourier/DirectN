// generated from <Windows SDK Path>\um\gameinput.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct GameInputForceFeedbackPeriodicParams
    {
        public GameInputForceFeedbackEnvelope envelope;
        public GameInputForceFeedbackMagnitude magnitude;
        public float frequency;
        public float phase;
        public float bias;
    }
}
